using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VirtuaConecta.Livraria.Caixa;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.AI.Clientes;
using VirtuaConecta.Outbound.AI.Configuracoes;
//using VirtuaConecta.Outbound.AI.Contatos;
using VirtuaConecta.Outbound.AI.Fornecedores;
using VirtuaConecta.Outbound.AI.Pagamento;
using VirtuaConecta.Outbound.AI.Produtos;
using VirtuaConecta.Outbound.AI.Relatorios;
using VirtuaConecta.Outbound.Business;
using VirtuaConecta.Outbound.Business.BaseBis;
using VirtuaConecta.Outbound.Parametros;
using VirtuaConecta.Outbound.Utility;
using xDialog;


namespace VirtuaConecta.Outbound.AI
{
    public partial class MainForm : MaterialForm

    {
        IprodutoBLL _produto;
        Business.BaseBis.IusuarioBll _iuser;
        Business.BaseBis.ImovCaixa _MovCaixaBLL;

        String validaUser;
        public MainForm()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);
            RenderMenu();
            _produto = Factory.CriaProdutoBLL();
            _iuser = Factory.CriaUsuarioBLL();
            LiberarMenus();
            _MovCaixaBLL = Factory.CriaMovCaixa();
            validaUser = ValidaUser();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mtxtCodProduto.Focus();
            CarregaImagemCentral();
            this.Font = new Font("Arial", 11);
            menuStrip1.Font = new Font("Arial", 11);
            //  this.Text = "Sistema de Gestão de Livraria";
           
        }

        #region Eventos

        private void RenderMenu()
        {
            ToolStrip ms = ToolStripManager.FindToolStrip("menuStrip1");
            ms.Renderer = new CustomProfessionalRenderer();
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                ((ToolStripDropDownMenu)menuItem.DropDown).ShowImageMargin = false;
           
                foreach (ToolStripMenuItem submenuItem in menuItem.DropDownItems)
                ((ToolStripDropDownMenu)submenuItem.DropDown).ShowImageMargin = false;
            }
        }

        class CustomProfessionalRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                var bruBackg = new SolidBrush(Color.FromArgb(38, 166, 154));
                var bruSelec = new SolidBrush(Color.Teal);
                var caneta = new Pen(Color.FromArgb(38, 166, 154));

                if (e.Item.Selected)
                {
                 //   e.ToolStrip.ForeColor = Color.Black;
                    e.ToolStrip.BackColor = Color.FromArgb(38, 166, 154);
                    Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);

                    e.Graphics.FillRectangle(

                    bruSelec, rc);

                    e.Graphics.DrawRectangle(

                    caneta, 1, 0, rc.Width - 2, rc.Height - 1);
                }
                else
                {
                   // e.ToolStrip.ForeColor = Color.Black;
                    e.ToolStrip.BackColor = Color.FromArgb(38, 166, 154);
                    Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                    
                    e.Graphics.FillRectangle(

                   bruBackg, rc);

                    e.Graphics.DrawRectangle(

                    caneta, 1, 0, rc.Width - 2, rc.Height - 1);
                }


            }
            

            //protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
            //{
            //    Rectangle r = Rectangle.Inflate(e.Item.ContentRectangle, -2, -2);

            //    if (e.Item.Selected)
            //    {
            //        e.ToolStrip.ForeColor = Color.Black;
            //        e.ToolStrip.BackColor = Color.FromArgb(38, 166, 154);
                 
            //        //using (brush b = new solidbrush(professionalcolors.separatorlight))
            //        //{
            //        //    e.graphics.fillrectangle(b, r);
            //        //}
            //    }
            //    else
            //    {
            //        e.ToolStrip.ForeColor = Color.Black;
            //        e.ToolStrip.BackColor = Color.Teal;
            //        //using (Pen p = new Pen(ProfessionalColors.SeparatorLight))
            //        //{
            //        //    e.Graphics.DrawRectangle(p, r);
            //        //}
            //    }
            //}


        }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (mtxtCodProduto.Text.Length >= 10 && mtxtCodProduto.Text.Length <= 13)
                {
                    var produto = _produto.Produto_Listar(mtxtCodProduto.Text);
                    if (produto.Count != 0)
                    {

                        Form_caixa1 form = new Form_caixa1(produto[0]);
                        form.Show();
                       
                    }
                    else
                    {
                        MsgBox.Show("Erro, codigo incorreto");
                    }
                }
                else
                {
                    MsgBox.Show("Erro, codigo incorreto");
                }
                mtxtCodProduto.Text = null;
            }
            else if (e.KeyValue == 32)
            {
                Form_caixa1 frmcaixa1 = new Form_caixa1(null);
                frmcaixa1.Show();
            }
        }

        #endregion

        #region Funcoes


        private void LiberarMenus()
        {
            var liberacoes = Parametros.Parametros.MenusLiberados().Split(',');

            if (liberacoes[0] == "0")
            {
                ferramentasToolStripMenuItem.Enabled = false;
            }
            else
            {
                ferramentasToolStripMenuItem.Enabled = true;
            }
            if (liberacoes[1] == "0")
            {
                caixaToolStripMenuItem.Enabled = false;
            }
            else
            {
                caixaToolStripMenuItem.Enabled = true;
            }
            if (liberacoes[2] == "0")
            {
                contatosToolStripMenuItem.Enabled = false;
            }
            else
            {
                contatosToolStripMenuItem.Enabled = true;
            }

            if (liberacoes[3] == "0")
            {
                configuraçõesToolStripMenuItem.Enabled = false;
            }
            else
            {
                configuraçõesToolStripMenuItem.Enabled = true;
            }
        }

        private string ValidaUser()

        {
            String login = VarGlobal.LoginName;
            String pw = Conversoes.MD5Hash(VarGlobal.Password);



            string resp = null;
            var user = _iuser.ListaUsuarios().Where(x => x.LoginUsuario == login).FirstOrDefault();
            if (user != null)
            {

                if (user.SenhaUsuario == pw)
                {
                    resp = user.IdPerfil.ToString();

                    lblLogedin.Visible = true;
                    lblLogedin.Text = $"Bem vindo(a) {user.NomeUsuario} !";
                }
                else
                {
                    lblLogedin.Visible = false;
                }
            }

            return resp;
        }

        public Int32 CarregaImagemCentral()
        {
            Int32 StatusMovCaixa = 0;
            pictureBox_abertura.Visible = true;
            String img = null;

            try
            {

                StatusMovCaixa = _MovCaixaBLL.StatusMovCaixa();

                if (StatusMovCaixa != 3)
                {
                    img = Parametros.Parametros.ImagemAberto();

                    mtxtCodProduto.Focus();

                    mtxtCodProduto.Enabled = true;

                }
                else if (StatusMovCaixa == 3)
                {
                    mtxtCodProduto.Enabled = false;


                    img = Parametros.Parametros.ImagemFechado();
                }

                var pic = Convert.FromBase64String(img);
                System.Drawing.Image image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(pic));
                pictureBox_abertura.Image = image;
            }
            catch (Exception ex)
            {
                LogEvento.EscreverEvento("Erro ao carregar img Central " + ex.Message.ToString(), MessageType.Error);


            }

            return StatusMovCaixa;
        }
        #endregion

        #region Itens de Menu
        private void remessasCorreioToolStripMenuItem_Click(object sender, EventArgs e)
        {
       //     Form_Correio form_contato = new Form_Correio();
        //    form_contato.Show();
        }

        private void atualizarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CadastroCliente abrir = new Form_CadastroCliente();
            abrir.Show();
        }


        private void DashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.Form_dash _form = new Relatorios.Form_dash();
            _form.Show();
        }
        //Abrir form Caixa
        private void pagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_caixa1 form = new Form_caixa1(null);
            form.Show();
        }


        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (validaUser == "2")
            {

                Configuracoes.Form_listaUser frmuser = new Configuracoes.Form_listaUser();

                frmuser.Show();
            }
            else
            {
                MsgBox.Show("Usuario sem permissão", "Acesso Negado", MsgBox.Buttons.OK, MsgBox.Icon.Warning);


            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_login form = new Form_login();
            form.Show();
        }


 
        private void fechamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forn_rel_caixa _form = new Forn_rel_caixa();

            _form.Show();
        }
        private void movimentoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caixa.Form_mov_caixa _form = new Caixa.Form_mov_caixa(this);

            _form.Show();
        }
        private void receberContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abrir = new Form_CadastroProduto();
            abrir.Show();
        }

        private void ImpressoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var impressora = new Form_Imprimir(null);
            impressora.Show();
        }
        private void menuStrip1_BackColorChanged(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.FromArgb(38, 166, 154);
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque.Form_Entrar_Estoque frmEstoque = new Estoque.Form_Entrar_Estoque();
            frmEstoque.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedores.Form_CadastrarFornecedor abrir = new Fornecedores.Form_CadastrarFornecedor();
            abrir.Show();
        }


        private void tiposDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CadastroTipoProduto abrir = new Form_CadastroTipoProduto();
            abrir.Show();
        }
        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque.Form_mov_estoque pesquisaMov = new Estoque.Form_mov_estoque();
            pesquisaMov.Show();
        }

        private void EntradaManualToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Estoque.From_Entra_Manual EntradaManual = new Estoque.From_Entra_Manual();
            EntradaManual.Show();
        }


        #endregion

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CadastrarFormaPagamento abrir = new Form_CadastrarFormaPagamento();
            abrir.Show();
        }
    }

}
