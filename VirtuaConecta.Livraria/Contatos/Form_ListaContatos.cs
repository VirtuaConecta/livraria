using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtuaConecta.Outbound.Business;
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Parametros;
using VirtuaConecta.Outbound.Utility;
using xDialog;


namespace VirtuaConecta.Outbound.AI.Contatos
{
    public partial class Form_ListaContatos : MaterialForm
    {
        private Business.BaseBis.IcontatoBLL _icontato;
        private Business.BaseBis.IfiltroBLL _ifiltro;
        private Business.BaseBis.iconfBLL _iconfig;
        private String index_filtro = null;
        public Form_ListaContatos()
        {
            InitializeComponent();
            //  panel1.Anchor = (AnchorStyles.Left|AnchorStyles.Bottom|AnchorStyles.Right | AnchorStyles.Top);
            //    panel2.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
            splitContainer1.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top);
            splitContainer2.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top);

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Green100, Primary.Green400, Primary.Green500,
                Accent.LightGreen200, TextShade.WHITE);

            //Primary.DeepOrange300, Primary.Orange400, Primary.Orange200,
            //    Accent.Orange100, TextShade.WHITE);

            materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Arial", 12);
            materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Arial", 10);
            materialSkinManager.ROBOTO_REGULAR_11 = new Font("Arial", 11);
            materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Arial", 11);
            _icontato = Factory.CriarContatosBLL();
            _ifiltro = Factory.CriarFiltroBLL();
            _iconfig = Factory.CriaConfigListaBLL();

        }


        public void AtivaTick()
        {
            timerAlerta.Enabled = true;
        }


        public void CarregaGrid(String filtro)
        {
            var Listabase = new List<ContatosDTO>();
            var configUsuario = _iconfig.ListaConfContato().Where(x => x.Operador == VarGlobal.LoginName.ToLower()).FirstOrDefault();

            if (configUsuario != null)
            {
                cmbFiltro.Enabled = false;
                var itensConfigurados = JsonConvert.DeserializeObject<List<SequenciaDTO>>(configUsuario.Sequencia);
                var listacontato = _icontato.ListaContatos(null);

                var resultadoAcao = (listacontato.Join(
                                       itensConfigurados,
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
                        e.t2.Seq

                    })).ToList().OrderBy(x=>x.Seq);

                var j = JsonConvert.SerializeObject(resultadoAcao);
                Listabase = JsonConvert.DeserializeObject<List<ContatosDTO>>(j);
            }
            else
            {
                cmbFiltro.Enabled = true;
                Listabase = _icontato.ListaContatos(filtro);
            }

            var listaContatos = Listabase
                .Select(e => new
                {
                    e.Id,
                    e.Canal_venda,
                    e.Cnpj,
                    e.Id_cliente,
                    e.Cliente,
                    e.Estado,

                    e.Telefone,
                    e.Situacao,
                    e.Descricao_status,
                    e.Dias_sem_compra,
                    e.Dia_ult_compra,
                    e.Data_Agenda_contato,
                    e.Data_contato,

                    e.Email,
                    e.Endereco,
                    e.Bairro,
                    e.Cep,
                    e.Cidade,
                    e.Cod_municipio,
                    e.Em_atendimento,
                    e.EnderecoEntrega,
                    e.Nome_contato,
                    e.Status_contato,
                    e.Seq,
                    e.Mes_Maior_compra,
                    e.valorMaiorCompra

                })

                .Where(x => x.Em_atendimento == 0)

                .ToList();

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
            DgListaContatos.Columns[23].HeaderText = "Seq";

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
            DgListaContatos.Columns[23].Visible = false;
            DgListaContatos.Columns[24].Visible = false;

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

        private void Form_ListaContatos_Load(object sender, EventArgs e)
        {
            ckb_chamarAuto.Checked = false;

            //Libera contatos que ficaram retidos no bloqueio
            _icontato.BloqueiaContato(0, 0, VarGlobal.LoginName);
            AtivaTick();
            carregaComboFiltro();
            carregaComboTimer();
            String filtro = null;
            var itemSelecionado = (FiltrosDTO)cmbFiltro.SelectedItem;
            if (itemSelecionado != null)
            {
                filtro = itemSelecionado.Sql;
            }

            try
            {
                this.CarregaGrid(filtro);
            }
            catch (Exception ex)
            {

                MsgBox.Show("Erro ao carregar lista de contatos! ", "Falha", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }
            txtDias.Text = "90";
            VarGlobal.Indice = 0;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void carregaDetalheContato(ContatosDTO ln)
        {


            var contatoItem = new ContatosDTO();

            contatoItem = ln;
            contatoItem.Chamar = ckb_chamarAuto.Checked;





            FormDetalheContato formDt = new FormDetalheContato(this, contatoItem);
            formDt.Show();



        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            var dias = txtDias.Text;
            if (Information.IsNumeric(dias))
            {

                //Form a ser exibido durante o processamento
                var w = new Form_aviso();
                //Executando o form auxiliar em uma nova System.Threading.Thread
                var t = new Thread(w.ShowDiag);
                //Iniciando a Thread
                t.Start();

                //Aguardando até q a Thread seja iniciada
                while (!w.Started) { }

               
                var resp = _icontato.AtualizaListaContato(dias);
                try
                {
                    //Fechando form auxiliar
                    t.Abort();
                }
                catch (Exception)
                {
                    //
                }




                var resp1 = resp.Split('|');



                if (resp1[0] == "OK")
                {
                    MsgBox.Show("Lista local atualizada! \r\n  Registros: " + resp1[1], "Sucesso", MsgBox.Buttons.OK);
                }
                var itemSelecionado = (FiltrosDTO)cmbFiltro.SelectedItem;
                this.CarregaGrid(itemSelecionado.Sql);

            }





        }


        public void carregaComboFiltro()
        {
            try
            {
                var listaCombo = _ifiltro.ListaFiltros().OrderBy(x => x.Descricao).ToList();

                cmbFiltro.DataSource = listaCombo;
                cmbFiltro.DisplayMember = "Descricao";
                cmbFiltro.ValueMember = "Id";
                cmbFiltro.SelectedIndex = Parametros.Parametros.IndiceFiltro();
            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro ao carregar lista de filtro em Form_ListaContatos:(carregaComboFiltro()) " + ex.Message, MessageType.Error);
                MsgBox.Show("Erro ao carregar Lista de filtros! ", "Falha", MsgBox.Buttons.OK, MsgBox.Icon.Error);

            }
        }


        public void carregaComboTimer()
        {
            try
            {
                cmbTimer.Items.Add(new { Text = "1 segundo", Value = "1000" });
                cmbTimer.Items.Add(new { Text = "2 segundos", Value = "2000" });
                cmbTimer.Items.Add(new { Text = "3 segundos", Value = "3000" });
                cmbTimer.Items.Add(new { Text = "5 segundos", Value = "5000" });
                cmbTimer.Items.Add(new { Text = "10 segundos", Value = "10000" });
                cmbTimer.DisplayMember = "Text";
                cmbTimer.ValueMember = "Value";


                cmbTimer.SelectedIndex = 0;



            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro ao carregar lista de filtro em Form_ListaContatos:(carregaComboFiltro()) " + ex.Message, MessageType.Error);
                MsgBox.Show("Erro ao carregar Lista de filtros! ", "Falha", MsgBox.Buttons.OK, MsgBox.Icon.Error);

            }
        }




        private void cmbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            this.filtraLista();
        }

        public void rdInicia_CheckedChanged(object sender, EventArgs e)
        {
            ExecutaLista();
        }
        private void filtraLista()
        {
            var _sql = "";
            var itemSelecionado = (FiltrosDTO)cmbFiltro.SelectedItem;
            if (itemSelecionado != null)
            {
                _sql = itemSelecionado.Sql;
            }
            this.CarregaGrid(_sql);
        }
        private void DgListaContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var dataItemJson = JsonConvert.SerializeObject(DgListaContatos.CurrentRow.DataBoundItem);
            var item = JsonConvert.DeserializeObject<ContatosDTO>(dataItemJson);

            carregaDetalheContato(item);
        }


        public void ExecutaLista()
        {
            try
            {
                //Carrega a lista com os itens disponiveis e não contatados  hoje
                var filtroSelecionado = (FiltrosDTO)cmbFiltro.SelectedItem;
                // Independente do filtro selecionado será observado se a data do contato é null (como nao le null substitumos com o dia de ontem) ou o contato ja nõa foi feito hoje
                this.CarregaGrid(filtroSelecionado.Sql);




                for (int i = VarGlobal.Indice; i < DgListaContatos.RowCount; i++)
                {
                    DgListaContatos.Rows[i].Selected = true;
                    DataGridViewRow linha = DgListaContatos.Rows.SharedRow(i);



                    // var frm = Application.OpenForms["FormDetalheContato"];
                    var frmOpened = Application.OpenForms.OfType<FormDetalheContato>().Count() > 0;
                    if (rdInicia.Checked == true && !frmOpened)
                    {
                        var dataItemJson = JsonConvert.SerializeObject(linha.DataBoundItem);
                        var item = JsonConvert.DeserializeObject<ContatosDTO>(dataItemJson);
                        //      FormDetalheContato formDt = new FormDetalheContato(this, item);
                        //  carregaDetalheContato();
                        var pergunta = MsgBox.Show("Contatar:\r\n " + item.Cliente, "Auto-Contato", MsgBox.Buttons.YesNoCancel, MsgBox.Icon.Question);
                        if (pergunta == DialogResult.Yes)
                        {

                            carregaDetalheContato(item);



                            break;
                            //  this.Hide();
                        }
                        else if (pergunta == DialogResult.Cancel)
                        {
                            //formDt.Dispose();
                            rdInicia.Checked = false;
                            break;
                        }
                        else if (pergunta == DialogResult.No)
                        {
                            VarGlobal.Indice++;
                        }

                    }
                    else if (rdInicia.Checked == false)
                    {
                        break;
                    }


                    //FormDetalheContato formDtClose = new FormDetalheContato(this, null);
                    //formDtClose.Dispose();
                }
                // this.Show();
            }
            catch (Exception ex)
            {
                LogEvento.EscreverEvento("Erro ao executar lista automatica: " + ex.Message, MessageType.Error);
                MsgBox.Show("Houve um erro ao executar a lista automática");
            }
            //   rsPausa.Checked = true;

        }


        public void retornoDetalhes()
        {

            object obj = cmbTimer.SelectedItem;


            var _delay = Convert.ToInt32(Conversoes.GetValObjBy(obj, "Value"));
            var item = VarGlobal.Indice;
            VarGlobal.Indice++;
            //     var frm = Application.OpenForms["FormDetalheContato"];
            var frmOpened = Application.OpenForms.OfType<FormDetalheContato>().Count() > 0;
            if (!frmOpened)
            {
                Task.Delay(_delay).Wait();
                ExecutaLista();
                item = VarGlobal.Indice;

                //  Thread.Sleep(2000);
            }

            if (timerAlerta.Enabled == false)
            {
                AtivaTick();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCaixaPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregaGrid(" WHERE TRIM(cliente) LIKE '%" + txtCaixaPesquisa.Text.ToUpper() + "%'");
        }

        private void DgListaContatos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String novofiltro = null;
            var col = DgListaContatos.Columns[e.ColumnIndex];


            string hd = DgListaContatos.Columns[e.ColumnIndex].Name;

            if (hd == "Estado")
            {
                hd = "Uf";
            }
            else if (hd == "Descricao_status")
            {
                hd = "desc_st";
            }
            else if (hd == "Dia_ult_compra")
            {
                hd = "dt_ult_compra";
            }
            //else if (hd == "Nome_contador")
            //{
            //    hd = "contador";
            //}
            //else if (hd == "Status_envio")
            //{
            //    hd = "Status";
            //}

            var seleFil = (FiltrosDTO)cmbFiltro.SelectedItem;

            var str = seleFil.Sql;

            var pos = str.ToUpper().IndexOf("ORDER BY");

            var Ordering = "ASC";

            if (index_filtro != null)
            {
                var t = index_filtro.Split('|');

                if (t[0] == hd && t[1] == "ASC")
                {
                    Ordering = "DESC";
                }
                else if (t[0] == hd && t[1] == "DESC")
                {
                    Ordering = "ASC";
                }


            }

            if (pos > 0)
            {


                novofiltro = str.Substring(0, pos) + " Order by " + hd + " " + Ordering;



            }
            else
            {
                novofiltro = str + " Order by " + hd + " " + Ordering;
            }

            index_filtro = hd + "|" + Ordering;

            CarregaGrid(novofiltro);
        }

        private void timerAlerta_Tick(object sender, EventArgs e)
        {
            //busca se existe contato
            var lista = ListaAgendamento();
            foreach (var item in lista)
            {
                item.Chamar = ckb_chamarAuto.Checked;
                Form_agenda _form = new Form_agenda(this, item);
                _form.Show();
                timerAlerta.Enabled = false;

            }
            // se existir envia o dado para o form agenda

        }



        public List<ContatosDTO> ListaAgendamento()
        {
            var listaContatos = new List<ContatosDTO>();

            if (Parametros.Parametros.IntervaloAlerta() > 0) 
            {
                String filtro = " where isnull(data_agenda_contato)=false and left(situacao,1)<>'C'and Em_atendimento=0 and data_contato < data_agenda_contato and ";
                filtro += " ABS( TIMESTAMPDIFF(MINUTE,data_agenda_contato ,now()))<=" + Parametros.Parametros.IntervaloAlerta() + "  and operador_ult_contato='" + VarGlobal.LoginName.ToLower() + "'  order by data_agenda_contato";
                listaContatos = _icontato.ListaContatos(filtro).ToList();
            }

            return listaContatos;
        }



    }
}
