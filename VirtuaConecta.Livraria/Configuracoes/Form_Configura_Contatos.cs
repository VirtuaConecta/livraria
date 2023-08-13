using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtuaConecta.Outbound.Business;
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Outbound.Parametros;
using VirtuaConecta.Outbound.Utility;
using xDialog;

namespace VirtuaConecta.Outbound.AI.Configuracoes
{

    // TODO #1 Verificar se as opços de filtros criadas estão de acordo com a porposta 09/03/2020

    public partial class Form_Configura_Contatos : MaterialSkin.Controls.MaterialForm
    {
        Business.BaseBis.IcontatoBLL _contatos;
        Business.BaseBis.iconfBLL _iconfig;
        Business.BaseBis.IcarteiraBLL _icarteira;
        Business.BaseBis.IusuarioBll _user;
        BindingList<String> ListaCarteira = new BindingList<String>();
        BindingList<String> ListaPrioridade = new BindingList<String>();
        String Acao = null;
        List<SequenciaDTO> Seq = new List<SequenciaDTO>();
        public Form_Configura_Contatos()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Green100, Primary.Green400, Primary.Green500,
                Accent.LightGreen200, TextShade.WHITE);

            _contatos = Factory.CriarContatosBLL();
            _iconfig = Factory.CriaConfigListaBLL();
            _user = Factory.CriaUsuarioBLL();
            _icarteira = Factory.CriaCarteiraBLL();

        }

        private void Form_Configura_Contatos_Load(object sender, EventArgs e)
        {
            HabilitaObjetos(false);
            CarregaOperadores();
            CarregaSequenciaConato();
            HabilitaForm();
        }

        private void HabilitaForm()
        {

            CarregaListaCarteiraDispo();


            txtDias.Text = "0";
            ckb_Cancelados.Checked = true;


        }


        private void CarregaOperadores()
        {

            var listusr = _user.ListaUsuariosAtivos().Select(x => x.LoginUsuario).ToList();

            cmbOperador.DataSource = listusr;
            cmbOperador.SelectedIndex = -1;

        }
        private void CarregaListaCarteiraDispo()
        {
            var listastr = _icarteira.ListaCarteiraDiponivel().Select(x => x.Carteira).ToList();

            ListaCarteiraDispo.DataSource = listastr;
            // ListaCarteiraDispo.DisplayMember = "Canal_venda";
        }

        private void CarregaSequenciaConato()
        {


            ListaPrioridadeDispo.Items.Add("DIAS SEM COMPRAS");
            ListaPrioridadeDispo.Items.Add("VALOR MAIOR COMPRA");
            ListaPrioridadeDispo.Items.Add("ÚLTIMA COMPRA");
            ListaPrioridadeDispo.Items.Add("ÚLTIMA LIGAÇÃO");


        }

        public void CarregaGrid(String filtro)
        {
            Seq = new List<SequenciaDTO>();
            var listaFinal = new List<ContatosDTO>();
            var list1 = _contatos.ListaContatos(filtro).ToList();

            var filtroAgenda = " WHERE date(data_agenda_contato) >= date(now()) AND operador_ult_contato='" + cmbOperador.SelectedItem.ToString() + "'  AND  UPPER( Left(situacao,1))<>'C' ORDER BY data_agenda_contato";

            var lista2 = _contatos.ListaContatos(filtroAgenda).ToList();

            if (lista2.Count > 0)
            {
                listaFinal = list1.Union(lista2).ToList();
            }
            else
            {
                listaFinal = list1;
            }

            int conSeq = 1;

            foreach (var contato in listaFinal)
            {
                var itemSeq = new SequenciaDTO();

                itemSeq.Seq = conSeq;
                itemSeq.Id_contato = contato.Id;
                Seq.Add(itemSeq);
                conSeq++;
            }



            var listaContatos = (listaFinal.Join(
                                       Seq,
                                       t1 => t1.Id,
                                       t2 => t2.Id_contato,
                                       (t1, t2) => new { t1, t2 })
                .Select(e => new
                {
                    e.t1.Id,
                    e.t1.Canal_venda,
                    e.t1.Cnpj,
                    e.t1.Id_cliente,
                    e.t1.Cliente,
                    e.t1.Estado,

                    e.t1.Telefone,
                    e.t1.Situacao,
                    e.t1.Descricao_status,
                    e.t1.Dias_sem_compra,
                    e.t1.Dia_ult_compra,
                    e.t1.Data_Agenda_contato,
                    e.t1.Data_contato,

                    e.t1.Email,
                    e.t1.Endereco,
                    e.t1.Bairro,
                    e.t1.Cep,
                    e.t1.Cidade,
                    e.t1.Cod_municipio,
                    e.t1.Em_atendimento,
                    e.t1.EnderecoEntrega,
                    e.t1.Nome_contato,
                    e.t1.Status_contato,
                    e.t1.valorMaiorCompra,
                    e.t2.Seq

                }))



                .ToList();

            lblNrReg.Text = listaContatos.Count().ToString();


            DgListaContatos.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top);


            var Source = new BindingSource(listaContatos, null);
            DgListaContatos.DataSource = Source;


            DgListaContatos.AutoResizeColumn(0);

            DgListaContatos.AutoResizeColumn(2);
            //  DgListaContatos.AutoResizeColumn(4);
            DgListaContatos.AutoResizeColumn(4);
            DgListaContatos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
            // DgListaContatos.DefaultCellStyle.Font = new Font("Arial", 10);

            DgListaContatos.Columns[0].Visible = false;
            DgListaContatos.Columns[1].HeaderText = "Canal";
            DgListaContatos.Columns[2].HeaderText = "Cnpj";
            DgListaContatos.Columns[3].HeaderText = "Cod Cliente";
            DgListaContatos.Columns[4].HeaderText = "Nome/Razão Social";


            DgListaContatos.Columns[5].HeaderText = "Estado";
            DgListaContatos.Columns[6].HeaderText = "Telefone";
            DgListaContatos.Columns[7].HeaderText = "Situacao";
            DgListaContatos.Columns[8].HeaderText = "Status";
            DgListaContatos.Columns[9].HeaderText = "Dias S/C";
            DgListaContatos.Columns[10].HeaderText = "Dia Ult/C";
            DgListaContatos.Columns[11].HeaderText = "Dt Agenda";
            DgListaContatos.Columns[12].HeaderText = "Ult Contato";
            DgListaContatos.Columns[23].HeaderText = "Valor Maior Compra";
            DgListaContatos.Columns[24].HeaderText = "Seq";

            DgListaContatos.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DgListaContatos.Columns[13].Visible = false;

            DgListaContatos.Columns[14].Visible = false;
            DgListaContatos.Columns[15].Visible = false;
            DgListaContatos.Columns[16].Visible = false;
            DgListaContatos.Columns[17].Visible = false;
            DgListaContatos.Columns[18].Visible = false;
            DgListaContatos.Columns[19].Visible = false;
            DgListaContatos.Columns[20].Visible = false;
            DgListaContatos.Columns[21].Visible = false;
            DgListaContatos.Columns[22].Visible = false;
            DgListaContatos.BorderStyle = BorderStyle.None;
            DgListaContatos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DgListaContatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgListaContatos.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            DgListaContatos.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DgListaContatos.BackgroundColor = Color.White;

            DgListaContatos.EnableHeadersVisualStyles = false;
            DgListaContatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            DgListaContatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 81, 100);
            DgListaContatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        private void ListaCarteiraDispo_DoubleClick(object sender, EventArgs e)
        {
            try
            {


                if (ListaCarteiraDispo.SelectedItem != null)
                {

                    var itemSelecionado = ListaCarteiraDispo.SelectedItem.ToString();
                    // indisponibiliza a carteira
                    var itemCarteira = new CarteirasDTO() { Carteira = itemSelecionado, Reservado = 1, Usuario = cmbOperador.SelectedItem.ToString() };
                    _icarteira.EditaCarteira(itemCarteira);


                    var itemPesquisado = ListaCarteira.Where(x => x.Contains(itemSelecionado)).FirstOrDefault();
                    if (String.IsNullOrEmpty(itemPesquisado))
                    {
                        ListaCarteira.Add(itemSelecionado);
                    }
                    ListaCarteiraSel.DataSource = ListaCarteira;
                }
            }
            catch (Exception ex)
            {

                Log.Error("Erro ao listar Carteira Disponivel: " + ex.Message);
            }

            CarregaListaCarteiraDispo();
        }

        private void ListaCarteiraSel_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                var itemaApagar = ListaCarteiraSel.SelectedItem.ToString();

                var itemCarteira = new CarteirasDTO() { Carteira = itemaApagar, Reservado = 0, Usuario = null };
                _icarteira.EditaCarteira(itemCarteira);

                BindingList<String> novalista = new BindingList<String>(ListaCarteira.Where(x => x.Contains(itemaApagar) == false).ToList());

                ListaCarteiraSel.DataSource = null;
                ListaCarteiraSel.DataSource = novalista;

                ListaCarteira = novalista;

                CarregaListaCarteiraDispo();
            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro ListaCarteiraSel_DoubleClick : " + ex.Message.ToString(), MessageType.Error);
            }
        }

        //Click seleciona todas as carteiras
        private void chk_Seleciona_Click(object sender, EventArgs e)
        {
            var listaDisponivel = ListaCarteiraDispo.DataSource;

            var contar = ListaCarteiraDispo.Items.Count;

            for (int i = 0; i < contar; i++)
            {

                var item = ListaCarteiraDispo.Items[i];

                if (item != null)
                {
                    var itemCarteira = new CarteirasDTO() { Carteira = item.ToString(), Reservado = 1, Usuario = cmbOperador.SelectedItem.ToString() };
                    _icarteira.EditaCarteira(itemCarteira);

                    var itemPesquisado = ListaCarteira.Where(x => x.Contains(item.ToString())).FirstOrDefault();
                    if (String.IsNullOrEmpty(itemPesquisado))
                    {
                        ListaCarteira.Add(item.ToString());
                    }



                }

            }

            ListaCarteiraSel.DataSource = ListaCarteira;

            CarregaListaCarteiraDispo();

            chk_Seleciona.Checked = false;

        }

        //Click seleciona todas as carteiras
        private void chk_Deseleciona_CheckedChanged(object sender, EventArgs e)
        {
            ListaCarteiraSel.DataSource = null;
            ListaCarteira = new BindingList<String>();
            var operador = cmbOperador.SelectedItem;
            ApagaCarteiraSel(operador.ToString());

            CarregaListaCarteiraDispo();

            chk_Deseleciona.Checked = false;

        }



        private void cmbOperador_SelectionChangeCommitted(object sender, EventArgs e)
        {


            var operador = cmbOperador.SelectedItem;

            var operadorSelecionado = new ListaConfigContatoDTO();


            if (operador != null && operador.ToString().Trim().Length > 0)
            {
                HabilitaObjetos(true);

                operadorSelecionado = _iconfig.ListaConfContato().Where(x => x.Operador == operador.ToString()).FirstOrDefault();
            }
            else
            {
                HabilitaObjetos(false);
            }


            // se exitir dados carrega a tela
            if (operadorSelecionado != null)
            {
                Acao = "EDITAR";

                //Carregar as listas 
                var Cart = operadorSelecionado.Carteiras;
                txtDias.Text = operadorSelecionado.Dias_sem_Compras.ToString();
                ckb_Cancelados.Checked = Convert.ToBoolean(operadorSelecionado.Nao_cancelados);
                var prior = operadorSelecionado.Prioridades;

                ListaCarteiraSel.DataSource = JsonConvert.DeserializeObject<List<String>>(Cart);
                ListaPrioridadeSel.DataSource = JsonConvert.DeserializeObject<List<String>>(prior);
                ListaCarteira = new BindingList<String>(JsonConvert.DeserializeObject<List<String>>(Cart));
                ListaPrioridade = new BindingList<String>(JsonConvert.DeserializeObject<List<String>>(prior));
            }
            else
            {

                ApagaCarteiraSel(operador.ToString());


                ListaCarteira = new BindingList<String>();
                ListaPrioridade = new BindingList<String>();
                ListaCarteiraSel.DataSource = null;
                ListaPrioridadeSel.DataSource = null;
                HabilitaForm();
                Acao = "INSERIR";

        
            }

            CarregaListaCarteiraDispo();
        }

        private void ApagaCarteiraSel(String operador)
        {
            // verifica se por algum problema o usuario tem itens selecionados na tabela de carteiras
            var tabelaCarteiraUsuario = _icarteira.ListaCarteira().Where(x => x.Usuario == operador).ToList();

            if (tabelaCarteiraUsuario.Count > 0)// se tiver apaga
            {
                // zera carteira
                _icarteira.ApagaCarteiraPorUsuario(operador);
            }

        }

        private void ListaPrioridadeDispo_DoubleClick(object sender, EventArgs e)
        {
            var itemSelecionado = ListaPrioridadeDispo.SelectedItem.ToString();
            var itemPesquisado = ListaPrioridade.Where(x => x.Contains(itemSelecionado)).FirstOrDefault();
            if (String.IsNullOrEmpty(itemPesquisado))
            {
                ListaPrioridade.Add(itemSelecionado);
            }
            ListaPrioridadeSel.DataSource = ListaPrioridade;
        }

        private void ListaPrioridadeSel_DoubleClick(object sender, EventArgs e)
        {
            var itemaApagar = ListaPrioridadeSel.SelectedItem.ToString();
            //   var j = JsonConvert.SerializeObject(ListaPrioridadeDispo.DataSource);
            //    var lista = JsonConvert.DeserializeObject<List<String>>(j);

            BindingList<String> novalista = new BindingList<String>(ListaPrioridade.Where(x => x.Contains(itemaApagar) == false).ToList());

            ListaPrioridadeSel.DataSource = null;
            ListaPrioridadeSel.DataSource = novalista;

            ListaPrioridade = novalista;
        }
        /// <summary>
        /// Monta a lista do operador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (ListaCarteira.Count() == 0 || ListaPrioridade.Count == 0)
            {

                MsgBox.Show("Escolher carteira e prioridades", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                return;
            }
            if (cmbOperador.SelectedItem == null)
            {
                MsgBox.Show("Escolher um operador", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                return;
            }

            String carteiras = "";

            foreach (var carteira in ListaCarteira)
            {
                if (carteiras != "")
                { carteiras += " , "; }
                carteiras += "'" + carteira + "'";

            }

            // or  (date(data_agenda_contato) > date(now()) and AND operador_ult_contato='" + cmbOperador.SelectedItem.ToString() + "'

            var condicao = "WHERE canal_venda IN (" + carteiras + ") AND (date(data_agenda_contato) < date(now()))";

            if (ckb_Cancelados.Checked)
            {
                condicao += " AND  UPPER( Left(situacao,1))<>'C' ";
            }



            if (Information.IsNumeric(txtDias.Text))
            {
                if (Convert.ToInt32(txtDias.Text) > 0)
                {
                    condicao += " AND dias_sem_compra <= " + txtDias.Text;
                }
            }


            // condicao += " AND data_contato >= DATE_SUB(CURDATE(),INTERVAL " + txtDias.Text + " DAY) ";
            var ordem = "";
            foreach (var prioridade in ListaPrioridade)
            {
                if (ordem != "")
                { ordem += " , "; }


                if (prioridade == "ÚLTIMA COMPRA")
                {
                    ordem += " coalesce(dt_ult_compra,curdate())";
                }
                else if (prioridade == "ÚLTIMA LIGAÇÃO")
                {
                    ordem += "  coalesce(data_contato, curdate())";
                }
                else if (prioridade == "VALOR MAIOR COMPRA")
                {
                    ordem += " valor_maior_compra Desc";
                }
                else if (prioridade == "DIAS SEM COMPRAS")
                {
                    ordem += " dias_sem_compra Desc";
                }
            }

            var orderby = " Order By " + ordem;

            CarregaGrid(condicao + orderby);

            var listasSelecionadas = new ListaConfigContatoDTO();
            //Serializa Listas
            listasSelecionadas.Operador = cmbOperador.SelectedItem.ToString().Trim();
            listasSelecionadas.Carteiras = JsonConvert.SerializeObject(ListaCarteira);
            listasSelecionadas.Prioridades = JsonConvert.SerializeObject(ListaPrioridade);
            listasSelecionadas.Sequencia = JsonConvert.SerializeObject(Seq);
            listasSelecionadas.Nao_cancelados = ckb_Cancelados.Checked;
            listasSelecionadas.Dias_sem_Compras = Convert.ToInt32(txtDias.Text);

            if (Acao == "INSERIR")
            {
                _iconfig.InsereConfContato(listasSelecionadas);

            }
            else//Editar
            {

                _iconfig.AtualizaConfContato(listasSelecionadas);
            }
        }

        private void HabilitaObjetos(bool habilitar)
        {

            ListaCarteiraDispo.Enabled = habilitar;
            ListaCarteiraSel.Enabled = habilitar;
            ListaPrioridadeDispo.Enabled = habilitar;
            ListaPrioridadeSel.Enabled = habilitar;
            txtDias.Enabled = habilitar;
            btnAplicar.Enabled = habilitar;
            ckb_Cancelados.Enabled = habilitar;
            btnApagar.Enabled = habilitar;

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

            var rsp = MsgBox.Show("Apagar este filtro?", "Apagar", MsgBox.Buttons.YesNo);

            if (rsp == DialogResult.Yes)
            {
                _iconfig.ApagaConfContato(cmbOperador.SelectedItem.ToString());
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblNrReg_Click(object sender, EventArgs e)
        {

        }
    }


}
