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
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Parametros;
using MaterialSkin;
using MaterialSkin.Controls;
using VirtuaConecta.Outbound.Business;
using xDialog;
using VirtuaConecta.Outbound.Utility;
using AutoIt;
using Microsoft.VisualBasic;
using System.Globalization;

namespace VirtuaConecta.Outbound.AI.Contatos
{
    public partial class FormDetalheContato : MaterialForm
    {
        string specifier;
        CultureInfo culture;

        private ContatosDTO _contatoItem;
        private Business.BaseBis.IcontatoBLL _contato;
        private Business.BaseBis.IreceitaWsBLL _receita;
        private Business.BaseBis.IcorreioBLL _correio;
        private Form_ListaContatos _formIn;
        public FormDetalheContato(Form_ListaContatos form, ContatosDTO contatoItem)
        {
            InitializeComponent();
            _contato = Factory.CriarContatosBLL();
            _formIn = form;
            _receita = Factory.CriarReceitaBLL();
            _correio = Factory.CriarCorreioBLL();
            //     this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDetalheContato_FormClosing);

            var contatoLocal = _contato.ListaContatos($" where id_cliente ='{contatoItem.Id_cliente}'").FirstOrDefault();
            if (contatoLocal != null)
            {
                _contatoItem = contatoLocal;
            }
            else
            {
                _contatoItem = contatoItem;
            }
      

            specifier = "N";
            culture = CultureInfo.CreateSpecificCulture("es-ES");
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Green400, Primary.Cyan900, Primary.Cyan700,
                Accent.Cyan400, TextShade.WHITE);
   
            materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Arial", 12);
            materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Arial", 10);
            materialSkinManager.ROBOTO_REGULAR_11 = new Font("Arial", 11);
            materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Arial", 11);
        }

        private void FormDetalheContato_Load(object sender, EventArgs e)
        {
            //captura as informaçoes financeiras atualizadas
            _contato.AtualizaInfoFinanceira(_contatoItem.Id_cliente);

            // Bloqueia o Contato
            _contato.BloqueiaContato(_contatoItem.Id,1,null);

            var sit = _contatoItem.Situacao;
            // labelTitulo.Parent = pictureBox1;
            labelTitulo.BackColor = Color.Transparent;
            if (!String.IsNullOrWhiteSpace(_contatoItem.Situacao))
            {
                if (_contatoItem.Situacao.Substring(0,1).ToUpper()=="A")
                {
                    sit = "Ativo";
                }
                else if (_contatoItem.Situacao.Substring(0, 1).ToUpper() == "P")
                {
                    sit = "Pendente";
                }
                else if (_contatoItem.Situacao.Substring(0, 1).ToUpper() == "C")
                {
                    sit = "Cancelado";
                }
            }
            cmbSituacao.SelectedItem = sit;

            CarregarItemContato();
            carregaComboStatus();
            CarregarSite();
            lblConcluiu.Visible = false;
            lblDiscando.Visible = false;
            DtpDataRetorno.CustomFormat = " ";




            if (_contatoItem.Chamar)
            {
                ChamadaTelefonica();
            }
      
        }

        private void CarregarItemContato()
        {
            mtxtCodCliente.Text = _contatoItem.Id_cliente.ToString();

            mtxtNomeCliente.Text = _contatoItem.Cliente;
            mtxtCodCliente.Text = _contatoItem.Id_cliente;
            mtxtTelefone.Text = Mask.Telefone(_contatoItem.Telefone);
            mtxtEmail.Text = _contatoItem.Email;
            txtContato.Text = _contatoItem.Nome_contato;
            mtxtCnpj.Text = _contatoItem.Cnpj;
            mtxtIdHistorico.Text = Guid.NewGuid().ToString();
            DtpHoraRetorno.Value = DateTime.Now;
            mtxtCidade.Text = _contatoItem.Cidade;
            if (String.IsNullOrWhiteSpace(_contatoItem.Canal_venda))
            {
                cmbCanalDeVenda.SelectedIndex= -1;
            }
            else
            {
                if (!("ATIVA ATIVA2").Contains(_contatoItem.Canal_venda))
                {
                    cmbCanalDeVenda.Items.Add(_contatoItem.Canal_venda);
                }
         


                cmbCanalDeVenda.SelectedItem = _contatoItem.Canal_venda;
            }
           
            cmbSituacao.DisplayMember = _contatoItem.Situacao;
            cmdStatus.SelectedValue = _contatoItem.Status_contato;
            mtxtEndereco.Text = _contatoItem.Endereco;

            if (String.IsNullOrWhiteSpace(_contatoItem.EnderecoEntrega))
            {
                txtEndereco2.Text = "O MESMO";
            }
            else
            {
                txtEndereco2.Text = _contatoItem.EnderecoEntrega;
            }
           
            mtxtBairro.Text = _contatoItem.Bairro;
            mtxtCep.Text = _contatoItem.Cep;
            mtxtEstado.Text = _contatoItem.Estado;
            txtDtUltcontato.Text = Convert.ToDateTime(_contatoItem.Data_contato).ToString("yyyy-MM-dd");


            if (_contatoItem.Cod_municipio==null)
            {
                mtxtCod_municipio.Text = _contatoItem.Cod_municipio.ToString();
            }
         

            if (_contatoItem.Cod_municipio != null)
            {
                mtxtCod_municipio.Text = _contatoItem.Cod_municipio.ToString();
            }

            if (_contatoItem.Mes_Maior_compra != null)
            { mtxtMesMaiorCompra.Text = Convert.ToDateTime(_contatoItem.Mes_Maior_compra).ToString("MM"); }
            else
            {
                mtxtMesMaiorCompra.Text = null;
            }
            if (_contatoItem.Dia_ult_compra != null)
            {
                mtxtDtUlCompra.Text = Convert.ToDateTime(_contatoItem.Dia_ult_compra).ToString("yyyy-MM-dd");
            }
            else
            {
                mtxtDtUlCompra.Text = null;
            }

            if (!String.IsNullOrWhiteSpace(mtxtVAlorMaiorCompra.Text))
            {
                mtxtVAlorMaiorCompra.Text = _contatoItem.valorMaiorCompra.ToString(specifier, culture);
            }
            else
            {
                mtxtVAlorMaiorCompra.Text = "0,00";
            }

            var d = _contatoItem.Dias_sem_compra.ToString();

            mtxtDiasSemCompras.Text = d; 
        }

        private ContatosDTO CapturaTelaContato()
        {
            var contato = new ContatosDTO();
            contato.Id = _contatoItem.Id;
            contato.Id_cliente = mtxtCodCliente.Text;
            contato.Canal_venda = cmbCanalDeVenda.SelectedItem.ToString();
            contato.Cnpj = mtxtCnpj.Text;
            contato.Email = mtxtEmail.Text;
            contato.Cidade = mtxtCidade.Text;
            contato.Situacao = cmbSituacao.SelectedItem.ToString();
            contato.Cliente = mtxtNomeCliente.Text;
            contato.Telefone = Mask.TiraSeparacaoTelefone(mtxtTelefone.Text);
            contato.Endereco = mtxtEndereco.Text.Trim();
            contato.Bairro = mtxtBairro.Text.Trim();
            contato.Estado = mtxtEstado.Text.Trim();
            contato.Cep = mtxtCep.Text.Trim();
            contato.Nome_contato = txtContato.Text.Trim().ToUpper();
            contato.EnderecoEntrega = txtEndereco2.Text.Trim().ToUpper();
            if (Information.IsNumeric(mtxtCod_municipio.Text))
            {
                contato.Cod_municipio = Convert.ToInt32(mtxtCod_municipio.Text);
            }




            return contato;
        }

            public void CarregarSite()
        {

            var Url = Parametros.Parametros.UrlPlugin();

            try
            {
                webBrowser1.Navigate(Url);

                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }

                var user = VarGlobal.LoginName;
                var senha = VarGlobal.Password;

                if (!String.IsNullOrEmpty(user) && !String.IsNullOrWhiteSpace(senha))
                {
                    webBrowser1.Document.GetElementById("cod_usuario").SetAttribute("value", user);

                    webBrowser1.Document.GetElementById("senha_usuario").SetAttribute("value", senha);
                    webBrowser1.Document.GetElementById("sub1").InvokeMember("click");

                    webBrowser1.Navigate(Url + "prog/pedido_web/dados_cliente/pgw0045/pgw0045.php?vazio=0&cliente=" + _contatoItem.Id_cliente);

                    while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                    {
                        Application.DoEvents();
                    } 
                }
                else
                {
                    MsgBox.Show("Falta um nome de Login ou senha", "Erro de web pugin", MsgBox.Buttons.OK);
                }
            }
            catch (Exception)
            {
                MsgBox.Show("Sem conexão com o plugin", "Erro de conexão", MsgBox.Buttons.OK);
                // throw;
            }

        }

        private void FormDetalheContato_FormClosing(object sender, FormClosingEventArgs e)
        {
           _contato.BloqueiaContato(_contatoItem.Id, 0,null);

            //e.Cancel = false;
            //    this.Close();
            //  VarGlobal.Indice++;
            //  _formIn.ExecutaLista();
            //   this.Close();
        }

        public void carregaComboStatus()
        {
            var listaCombo = _contato.ListaStatusContatos().OrderBy(x=>x.Descricao).ToList();
            cmdStatus.DataSource = listaCombo;
            cmdStatus.DisplayMember = "Descricao";
            cmdStatus.ValueMember = "Id";
            cmdStatus.SelectedValue = _contatoItem.Status_contato;
        }

        public void ChamadaTelefonica()
        {
            try
            {
                var tel =Parametros.Parametros.PrefixoTel() + Convert.ToUInt64(_contatoItem.Telefone.Trim()).ToString();


                lblConcluiu.Visible = false;
                lblDiscando.Visible = true;
                AutoItX.Run(@"C:\Program Files (x86)\Panasonic\Communication Assistant\CommunicationAssistant.exe", @"C:\Program Files (x86)\Panasonic\Communication Assistant");
                AutoItX.WinWaitActive("Communication Assistant Basic-Express");
                AutoItX.ControlSend("Communication Assistant Basic-Express", "", "[NAME:cbDialBox]", tel);
                AutoItX.ControlClick("", "", "[NAME:btnOffHook1]");
          //      AutoItX.ControlClick("", "", "[NAME:btnOffHook1]");
                lblConcluiu.Visible = true;
                lblDiscando.Visible = false;
            }
            catch (Exception ex)
            {
                MsgBox.Show("Erro ao discar!", "Erro", MsgBox.Buttons.OK);
                LogEvento.EscreverEvento("Erro ao discar: " + ex, MessageType.Error);
            }
        }

        private void btnAtualizarContato_Click(object sender, EventArgs e)
        {
            // Validações dos dados de envio
            HistoricoDTO historico = new HistoricoDTO();

            var retornoVAlid = ValidaCamposHistorico();
            if (retornoVAlid=="OK")
            {

                historico.Operador = VarGlobal.LoginName.ToLower();
                historico.Status_contato = Convert.ToInt32(cmdStatus.SelectedValue);
                historico.Historico_Desc = txtHistorico.Text;
                historico.Dt_retorno = DtpDataRetorno.Value.Date + DtpHoraRetorno.Value.TimeOfDay;
                historico.Dt_contato = DateTime.Now;
                historico.Id = mtxtIdHistorico.Text;
                historico.Id_contato = _contatoItem.Id;

                //Editar cliente

                var contatoEditar = CapturaTelaContato();
                contatoEditar.Data_contato = DateTime.Now;
                contatoEditar.Data_Agenda_contato = historico.Dt_retorno;
                contatoEditar.Status_contato = historico.Status_contato;
                //if (Information.IsNumeric(mtxtCod_municipio.Text))
                //{
                //    contatoEditar.Cod_municipio = Convert.ToInt32(mtxtCod_municipio.Text);
                //}

                //Atualizar Cadastro
                var retornoEditar = _contato.AtualizaContato(contatoEditar);
                try
                {

                    if (retornoEditar == "OK")
                    {
                        var id = historico.Id_contato;
                        var id_cliente = contatoEditar.Id_cliente;

                        if (id == 0 && !String.IsNullOrWhiteSpace(id_cliente))
                        {
                            //trata-se de um contato novo
                            var idrecuperado = _contato.ListaContatos("WHERE id_cliente ='" + id_cliente + "'").FirstOrDefault();


                            if (idrecuperado !=null)
                            {
                                historico.Id_contato = idrecuperado.Id;
                                _contatoItem.Id = idrecuperado.Id;
                            }
                            else
                            {
                                MsgBox.Show("Id do contato não foi encontrado!", "Falha ao inserir Contato", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                                return;
                            }
                        }
                        //Inserir no historico
                        var resp = _contato.InsereHistorico(historico);



                        if (resp == "OK")
                        {
                            MsgBox.Show("Historico inserido!", "Sucesso", MsgBox.Buttons.OK, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);

                            this.Close();
                        }
                        else
                        {
                            MsgBox.Show("Algum erro ocorreu ao gravar o historico.", "Erro ao inserir historico", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                            return;
                        }
                    }
                    else
                    {
                        MsgBox.Show("Algum erro ocorreu ao Atualizar Contato.", "Erro ao Atualizar", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                        return;

                    }
                }
                catch (Exception ex)
                {
                    LogEvento.EscreverEvento("Erro ao Inserir contato: " + ex.Message,MessageType.Error);
                    MsgBox.Show("Erro ao Inserir contato: "+ ex.Message, "Falha ao inserir Contato", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                }
            }
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            ChamadaTelefonica();
        }

        private void btnConsultaReceita_Click(object sender, EventArgs e)
        {



            ////Form a ser exibido durante o processamento
            //var w = new Form_aviso();
            ////Executando o form auxiliar em uma nova System.Threading.Thread
            //var t = new Thread(w.ShowDiag);
            ////Iniciando a Thread
            //t.Start();

            ////Aguardando até q a Thread seja iniciada
            //while (!w.Started) { }


            //CarregaCnpjReceita();

            //try
            //{
            //    //Fechando form auxiliar
            //    t.Abort();
            //}
            //catch (Exception)
            //{
            //    //
            //}


            CarregaCnpjReceita();







        }

        private void CarregaCnpjReceita()
        {


            var cnpj = mtxtCnpj.Text.Replace(".", "").Replace("/", "").Replace("-", "").Trim();

            try
            {
                if (!String.IsNullOrEmpty(cnpj) && cnpj.Length >= 14)
                {
                    var cnpj1 = cnpj.Substring(cnpj.Length - 14);

                    var dados = _receita.BuscaInfoReceita(cnpj1);


                    if (dados.nome != null)
                    {
                       
                        MsgBox.Show("Dados para Cliente: " + dados.nome + "\r\n Serão atualizados", "Sucesso", MsgBox.Buttons.OK);
                        mtxtEndereco.Text = dados.logradouro + "," + dados.numero + " " + dados.complemento;
                        mtxtEstado.Text = dados.uf;
                        mtxtCep.Text = dados.cep.Replace(".", "").Replace("-", "");
                        mtxtBairro.Text = dados.bairro;
                        mtxtCidade.Text = dados.municipio;
                        if (mtxtCep.Text.Length == 8)
                        {
                            var dadosIbge = _correio.PesquisaCep(mtxtCep.Text);
                            if (dadosIbge != null)
                            {
                                mtxtCod_municipio.Text = dadosIbge.ibge.ToString();
                            }
                        }



                    }
                    else
                    {
                        MsgBox.Show("O Cnpj não foi encontrado", "Falha", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                        //LogEvento.EscreverEvento("O Cnpj não foi encontrado! " , MessageType.Error);
                    }


                }
                else
                {
                    MsgBox.Show("Cnpj nâo pode ser Pesquisado", "Falha", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
                }

            }
            catch (Exception ex)
            {
                LogEvento.EscreverEvento("Erro ao consultar receita federal: " + ex.Message, MessageType.Error);

                MsgBox.Show("Erro: " + ex.Message, "Erro ao pesquisar Cnpj", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }



        }

        private String ValidaCamposHistorico()
        {
           String retorno = "OK";

            if (DtpDataRetorno.Text.ToString().Trim() == "")
            {
                MsgBox.Show("Não foi escolhido uma data para o retorno.", "Erro ao inserir historico", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                DtpDataRetorno.Focus();
                retorno = "Erro";
            }


            if (String.IsNullOrWhiteSpace(VarGlobal.LoginName))
            {
                // devolve para a tela de login
                MsgBox.Show("Não existe usuário Logado. Retornando ao Login", "Erro ao inserir historico", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                Form_login form = new Form_login();
                form.Show();
                this.Close();
            }


            if (cmdStatus.SelectedValue == null)
            {
                // devolve para a seleção
                MsgBox.Show("Não foi escolhido um status para o contato.", "Erro ao inserir historico", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                cmdStatus.Focus();
                retorno = "Erro";
            }

            if (String.IsNullOrEmpty(txtHistorico.Text))
            {
                //Devolve para o campo de historico
                MsgBox.Show("Alguma informação deve ser escrita no historico.", "Erro ao inserir historico", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                txtHistorico.Focus();
                retorno = "Erro";
            }


            if (!Information.IsNumeric(mtxtCod_municipio.Text) || mtxtCod_municipio.Text=="0")
            {
                //Devolve para o campo de historico
                MsgBox.Show("É necessário preencher o Cod de municipio.", "Erro ao inserir historico", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                mtxtCod_municipio.Focus();
                retorno = "Erro";
            }
            if (cmbCanalDeVenda.SelectedItem ==null)
            {
                //Devolve para o campo de historico
                MsgBox.Show("Escolher um Canal de venda.", "Erro ao inserir historico", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                cmbCanalDeVenda.Focus();
                retorno = "Erro";
            }

            return retorno;

        }

        private void DtpDataRetorno_ValueChanged(object sender, EventArgs e)
        {
            DtpDataRetorno.CustomFormat = "yyyy-MM-dd";

            var dt = DtpDataRetorno.Value;

            //validar a data
            if (!Information.IsNumeric(mtxtCod_municipio.Text))
            {
                //Devolve para o campo de historico
                MsgBox.Show("É necessário preencher o Cod de municipio.", "Erro ao definir data de entrega", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                mtxtCod_municipio.Focus();
                return;
            }
            else
            {



                var dt_final = _contato.DataProxContato(dt, mtxtCod_municipio.Text);
                DtpDataRetorno.Value = dt_final.Data_retorno;

                if (!String.IsNullOrEmpty(dt_final.Obs))
                {
                    MsgBox.Show(dt_final.Obs, "Data especial", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                }


            }
        }

        private void btnListaHistorico_Click(object sender, EventArgs e)
        {
            Form_historicoContato _form = new Form_historicoContato(_contatoItem);

            _form.Show();
        }

        private void FormDetalheContato_FormClosed(object sender, FormClosedEventArgs e)
        {
            _contato.BloqueiaContato(_contatoItem.Id, 0,null);
            this.Dispose();
            //  _formIn.Show();
            if (_formIn != null)
            {
                _formIn.retornoDetalhes();
            }
        
        }

        private void btnDadosCliente_Click(object sender, EventArgs e)
        {
            CarregarSite();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            // Bloqueia o Contato
            _contato.BloqueiaContato(_contatoItem.Id, 0,null);
            this.Close();
        }

        private void txtEndereco2_TextChanged(object sender, EventArgs e)
        {
          //  txtEndereco2.Text = txtEndereco2.Text.ToUpper();
        }

        private void cmdStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtxtCidade_Click(object sender, EventArgs e)
        {

        }
    }
}
