using MaterialSkin;
using MaterialSkin.Controls;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
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

namespace VirtuaConecta.Outbound.AI.Estoque
{
    public partial class Form_Entrar_Estoque : MaterialForm
    {
        private IEstoqueBLL _estoque;
        private Ifornecedor _fornecedor;

        NfeEntradaDTO xml;
        public Form_Entrar_Estoque()
        {
            _estoque = Factory.CriaEstoqueBll();
            _fornecedor = Factory.CriarFornecedorBll();
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
             Primary.Teal400, Primary.Cyan900, Primary.Teal200,
             Accent.Teal700, TextShade.WHITE);
            xml = new NfeEntradaDTO();
            #region Datagrid
            //retira a coluna de seleção a esquerda
            dgItensXml.RowHeadersVisible = false;
            dgItensXml.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11);
            dgItensXml.RowsDefaultCellStyle.Font = new Font("Arial", 9);
            dgItensXml.RowsDefaultCellStyle.Format = "N2";
            // dgprodutos.BorderStyle = BorderStyle.None;
            dgItensXml.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgItensXml.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgItensXml.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgItensXml.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgItensXml.BackgroundColor = Color.White;

            dgItensXml.EnableHeadersVisualStyles = false;
            dgItensXml.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgItensXml.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 96, 100);
            dgItensXml.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //  dgprodutos.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top);

            #endregion



        }

        private void panelDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            panelDragDrop.BackColor = Color.FromArgb(0, 96, 100);
        }

        private void panelDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            String[] arquivos = (String[])e.Data.GetData(DataFormats.FileDrop);
            var ext = arquivos[0].Split('.');
            if (ext.Length == 2 && ext[1].ToUpper() == "XML")
            {
                //MsgBox.Show($"Arquivo: {arquivos[0]}","",MsgBox.Buttons.OK );
                panelDragDrop.BackColor = Color.FromName("Control");
                xml = _estoque.GetNfeEntrada(arquivos[0]);
                if (xml.Head.Cnpj_Cpf_for != null)
                {

                    if (xml.Itens.Count > 0)
                    {
                        CarregaDadosFornecedor(xml);
                        carregaGridCaixa(xml.Itens);


                    }

                }
                else
                {
                    MsgBox.Show("Erro ao ler o XML", "Entrada de Xml", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                }

            }
            else
            {
                MsgBox.Show($"Arquivo não reconhecido", "", MsgBox.Buttons.OK);
                panelDragDrop.BackColor = Color.Red;
            }

        }

        private void panelDragDrop_DragLeave(object sender, EventArgs e)
        {
            panelDragDrop.BackColor = Color.FromName("Control");
        }

        #region Funcoes
        public void carregaGridCaixa(List<ItensEntrada> itens)
        {




            var fonte = itens.Select(e => new
            {
                e.Descricao_prod,
                e.Sku,
                e.Especie,
                e.Qtd,
                e.Ean,
                e.Ncm,
                e.Valor_unit


            }).ToList();

            dgItensXml.DataSource = fonte;

            dgItensXml.Columns[0].HeaderText = "Produto";
            dgItensXml.Columns[1].HeaderText = "Sku";
            dgItensXml.Columns[2].HeaderText = "Und";
            dgItensXml.Columns[3].HeaderText = "Qtd";
            dgItensXml.Columns[4].HeaderText = "C barra";
            dgItensXml.Columns[5].HeaderText = "Ncm";
            dgItensXml.Columns[6].HeaderText = "Valor R$";
            // dgItensXml.Columns[0].Width = 250;
            dgItensXml.AutoResizeColumn(0);
            dgItensXml.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void CarregaDadosFornecedor(NfeEntradaDTO head)
        {
            txtNomeFornecedor.Text = head.Head.Nome_for;
            txtCnpj.Text = head.Head.Cnpj_Cpf_for;
            txtInscEst.Text = head.Head.IE_for;
            txtEndereco.Text = head.Head.Endereco_for;
            TxtBairro.Text = head.Head.Bairro_for;
            txtCep.Text = head.Head.Cep_For;
            txtCidade.Text = head.Head.Cidade_for;
            txtEstado.Text = head.Head.Estado_for;
            txtTelefone.Text = head.Head.Telefone_for;
            txtCodMun.Text = head.Head.Cod_municipio_for;
            txtNrNf.Text = head.Head.Nr_nf;
            txtDataNf.Text = head.Head.Data_emissao.ToString("yyyy-MM-dd HH:mm:ss");
            txtChaveNf.Text = head.Head.Chave_nfe;
        
        }

        public FornecedorDTO CapturaDadosFornecedor()
        {
            var forn = new FornecedorDTO();
            forn.Nome = txtNomeFornecedor.Text.Trim();
            forn.Cpf_cnpj = Conversoes.LimpaFormato(txtCnpj.Text);
            forn.Ie = Conversoes.LimpaFormato(txtInscEst.Text);
            forn.Telefone = Conversoes.LimpaFormato(txtTelefone.Text);
            forn.Cep = Conversoes.LimpaFormato(txtCep.Text);
            forn.Endereco = txtEndereco.Text;
            forn.Bairro = TxtBairro.Text;
            forn.Cidade = txtCidade.Text;
            forn.Estado = txtEstado.Text;
            forn.Contato = txtContato.Text;
            forn.Email = txtEmail.Text.Trim();
            if (!String.IsNullOrEmpty(txtCodMun.Text) && Microsoft.VisualBasic.Information.IsNumeric(txtCodMun.Text))
            {
                forn.Cod_mun = Convert.ToInt32(txtCodMun.Text);
            }

            if (forn.Cpf_cnpj.Length == 11)
            {
                forn.Fis_jur = "F";
            }
            else if (forn.Cpf_cnpj.Length == 14)
            {
                forn.Fis_jur = "J";
            }




            return forn;
        }


        #endregion

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var dadosForn = CapturaDadosFornecedor();
            // verifica se o forncedor existe
            var fornecedorExiste = _fornecedor.ExisteFornecedor(dadosForn.Cpf_cnpj);
            //verifica os campos preechidos do form
            var ValidFornecedor = _fornecedor.ValidaFornecedor(dadosForn);

            // verifica se o fornecedor existe
            if (ValidFornecedor == "OK")
            {
                if (!fornecedorExiste)
                {
                    //insere fornecedor
                    var inserir = _fornecedor.InserirFornecedor(dadosForn);

                    if (inserir != "OK")
                    {
                        MsgBox.Show("Fornecedor não foi Inserido", "Erro Inserir Estoque", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                    }
                    else // inserir os produtos
                    {
                        //captura

                        inserirProduto();

                    }

                }
                else //edita
                {
                    //insere fornecedor
                    var editar = _fornecedor.EditarFornecedor(dadosForn);

                    if (editar != "OK")
                    {
                        MsgBox.Show("Fornecedor não foi Atualizado", "Erro Inserir Estoque", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                    }
                    else
                    {
                        inserirProduto();
                    }
                }




            }
            else
            {
                MsgBox.Show(ValidFornecedor, "Erro ao validar Fornecedor", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }

        }

        private void inserirProduto()
        {

            var retProdInserido = _estoque.InserirPedidoXml(xml);

            if (retProdInserido == "OK")
            {
                MsgBox.Show("Produtos Inseridos com sucesso", "Inserir Estoque", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                this.Close();
            }
            else
            {
                MsgBox.Show("Produtos não foram Inseridos", "Erro Inserir Estoque", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
