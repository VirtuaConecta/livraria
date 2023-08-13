using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;
using mshtml;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Business;
using VirtuaConecta.Outbound.Business.BaseBis;
using VirtuaConecta.Outbound.Utility;
using xDialog;

namespace VirtuaConecta.Outbound.AI.Clientes
{
    public partial class Form_CadastroCliente : MaterialForm
    {
        private IclienteBLL _cliente;
        private IcorreioBLL _correio;
        ToolTip toolTip1 = new ToolTip();
        public Form_CadastroCliente()
        {
            InitializeComponent();
            _cliente = Factory.CriaClienteBLL();
            _correio = Factory.CriarCorreioBLL();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);


            this.Font = new Font("Arial", 11);

            dgCliente = dg.GetDgStyle(dgCliente, 10, 9);


       
        }
        public ClienteDTO cliente = new ClienteDTO();
        private void Form_CadastroCliente_Load(object sender, EventArgs e)
        {
            getStyle();
            btnHistorico.Enabled = false;
            carregaGrid(null);
        }

       

        private void dgCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataItemJson = JsonConvert.SerializeObject(dgCliente.CurrentRow.DataBoundItem);
            var item = JsonConvert.DeserializeObject<ClienteDTO>(dataItemJson);

            txtNome.Text = item.Nome;
            txtCPF.Text = item.Cpf_cnpj;
            txtBairro.Text = item.Bairro;
            txtCidade.Text = item.Cidade;
            txtNum.Text = item.Num;
            txtTelefone.Text = item.Telefone;
            txtEmail.Text = item.Email;
            txtContri.Text = item.Contri.ToString();
            txtEnd.Text= item.End;
            txtData.Text = item.Data;
            btnHistorico.Enabled = true;
      
            cliente.Nome = item.Nome;
            cliente.id = item.id;
            txtUf.Text = item.Uf;
            txtCep.Text = item.Cep;

        }

        private String Verifica()
        {
            string verifica = "OK";

            if (String.IsNullOrWhiteSpace(txtNome.Text) && txtNome.Text.Length<5)
            {
                verifica = "Preencha o nome completdo do cliente";
            }
            else if ( String.IsNullOrWhiteSpace(txtCPF.Text)&&!int.TryParse(txtCPF.Text,out int aux)) 
            {
                verifica = "Preencha o CPF somente com  números";

            }
            else if (String.IsNullOrWhiteSpace(txtCPF.Text))
            {
                verifica = "O CPF/Cnpj deve ser preenchido)";

            }
            else if (String.IsNullOrWhiteSpace(txtBairro.Text))
            {
                verifica = "Preencha o bairro do cliente";
            }
            else if (String.IsNullOrWhiteSpace(txtEnd.Text))
            {
                verifica = "Preencha o endereço do cliente";
            }
            else if (String.IsNullOrWhiteSpace(txtNum.Text))
            {
                verifica = "Preencha o Nº do Endereço";
            }
            else if (String.IsNullOrWhiteSpace(txtCidade.Text))
            {
                verifica = "Preencha a cidade do cliente";
            }
            else if (!String.IsNullOrWhiteSpace(txtTelefone.Text) && txtTelefone.Text.Length!=11)
            {
                verifica = "O telefone deve conter 11 algarismos (DDD na frente)";
            }
            else if (!String.IsNullOrWhiteSpace(txtTelefone.Text) && Information.IsNumeric(txtTelefone.Text) ==false)
            {
                verifica = "Preencha o telefone somente com números";
            }
            else if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                verifica = "Preencha o e-mail do cliente";
            }
            else if (!decimal.TryParse(txtContri.Text, out decimal auxdec))
            {
                verifica = "Preencha a contribuição somente com números";
            }
            else if (!int.TryParse(txtData.Text, out aux))
            {
                verifica = "Preencha a data somente com números";
            }
            else if (String.IsNullOrWhiteSpace(txtUf.Text))
            {
                verifica = "Preencha o estado";
            }

            else if (String.IsNullOrEmpty(txtCep.Text))
            {
                verifica = "Preencha o cep";
            }
            else
            {
                var limpaCep = Conversoes.LimpaFormato(txtCep.Text);

                if (!Information.IsNumeric(limpaCep) || limpaCep.Length != 8)
                {
                    verifica = "Cep está com o formato incorreto";
                }

                var limpaCpfCnpj = Conversoes.LimpaFormato(txtCPF.Text);
                if (Information.IsNumeric(limpaCpfCnpj))
                {

                    if (limpaCpfCnpj.Length != 11 && limpaCpfCnpj.Length != 14)
                    {
                        verifica = "Cpf ou Cnpj está com o formato incorreto";
                    } 
                }
                else
                {
                    verifica = "Cpf ou Cnpj Deve conter apenas números";
                }
            }

            return verifica;
        }

        private void Limpar()
        {
            txtNome.Text = null;
            txtCPF.Text = null;
            txtBairro.Text = null;
            txtCidade.Text = null;
            txtNum.Text = null;
            txtTelefone.Text = null;
            txtEmail.Text = null;
            txtContri.Text = null;
            txtData.Text = null;
            txtEnd.Text = null;
            btnHistorico.Enabled = false;
            txtCep.Text = null;
            txtUf.Text = null;
            cliente = new ClienteDTO();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            confirma();
        }

       private void confirma()
        {
            var resp = Verifica();
            if (resp == "OK")
            {
                cliente.Bairro = txtBairro.Text.ToUpper().Trim();
                cliente.Cidade = txtCidade.Text.ToUpper().Trim();
                cliente.Contri = Convert.ToDecimal(txtContri.Text);
                cliente.Cpf_cnpj = Conversoes.LimpaFormato(txtCPF.Text);
                cliente.Data = txtData.Text;
                cliente.Email = txtEmail.Text;
                cliente.End = txtEnd.Text.ToUpper().Trim();
                cliente.Nome = txtNome.Text.ToUpper().Trim();
                cliente.Num = txtNum.Text;
                cliente.Telefone = Conversoes.LimpaFormato(txtTelefone.Text);
                cliente.Cep = Conversoes.LimpaFormato(txtCep.Text);
                cliente.Uf = txtUf.Text.ToUpper().Trim();

                if (cliente.Cpf_cnpj.Length==11)
                {
                    cliente.Fis_jur = "F";
                }
                else if (cliente.Cpf_cnpj.Length == 14)
                {
                    cliente.Fis_jur = "J";
                }

                if (cliente.id != 0)
                {

                    if (_cliente.ClienteEditar(cliente) == "OK")
                    {
                        carregaGrid(null);
                        Limpar();
               
                        MsgBox.Show("Edição feita com sucesso", "Editar Cliente", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                    }
                    else
                      
                    MsgBox.Show("Erro na edição ", "Editar Cliente", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                }
                else
                {
                    if (_cliente.ClienteInserir(cliente) == "OK")
                    {
                        carregaGrid(null);
                        Limpar();
                        MsgBox.Show("Inserido  com sucesso","Inserir Cliente",MsgBox.Buttons.OK,MsgBox.Icon.Info);
                    }
                    else
                        MsgBox.Show("Erro ao inserir ", "Inserir Cliente", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                }
            }
            else
            {

                MsgBox.Show($"Erro ao inserir \r\n {resp}", "Inserir Cliente", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }
        }
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnConfirmar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(sender as Control, "Confirmar operação");
        }

        private void btnLimpa_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(sender as Control, "Limpar Formulário");
        }

        private void Form_CadastroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                confirma();
            }
            else if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void txtPesquisarCliente_TextChanged(object sender, EventArgs e)
        {
            this.carregaGrid(txtPesquisarCliente.Text);
        }

        private void carregaGrid(string text)
        {
            dgCliente.Rows.Clear();

            var clientes = new List<ClienteDTO>();

            if (!String.IsNullOrEmpty(text))
            {
                clientes= _cliente.ClienteListar().Where(x=>x.Nome.ToUpper().Contains(text.ToUpper())).ToList();
            }
            else
            {
                clientes= _cliente.ClienteListar();
            }


            var Source = new BindingSource(clientes, null);
            dgCliente.DataSource = Source;
            dgCliente.Columns[0].Visible = false;
            dgCliente.Columns[3].Visible = false;
            dgCliente.Columns[4].Visible = false;
            dgCliente.Columns[12].Visible = false;
            dgCliente.Columns[13].Visible = false;
            dgCliente.AutoResizeColumns();
        }

        private void getStyle()
        {
            lblNome.ForeColor = Color.Teal;
            lblBairro.ForeColor = Color.Teal;
            lblCidade.ForeColor = Color.Teal;
            lblContri.ForeColor = Color.Teal;
            lblCPF.ForeColor = Color.Teal;
            lblData.ForeColor = Color.Teal;
            lblEmail.ForeColor = Color.Teal;
            lblEnd.ForeColor = Color.Teal;
            lblNum.ForeColor = Color.Teal;
            lblTelefone.ForeColor = Color.Teal;
            lblCep.ForeColor = Color.Teal;
            lblUf.ForeColor = Color.Teal;

            txtNome.Font = new Font("Arial", 11);
            txtNum.Font = new Font("Arial", 11);
            txtEnd.Font = new Font("Arial", 11);
            txtPesquisarCliente.Font = new Font("Arial", 11);
            txtTelefone.Font = new Font("Arial", 11);
            txtBairro.Font = new Font("Arial", 11);
            txtCidade.Font = new Font("Arial", 11);
            txtContri.Font = new Font("Arial", 11);
            txtCPF.Font = new Font("Arial", 11);
            txtData.Font = new Font("Arial", 11);
            txtEmail.Font = new Font("Arial", 11);
            txtUf.Font = new Font("Arial", 11);
            txtCep.Font = new Font("Arial", 11);

        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            Form_ClienteHistorico abrir = new Form_ClienteHistorico(cliente.id,cliente.Nome);
            
            abrir.Show();
        }

        private void btnBuscaCep_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCep.Text))
            {
                var local = _correio.PesquisaCep(txtCep.Text);

                if (local != null && !String.IsNullOrEmpty(local.logradouro))
                {
                    txtBairro.Text = local.bairro;
                    txtCidade.Text = local.localidade;
                    txtEnd.Text = local.logradouro;
                    txtUf.Text = local.uf;
                }
                else
                {
                    MsgBox.Show("Cep não Encontrado. Certifique-se de ter acesso a internet", "Erro ao pesquisar Cep", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                }

            }
            else
            {
                MsgBox.Show("Inserir um Cep para consulta. Certifique-se de ter acesso a internet", "Erro ao pesquisar Cep", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }
        }

        private void btnHistorico_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(sender as Control, "Histórico Cliente");
        }
    }
}
