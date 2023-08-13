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
using xDialog;

namespace VirtuaConecta.Outbound.AI.Produtos
{
    public partial class Form_CadastroProduto : MaterialForm
    {
        IprodutoBLL _produto;
        public Form_CadastroProduto()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);

            this.Font = new Font("Arial", 11);
            dgProduto1 = dg.GetDgStyle(dgProduto1, 10, 9);

            _produto = Factory.CriaProdutoBLL();
        }

        public ProdutoDTO produto = new ProdutoDTO();
        private void Form_CadastroProduto_Load(object sender, EventArgs e)
        {
            AtualizarLista(null);
            txtPesquisa.Focus();
            Acao("Cadastrar");
            carregaComboTipoProduto();
            getStyle();
        }

        private void getStyle()
        {
            lblCod_barra.ForeColor = Color.Teal;
            lblDescricao.ForeColor = Color.Teal;
            lblFornecedor.ForeColor = Color.Teal;
            lblObs.ForeColor = Color.Teal;
            lblPreco.ForeColor = Color.Teal;
            lblLocal.ForeColor = Color.Teal;
            lblNcm.ForeColor = Color.Teal;
            lblSaldo.ForeColor = Color.Teal;
            lblSku.ForeColor = Color.Teal;
            lblFamilia.ForeColor = Color.Teal;
        }

        private void dgProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var produtos = _produto.Produto_Listar(null);
            // aqui retirei o uso de produtos pois ele traz uma lista completa e
           //e quando a lista é filtrada o indice que é a sequencia da tela fica diferente de quando alista está completa com todos os itens
           //assim estava trazendo o tem errado

            //aqui busco o item selecionado do datagrid ele vem como um objeto
            var dataItemJson = JsonConvert.SerializeObject(dgProduto1.CurrentRow.DataBoundItem);
            // aqui converto para ProdutoDTO
            var item = JsonConvert.DeserializeObject<ProdutoDTO>(dataItemJson);

            // 
            txtDescricao.Text = item.descricao;
            txtCod_barra.Text =item.cod_barra;
            txtFornecedor.Text = item.fornecedor;
            txtObs.Text = item.obs;
            txtSku.Text = item.Sku;
            txtSaldo.Text =item.saldo.ToString();
            txtPreco.Text = item.preco.ToString();
            txtLocal.Text = item.local;
            listtipo.SelectedValue = item.id_familia;
            produto.id =item.id;

            Acao("Editar");
        }



        private void Limpar()
        {
            txtDescricao.Text = null;
            txtCod_barra.Text = null;
            txtFornecedor.Text = null;
            txtObs.Text = null;
            txtPreco.Text = null;
            produto = new ProdutoDTO();
            txtPesquisa.Text = null;
            txtLocal.Text = null;
            txtNcm.Text = null;
            txtSaldo.Text = null;
            txtSku.Text = null;
            listtipo.SelectedIndex = -1;
            Acao("Cadastrar");
        }



        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCod_barra.Text) )
            {
                if (!String.IsNullOrWhiteSpace(txtDescricao.Text))
                {
                    if (!String.IsNullOrWhiteSpace(txtPreco.Text))
                    {
                        if (Decimal.TryParse(txtPreco.Text, out Decimal aux))
                        {
                            if (!String.IsNullOrWhiteSpace(txtFornecedor.Text))
                            {
                                if (!String.IsNullOrWhiteSpace(txtSku.Text))
                                {
                                    if (!String.IsNullOrWhiteSpace(txtLocal.Text))
                                    {
                                        if (Decimal.TryParse(txtSaldo.Text, out aux))
                                        {
                                            if (listtipo.SelectedIndex > -1)
                                            {
                                                produto.descricao = txtDescricao.Text;
                                                produto.cod_barra = txtCod_barra.Text;
                                                produto.obs = txtObs.Text;
                                                produto.fornecedor = txtFornecedor.Text;
                                                produto.id_familia = listtipo.SelectedIndex + 1;
                                                produto.local = txtLocal.Text;
                                                produto.ncm = txtNcm.Text;
                                                produto.Sku = txtSku.Text;
                                                produto.saldo = Convert.ToDecimal(txtSaldo.Text);
                                                produto.preco = Convert.ToDecimal(txtPreco.Text);

                                                if (produto.id != 0)
                                                {
                                                    if (_produto.ProdutoEditar(produto) == "OK")
                                                    {
                                                        MsgBox.Show("Editado com sucesso", "Sucesso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                                                        Limpar();
                                                        AtualizarLista(null);
                                                    }
                                                    else
                                                        MsgBox.Show("Erro na edição", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                                                }

                                                else
                                                {
                                                    var resp = _produto.ProdutoInserir(produto).Split('|');
                                                    if (resp[0] == "OK")
                                                    {

                                                        MsgBox.Show("Inserido com sucesso", "Sucesso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                                                        Limpar();
                                                        AtualizarLista(null);

                                                    }
                                                    else
                                                        MsgBox.Show("Erro ao inserir", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                                                }
                                            }
                                            else
                                                MsgBox.Show("Preencha o tipo do produto ", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                                        }
                                        else
                                            MsgBox.Show("Preencha o saldo somente com números ", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                                    }
                                    else
                                        MsgBox.Show("Preencha o local ", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                                }
                                else
                                    MsgBox.Show("Preencha o Sku ", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                            }
                            else

                                MsgBox.Show("Preencha o fornecedor do livro", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                        }
                        else

                            MsgBox.Show("O preço deve ser numerico", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                    }
                    else

                        MsgBox.Show("Preencha o preço do livro", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);

                }
                else
                    MsgBox.Show("Preencha o nome do livro", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }
            else
                MsgBox.Show("Código de barra incorreto", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);

        }

        private void AtualizarLista(string text)
        {
            dgProduto1.Rows.Clear();
            var produtos = new List<ProdutoDTO>();

            if (String.IsNullOrEmpty(text))
                produtos = _produto.Produto_Listar(null);

            else // Aqui a pesquisa deve ser ToUpper porque maiusculas e minusculas são diferentes com o upper igualamos
                produtos = _produto.Produto_Listar(null).Where(x => x.descricao.ToUpper().Contains(text.ToUpper())).ToList();
            //Aqui ao inves fazer o for comentado e formatar as colunas na propriedade do form
            // vamos abistrair e criar um método para fazer essta função
            CarregaGrid(produtos);


            //for (int cont = 0; cont < produtos.Count; cont++)
            //    dgProduto.Rows.Add(produtos[cont].descricao, produtos[cont].preco, produtos[cont].cod_barra, produtos[cont].fornecedor, produtos[cont].obs, produtos[cont].local);
        }

        private void CarregaGrid(List<ProdutoDTO> produtos)
        {
            var itensSelecionados = produtos
                .Select(x =>
                new ProdutoDTO
                {
                    id = x.id,
                    descricao = x.descricao,
                    Sku = x.Sku,
                    cod_barra = x.cod_barra,
                    saldo = x.saldo,
                    local = x.local,
                    preco = x.preco,
                    fornecedor = x.fornecedor,
                    obs = x.obs,
                    id_familia = x.id_familia



                }).ToList();

            //dgProduto1.Columns[9].Visible = false;
            var Source = new BindingSource(itensSelecionados, null);
            dgProduto1.DataSource = Source;
            dgProduto1.Columns["id"].HeaderText = "Id";
            dgProduto1.Columns["descricao"].HeaderText = "Descrição";
            dgProduto1.Columns["cod_barra"].HeaderText = "Ean";
            dgProduto1.Columns["saldo"].HeaderText = "Saldo";
            dgProduto1.Columns["preco"].HeaderText = "Valor";

            dgProduto1.Columns["fornecedor"].HeaderText = "Fornecedor";
            dgProduto1.Columns["obs"].HeaderText = "Obs";
            dgProduto1.Columns["id_familia"].HeaderText = "Familía";

            dgProduto1.AutoResizeColumns();

        }

        private void Form_CadastroProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtPesquisa.Text.Length > 0)
                {
                    var produto = _produto.Produto_Listar(txtPesquisa.Text).FirstOrDefault();
                    if (produto != null && produto.id > 0)
                    {
                        txtCod_barra.Text = produto.cod_barra;
                        txtDescricao.Text = produto.descricao;
                        txtObs.Text = produto.obs;
                        txtPreco.Text = produto.preco.ToString();
                        Acao("Editar");
                    }
                    else
                    {
                        txtCod_barra.Text = txtPesquisa.Text;
                        Acao("Cadastrar");
                    }
                }

            }

        }


        private void Acao(String acao)
        {

            if (acao == "Editar")
            {
                lblAcao.Text = "Editar";
                lblAcao.ForeColor = Color.Red;
            }
            else if (acao == "Cadastrar")
            {
                lblAcao.Text = "Cadastrar";
                lblAcao.ForeColor = Color.Teal;
            }


        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarLista(txtPesquisa.Text);
        }

        public void carregaComboTipoProduto()
        {
            var listaCombo = _produto.ListarTipoProduto().ToList();
            listtipo.DataSource = listaCombo;
            listtipo.DisplayMember = "Tipo_produto";
            listtipo.ValueMember = "Id";
            listtipo.SelectedIndex = -1;
        }
    }

}
