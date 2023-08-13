using MaterialSkin;
using MaterialSkin.Controls;
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

namespace VirtuaConecta.Outbound.AI.Fornecedores
{
    public partial class Form_CadastrarFornecedor : MaterialForm
    {
        private Ifornecedor _fornecedor;
        private IcorreioBLL _correio;

        public Form_CadastrarFornecedor()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);

            this.Font = new Font("Arial", 10);

            dgFornecedor = dg.GetDgStyle(dgFornecedor,10, 9);

            _fornecedor = Factory.CriarFornecedorBll();
            _correio = Factory.CriarCorreioBLL();
        }
        FornecedorDTO fornecedor = new FornecedorDTO();
        private void Form_CadastrarFornecedor_Load(object sender, EventArgs e)
        {
            Atualizar(null);
            getStyle();

        }

        private void Atualizar(string text)
        {


            var fornecedores = new List<FornecedorDTO>();
            var lista = _fornecedor.ListarFornecedor().Where(x => !String.IsNullOrEmpty(x.Nome)).ToList();
            if (String.IsNullOrEmpty(text))
                fornecedores = lista;

            else
                fornecedores = lista.Where(x => x.Nome.ToUpper().Contains(text.ToUpper())).ToList();


            var Source = new BindingSource(fornecedores, null);
            dgFornecedor.DataSource = Source;
            dgFornecedor.Columns[0].Visible = false;
            dgFornecedor.Columns[3].Visible = false;
            dgFornecedor.Columns[4].Visible = false;
            dgFornecedor.Columns[7].Visible = false;
            dgFornecedor.Columns[13].Visible = false;
            dgFornecedor.Columns[14].Visible = false;
            dgFornecedor.AutoResizeColumns();
        }

        private void getStyle()
        {
            lblBairro.ForeColor = Color.Teal;
            lblCep.ForeColor = Color.Teal;
            lblCidade.ForeColor = Color.Teal;
            lblContato.ForeColor = Color.Teal;
            lblCpf.ForeColor = Color.Teal;
            lblEmail.ForeColor = Color.Teal;
            lblEnd.ForeColor = Color.Teal;
            lblEstado.ForeColor = Color.Teal;
            lblIe.ForeColor = Color.Teal;
            lblNome.ForeColor = Color.Teal;
            lblPesquisar.ForeColor = Color.Teal;
            lblTelefone.ForeColor = Color.Teal;
        }

        private void dgFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpar();
            var dataItemJson = JsonConvert.SerializeObject(dgFornecedor.CurrentRow.DataBoundItem);
            var item = JsonConvert.DeserializeObject<FornecedorDTO>(dataItemJson);
            txtBairro.Text = item.Bairro;
            txtCep.Text = item.Cep;
            txtCidade.Text = item.Cidade;
            txtContato.Text = item.Contato;
            txtCpf.Text = item.Cpf_cnpj;
            txtEmail.Text = item.Email;
            txtEnd.Text = item.Endereco;
            txtEstado.Text = item.Estado;
            txtIE.Text = item.Ie;
            txtNome.Text = item.Nome;
            txtTelefone.Text =Conversoes.LimpaFormato(item.Telefone);

            fornecedor = item;

        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtBairro.Text = null;
            txtCep.Text = null;
            txtCidade.Text = null;
            txtContato.Text = null;
            txtCpf.Text = null;
            txtEmail.Text = null;
            txtEnd.Text = null;
            txtEstado.Text = null;
            txtIE.Text = null;
            txtNome.Text = null;
            txtTelefone.Text = null;

            fornecedor = new FornecedorDTO();
        }

        private void txtPesquisarFornecedor_TextChanged(object sender, EventArgs e)
        {
            Atualizar(txtPesquisarFornecedor.Text);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            fornecedor.Nome = txtNome.Text;
            fornecedor.Bairro = txtBairro.Text;
            fornecedor.Cep = txtCep.Text;
            fornecedor.Cidade = txtCidade.Text;
            fornecedor.Contato = txtContato.Text;
            fornecedor.Cpf_cnpj = txtCpf.Text;

            if (fornecedor.Cpf_cnpj.Length == 11)
                fornecedor.Fis_jur = "F";
            else if (fornecedor.Cpf_cnpj.Length == 14)
                fornecedor.Fis_jur = "J";
            fornecedor.Email = txtEmail.Text;
            fornecedor.Endereco = txtEnd.Text;
            fornecedor.Estado = txtEstado.Text;
            fornecedor.Ie = txtIE.Text;
            fornecedor.Nome = txtNome.Text;
            fornecedor.Telefone = txtTelefone.Text;

            var verifica = _fornecedor.ValidaFornecedor(fornecedor);
            if (verifica == "OK")
            {
                if (fornecedor.id != 0)
                {
                    if (_fornecedor.EditarFornecedor(fornecedor) == "OK")
                    {
                        MsgBox.Show("Editado com sucesso", "Sucesso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                        Atualizar(null);
                        Limpar();
                    }
                    else
                        MsgBox.Show("Erro na edição", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                }
                else
                {
                    if (_fornecedor.InserirFornecedor(fornecedor) == "OK")
                    {
                        MsgBox.Show("Inserido com sucesso", "Sucesso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                        Limpar();
                        Atualizar(null);
                    }
                    else
                        MsgBox.Show("Erro na inserção", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                }
            }
            else
                MsgBox.Show(verifica, "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
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
                    txtEstado.Text = local.uf;
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
    }
}
