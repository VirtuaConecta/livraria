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
using System.Web.Services.Description;
using System.Windows.Forms;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Business;
using VirtuaConecta.Outbound.Parametros;
using VirtuaConecta.Outbound.Utility;
using xDialog;

namespace VirtuaConecta.Outbound.AI.Estoque
{
    public partial class From_Entra_Manual : MaterialForm
    {

        Business.BaseBis.IprodutoBLL _produto;

        Business.BaseBis.Ifornecedor _fornecedor;
        Business.BaseBis.IEstoqueBLL _estoque;
        private List<ItemEntradaProd> listaprod = new List<ItemEntradaProd>();
        public From_Entra_Manual()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);
            btnInserirproduto.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
            _produto = Factory.CriaProdutoBLL();
            _fornecedor = Factory.CriarFornecedorBll();
            _estoque = Factory.CriaEstoqueBll();
        }

        private void From_Entra_Manual_Load(object sender, EventArgs e)
        {
            var listaProd = _produto.Produto_Listar(null).OrderBy(x => x.descricao)
                .Select(d => d.descricao + "-" + d.Sku + "-" + d.id).ToArray();

            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(listaProd);

            txtProduto.AutoCompleteMode = AutoCompleteMode.None;

            txtProduto.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtProduto.AutoCompleteCustomSource = autoComplete;

            dg_itensProdutos = dg.GetDgStyle(dg_itensProdutos, 10, 9);
            carregaComboFornecedor();
        }



        #region Eventos
        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            ShowSuggestions();
        }

        private void ShowSuggestions()
        {
            if (!String.IsNullOrEmpty(txtProduto.Text))
            {

                string keyword = txtProduto.Text.Split(',').Last();
                var source = txtProduto.AutoCompleteCustomSource.OfType<string>().Where(str => str.ToLower().Contains(keyword.ToLower()));
                listBox1.Items.Clear();
                listBox1.Items.AddRange(source.ToArray());
                if (listBox1.Items.Count > 0)
                {
                    listBox1.Visible = true;
                }
            }
            else
            {
                listBox1.Visible = false;
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {

                txtProduto.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
            }
            catch (Exception)
            {


            }
        }

        private void btnInserirproduto_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtProduto.Text) &&
                   !String.IsNullOrEmpty(txtQtd.Text)
                   && Information.IsNumeric(txtQtd.Text)
                  && ValidaHead())
            {
                var propSelec = txtProduto.Text.Split('-');


                listaprod.Add(
                    new ItemEntradaProd
                    {
                        DescSku = propSelec[0],
                        Id_produto = Convert.ToInt32(propSelec[2]),
                        Nr_doc = txtNrNf.Text,
                        Qtd = Convert.ToDecimal(txtQtd.Text)


                    }

                    );
            }
            else
            {
                MsgBox.Show("Existe campo não preenchido", "Erro ao inserir item", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }

            CarregaGrid();

            txtProduto.Text = null;
            txtQtd.Text = null;
        }
        private void btnInserirproduto_MouseEnter(object sender, EventArgs e)
        {
            //  btnInserirproduto.BackColor = Color.Teal;
        }

        private void btnInserirproduto_MouseLeave(object sender, EventArgs e)
        {
            //btnInserirproduto.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight);
        }
        private void btnInserirproduto_MouseHover(object sender, EventArgs e)
        {
            btnInserirproduto.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight);
        }
        #endregion



        public void carregaComboFornecedor()
        {
            try
            {
                var listaCombo = _fornecedor.ListarFornecedor().OrderBy(x => x.Nome).ToList();

                cmbListaFornecedor.DataSource = listaCombo;
                cmbListaFornecedor.DisplayMember = "Nome";
                cmbListaFornecedor.ValueMember = "id";
                cmbListaFornecedor.SelectedIndex = -1;
                cmbListaFornecedor.Font = new Font("Arial", 9);
            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro ao carregar lista de fornecedores em Form_entra_manual:(carregaComboFiltro()) " + ex.Message, MessageType.Error);
                MsgBox.Show("Erro ao carregar Lista de Fornecedores! ", "Falha", MsgBox.Buttons.OK, MsgBox.Icon.Error);

            }
        }

        private void CarregaGrid()
        {

            var source = new BindingSource(listaprod, null);

            dg_itensProdutos.DataSource = source;
            dg_itensProdutos.Columns[0].Visible = false;
            dg_itensProdutos.Columns["Id_produto"].HeaderText = "Id produto";
            dg_itensProdutos.Columns["DescSku"].HeaderText = "Descrição";
            dg_itensProdutos.Columns["DescSku"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private bool ValidaHead()
        { var ret = true;

            if (String.IsNullOrEmpty(txtNrNf.Text))
            {
                MsgBox.Show("Inserir um nr de Nf", "Erro ao validar Entrada", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                ret = false;
            }
            else if (String.IsNullOrEmpty(txtSerie.Text))
            {
                MsgBox.Show("Inserir uma série de Nf", "Erro ao validar Entrada", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                ret = false;
            }
            else if (cmbListaFornecedor.SelectedIndex == -1)
            {
                MsgBox.Show("Inserir um Fornecedor", "Erro ao validar Entrada", MsgBox.Buttons.OK, MsgBox.Icon.Error);

                ret = false;
            }
            
            if (String.IsNullOrEmpty(txtChaveNf.Text))
            {
                txtChaveNf.Text = new string('0', 44);
            }


            return ret;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidaHead() && listaprod.Count > 0)
                {
                    var forn = (FornecedorDTO)cmbListaFornecedor.SelectedItem;
                    var head = new HeadEntradaProd();
                    head.Id_fornecedor = forn.id;
                    head.Nf_nfe = txtNrNf.Text.Trim();
                    head.Serie = txtSerie.Text.Trim();
                    head.Nr_doc = $"{head.Nf_nfe}-{head.Serie}-{head.Id_fornecedor }";
                    head.Data_emissao = dtEmissao.Value.Date;
                    // verifica se ja existe a nota
                    var pedEncontrado = _estoque.ListarNfEntradaBLL(head.Nr_doc).FirstOrDefault();

                    if (pedEncontrado== null || String.IsNullOrEmpty(pedEncontrado.Nr_doc))
                    {
                        var pedidoFinal = new EntradaProdutoDTO();

                        pedidoFinal.Head = new HeadEntradaProd();
                        pedidoFinal.Itens = new List<ItemEntradaProd>();
                        pedidoFinal.Head = head;
                        pedidoFinal.Itens = listaprod;

                        var resp = _estoque.InserirNfEntradaBLL(pedidoFinal);
                        if (resp=="OK")
                        {
                            MsgBox.Show("Nota/Pedido Inserido", "Sucesso!", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                            this.Close();
                        }
                        else
                        {
                            MsgBox.Show("Nota/Pedido Erro ao inserir", "Erro ao validar Entrada", MsgBox.Buttons.OK, MsgBox.Icon.Error);

                        }

                    }
                    else
                    {
                        MsgBox.Show("Nota/Pedido já existe no DB", "Erro ao validar Entrada", MsgBox.Buttons.OK, MsgBox.Icon.Error);

                    }

                }
                else
                {
                    MsgBox.Show("Inserir itens", "Erro ao validar Entrada", MsgBox.Buttons.OK, MsgBox.Icon.Error);

                }
            }
            catch (Exception ex)
            {

                var ee = ex.Message;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
