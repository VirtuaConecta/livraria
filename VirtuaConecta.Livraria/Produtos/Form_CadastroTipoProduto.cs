using DotNetBrowser;
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

namespace VirtuaConecta.Outbound.AI.Produtos
{
    public partial class Form_CadastroTipoProduto : MaterialForm
    {
        private IprodutoBLL _produto;
        public Form_CadastroTipoProduto()
        {        
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);

            this.Font = new Font("Arial", 11);

            dgTipo = dg.GetDgStyle(dgTipo,11,11);

            _produto = Factory.CriaProdutoBLL();

        }
        TipoProdutoDTO tipo = new TipoProdutoDTO();

        private void Form_CadastroTipoProduto_Load(object sender, EventArgs e)
        {
            Atualizar(null);
            getStyle();
        }

        private void Atualizar(string text)
        {
            dgTipo.Rows.Clear();
            try
            {
                var tipos = new List<TipoProdutoDTO>();
                var lista = _produto.ListarTipoProduto().Where(x => !String.IsNullOrEmpty(x.tipo_produto)).ToList();
                if (String.IsNullOrEmpty(text))
                    tipos = lista;

                else
                 tipos = lista.Where(x => x.tipo_produto.ToUpper().Contains(text.ToUpper())).ToList();


                var Source = new BindingSource(tipos, null);
                dgTipo.DataSource = Source;
                dgTipo.Columns[0].Visible = false;
                dgTipo.AutoResizeColumns();
            }
            catch (Exception ex)
            {

                var aux=ex.Message;
            }

        }

        private void txtPesquisarTipo_TextChanged(object sender, EventArgs e)
        {
            Atualizar(txtPesquisarTipo.Text);
        }

        private void Limpar()
        {
            txtTipo.Text = null;
          
            tipo = new TipoProdutoDTO();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dgTipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var dataItemJson = JsonConvert.SerializeObject(dgTipo.CurrentRow.DataBoundItem);
            //var item = JsonConvert.DeserializeObject<TipoProdutoDTO>(dataItemJson);

            txtTipo.Text = dgTipo.Rows[e.RowIndex].Cells[1].Value.ToString();
            tipo.Id = Convert.ToInt32(dgTipo.Rows[e.RowIndex].Cells[0].Value);
        }

        private void getStyle()
        {
            lblTipo.ForeColor = Color.Teal;
            lbPesquisar.ForeColor = Color.Teal;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTipo.Text))
            {
                tipo.tipo_produto = txtTipo.Text;
                if (tipo.Id != 0)
                {
                    if (_produto.TipoProdutoEditar(tipo) == "OK")
                    {
                        MsgBox.Show("Editado com sucesso", "Sucesso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                        Limpar();
                        Atualizar(null);
                    }else
                        MsgBox.Show("Erro na edição", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                }
                else
                {
                    if (_produto.TipoProdutoInserir(tipo)== "OK")
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
                MsgBox.Show("Preencha o tipo do produto", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
        }
    }
}
