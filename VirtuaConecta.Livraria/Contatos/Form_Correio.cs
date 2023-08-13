using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;
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
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Utility;
using xDialog;

namespace VirtuaConecta.Outbound.AI.Contatos
{
    public partial class Form_Correio : MaterialForm
    {
        private Business.BaseBis.IcontatoBLL _icontato;
        private Business.BaseBis.IcorreioBLL _icorreio;
        private Business.BaseBis.IferiadosBLL _iferiado;
        private String cod_serv;
        public Form_Correio()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);

            _icontato = Factory.CriarContatosBLL();
            _icorreio = Factory.CriarCorreioBLL();
            _iferiado = Factory.CriaFeriadoBLL();
        }

        private void Form_Correio_Load(object sender, EventArgs e)
        {


            carregaComboCliente();
            carregaComboStatus();
            label5.Enabled = false;
            LblDataPrevista.Enabled = false;
            btnPesquisar.Enabled = false;
            LimparForm();
        }


        public void carregaComboCliente()
        {

            var listaCombo = _icontato.ListaEnvioCorreio();
            cmdClientes.DataSource = listaCombo;
            cmdClientes.DisplayMember = "Cliente";
            cmdClientes.ValueMember = "Id";
            cmdClientes.SelectedIndex = -1;
        }
        /// <summary>
        /// Pesquisa data possivel de entrega
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(LblCep.Text))
            {


                var cepini = "06816550";
                var cepfim = LblCep.Text;

                var prazo = _icorreio.CalculaPrazoRastreio(cod_serv, cepini, cepfim);

                if (!String.IsNullOrEmpty(prazo))
                {
                    var dado_prazo = prazo.Split(';');
                    var sabado = dado_prazo[2];
                    Int32 diasEntrega = Convert.ToInt32(dado_prazo[3]);

                    DateTime DtEntrega;
                    
                    //data de entrega sem considerar fins de samana e feriados
                    DtEntrega = Convert.ToDateTime(DtEnvio.Text).AddDays(diasEntrega);
                  
                    //Verifica por fins de semana e feriados
                    var dataRetorno = _icontato.DataProxContato(DtEntrega,lblCodMunicipio.Text);

                    //Caso seja feriado retorna uma mensagem
                    if (!String.IsNullOrEmpty(dataRetorno.Obs))
                    {
                        MsgBox.Show(dataRetorno.Obs, "Data especial", MsgBox.Buttons.OK, MsgBox.Icon.Info);

                    }

                    label5.Enabled = true;
                    LblDataPrevista.Enabled = true;

                   
                    LblDataPrevista.Text = dataRetorno.Data_retorno.ToString();



                }
                else
                {
                    MsgBox.Show("Não foi fornecido um prazo", "Erro", MsgBox.Buttons.OK);

                }

            }
            else
            {
                MsgBox.Show("É necessario um Cep para o Destino", "Erro", MsgBox.Buttons.OK);
            }

        }

        private void cmdClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var _selectItem = (Model.ContatosDTO)cmdClientes.SelectedItem;
            if (_selectItem != null)
            {

                if (Information.IsNumeric(_selectItem.Id))
                {
                    var itemselecionado = _icontato.ListaContatos(null).Where(x => x.Id == _selectItem.Id).FirstOrDefault();

                    LblEndereco.Text = itemselecionado.Endereco;
                    lblBairro.Text = itemselecionado.Bairro;
                    lblCidade.Text = itemselecionado.Cidade;
                    LblEstado.Text = itemselecionado.Estado;
                    LblCep.Text = itemselecionado.Cep;
                    if (itemselecionado.Cod_municipio != null)
                    {
                        lblCodMunicipio.Text = itemselecionado.Cod_municipio.ToString();
                    }
                }
            }
        }
     

        private void CombCodigo_SelectedValueChanged(object sender, EventArgs e)
        {
            var cods = (String)CombCodigo.SelectedItem;
            if (!String.IsNullOrEmpty(cods))
            {
                var cod = cods.Split('-');
                cod_serv = cod[0].Trim();

                btnPesquisar.Enabled = true;
            }
        }


        public void CarregarSite()
        {

            if (txtCod_rastreio.Text.Length==13 )
            {
                try
                {

                    #region modelo webBrowser 
                    //       webBrowser1.ScriptErrorsSuppressed = true;
                    //      webBrowser1.Navigate("http://www2.correios.com.br/sistemas/rastreamento/");

                    ////       webBrowser1.Navigate("https://www.google.com.br/");

                    //       while (webBrowser1.ReadyState != WebBrowserReadyState.Complete &&
                    //  webBrowser1.Document == null)
                    //       {
                    //           Application.DoEvents();
                    //       }



                    //       webBrowser1.Document.GetElementById("objetos").SetAttribute("value", txtCod_rastreio.Text);


                    //       webBrowser1.Document.GetElementById("btnPesq").InvokeMember("click");



                    //       while (webBrowser1.ReadyState != WebBrowserReadyState.Complete &&
                    //   webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                    //       {
                    //           Application.DoEvents();
                    //       }

                    #endregion


                    var retornoCorreio = _icorreio.RatreaEncomenda(txtCod_rastreio.Text.ToUpper());


                    if (retornoCorreio != null)
                    {

                        DataTable gridData = new DataTable();
                        gridData.Columns.Add("Descrição Rastreio");


                        //gridData.Rows.Add(retornoCorreio.numero);
                        //gridData.Rows.Add(retornoCorreio.nome);
                        //gridData.Rows.Add(retornoCorreio.sigla);
                        gridData.Rows.Add(retornoCorreio.categoria);

                        foreach (var item in retornoCorreio.evento)
                        {
                            var reg = "Código: "+item.codigo + " - Data: " + item.data + " " + item.hora + " - Evento: " + item.descricao + " - Cidade: " + item.cidade  ;


                            gridData.Rows.Add(reg);
                        }

                        BindingSource gridDataBinder = new BindingSource();
                        gridDataBinder.DataSource = gridData;

                        
                        
                        dgRatreio.DataSource = gridDataBinder;

                        dgRatreio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    else
                    {
                        MsgBox.Show("Objeto não Encontrado", "Resposta Correios", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                    }








                }
                catch (Exception ex)
                {
                    // MsgBox.Show("Sem conexão com o correio. Tente novamente", "Erro de conexão", MsgBox.Buttons.OK);
                    // throw;
                }
            }

        }

        public void carregaComboStatus()
        {
            var listaCombo = _icontato.ListaStatusContatos().Where(x=>x.Descricao.ToUpper().Contains("ENVIO")).ToList();
            cmdStatus.DataSource = listaCombo;
            cmdStatus.DisplayMember = "Descricao";
            cmdStatus.ValueMember = "Id";
            cmdStatus.SelectedIndex = -1;
        }
        private void btnRatreio_Click(object sender, EventArgs e)
        {

            //colocar aqui a chamada da api docorreio

  
           this.CarregarSite();
        }

        private void button1_Click(object sender, EventArgs e)
        {//FAzer a validação dos campos
            if (validaForm()=="OK")
            {

                var _selectItem = (Model.ContatosDTO)cmdClientes.SelectedItem;
                var _selectStatus = (Model.StatusContatoDTO)cmdStatus.SelectedItem;
                HistoricoDTO historico = new HistoricoDTO();
                String Hist = txtObs1.Text.Trim() + " ";
                Hist += txtObs2.Text.Trim() + " ";
                Hist += txtObs3.Text.Trim() + " ";
                Hist += txtObs4.Text.Trim() + " ";
                Hist += txtObs5.Text.Trim() + " ";
                Hist += txtObs6.Text.Trim() + " ";
                historico.Historico_Desc = "Rastreio: " + txtCod_rastreio.Text + " - " + Hist.Trim();
                historico.Dt_retorno = Convert.ToDateTime(LblDataPrevista.Text);
                historico.Dt_contato = DateTime.Now;
                historico.Id_contato = _selectItem.Id;
                historico.Id = Guid.NewGuid().ToString();
                historico.Operador = VarGlobal.LoginName;
                historico.Status_contato = _selectStatus.Id;

                var resp = _icontato.InsereHistorico(historico);

                if (resp == "OK")
                {
                    this.LimparForm();
                    MsgBox.Show("Histrico atualizado", "Sucesso", MsgBox.Buttons.OK, MsgBox.Icon.Exclamation);

                }
                else
                {
                    MsgBox.Show("Erro ao inserir historico", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                } 
            }

            else
            {
                MsgBox.Show(validaForm(), "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }
        }

        private void LimparForm()
        {
            txtCod_rastreio.Text = null;
            txtObs1.Text = null;
            txtObs2.Text = null;
            txtObs3.Text = null;
            txtObs4.Text = null;
            txtObs5.Text = null;
            txtObs6.Text = null;
            lblBairro.Text = null;
            LblCep.Text = null;
            lblCidade.Text = null;
            LblDataPrevista.Text = null;
            LblEndereco.Text = null;
            LblEstado.Text = null;
            cmdClientes.SelectedIndex = -1;
            cmdStatus.SelectedIndex = -1;
            lblCodMunicipio.Text = null;



        }

        private String validaForm()
        {
            String Retorno = "OK";

            if (txtCod_rastreio.TextLength <13)
            {
                Retorno = "Cod de rastreio no formato errado";
                txtCod_rastreio.Focus();
            }
            else if (cmdClientes.SelectedIndex ==-1)
            {
                Retorno = "Selecionar um cliente";
                cmdClientes.Focus();
            }
            else if (cmdStatus.SelectedIndex == -1)
            {
                Retorno = "Selecionar um Status";
                cmdStatus.Focus();
            }
            else if (LblCep.Text=="Cep")
            {
                Retorno = "Cliente sem Cep";
                LblCep.Focus();
            }
            else if (String.IsNullOrEmpty(txtObs1.Text))
            {
                Retorno = "Inserir uma observação";
                txtObs1.Focus();
            }
            else if (lblCodMunicipio.Text == "CodMun")
            {
                Retorno = "Cliente sem código de municipio";
                lblCodMunicipio.Focus();
            }
            return Retorno;
        }

        
    }
}
