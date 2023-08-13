namespace VirtuaConecta.Outbound.AI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeMovimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receberContatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImpressoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasDeContatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EntradaManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_abertura = new System.Windows.Forms.PictureBox();
            this.mtxtCodProduto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblLogedin = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_abertura)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ferramentasToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.contatosToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(690, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.BackColorChanged += new System.EventHandler(this.menuStrip1_BackColorChanged);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.ferramentasToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DashboardToolStripMenuItem});
            this.ferramentasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // DashboardToolStripMenuItem
            // 
            this.DashboardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.DashboardToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.DashboardToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem";
            this.DashboardToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.DashboardToolStripMenuItem.Text = "DashBoard";
            this.DashboardToolStripMenuItem.Click += new System.EventHandler(this.DashboardToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentoDeCaixaToolStripMenuItem,
            this.históricoDeMovimentaçãoToolStripMenuItem,
            this.pagarToolStripMenuItem});
            this.caixaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // movimentoDeCaixaToolStripMenuItem
            // 
            this.movimentoDeCaixaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.movimentoDeCaixaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.movimentoDeCaixaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.movimentoDeCaixaToolStripMenuItem.Name = "movimentoDeCaixaToolStripMenuItem";
            this.movimentoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(258, 28);
            this.movimentoDeCaixaToolStripMenuItem.Text = "Movimento de caixa";
            this.movimentoDeCaixaToolStripMenuItem.Click += new System.EventHandler(this.movimentoDeCaixaToolStripMenuItem_Click);
            // 
            // históricoDeMovimentaçãoToolStripMenuItem
            // 
            this.históricoDeMovimentaçãoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.históricoDeMovimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechamentoToolStripMenuItem});
            this.históricoDeMovimentaçãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.históricoDeMovimentaçãoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.históricoDeMovimentaçãoToolStripMenuItem.Name = "históricoDeMovimentaçãoToolStripMenuItem";
            this.históricoDeMovimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(258, 28);
            this.históricoDeMovimentaçãoToolStripMenuItem.Text = "Relatórios";
            // 
            // fechamentoToolStripMenuItem
            // 
            this.fechamentoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.fechamentoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fechamentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fechamentoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fechamentoToolStripMenuItem.Image")));
            this.fechamentoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.fechamentoToolStripMenuItem.Name = "fechamentoToolStripMenuItem";
            this.fechamentoToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.fechamentoToolStripMenuItem.Text = "Fechamento";
            this.fechamentoToolStripMenuItem.Click += new System.EventHandler(this.fechamentoToolStripMenuItem_Click);
            // 
            // pagarToolStripMenuItem
            // 
            this.pagarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.pagarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.pagarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pagarToolStripMenuItem.Name = "pagarToolStripMenuItem";
            this.pagarToolStripMenuItem.Size = new System.Drawing.Size(258, 28);
            this.pagarToolStripMenuItem.Text = "Pagar";
            this.pagarToolStripMenuItem.Click += new System.EventHandler(this.pagarToolStripMenuItem_Click);
            // 
            // contatosToolStripMenuItem
            // 
            this.contatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarListaToolStripMenuItem,
            this.receberContatoToolStripMenuItem,
            this.formasDePagamentoToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.tiposDeProdutosToolStripMenuItem});
            this.contatosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.contatosToolStripMenuItem.Name = "contatosToolStripMenuItem";
            this.contatosToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.contatosToolStripMenuItem.Text = "Cadastros";
            // 
            // atualizarListaToolStripMenuItem
            // 
            this.atualizarListaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.atualizarListaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.atualizarListaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.atualizarListaToolStripMenuItem.Name = "atualizarListaToolStripMenuItem";
            this.atualizarListaToolStripMenuItem.Size = new System.Drawing.Size(276, 28);
            this.atualizarListaToolStripMenuItem.Text = "Clientes";
            this.atualizarListaToolStripMenuItem.Click += new System.EventHandler(this.atualizarListaToolStripMenuItem_Click);
            // 
            // receberContatoToolStripMenuItem
            // 
            this.receberContatoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.receberContatoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.receberContatoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.receberContatoToolStripMenuItem.Name = "receberContatoToolStripMenuItem";
            this.receberContatoToolStripMenuItem.Size = new System.Drawing.Size(276, 28);
            this.receberContatoToolStripMenuItem.Text = "Produtos";
            this.receberContatoToolStripMenuItem.Click += new System.EventHandler(this.receberContatoToolStripMenuItem_Click);
            // 
            // formasDePagamentoToolStripMenuItem
            // 
            this.formasDePagamentoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.formasDePagamentoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.formasDePagamentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.formasDePagamentoToolStripMenuItem.Name = "formasDePagamentoToolStripMenuItem";
            this.formasDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(276, 28);
            this.formasDePagamentoToolStripMenuItem.Text = "Formas de pagamento";
            this.formasDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.formasDePagamentoToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.fornecedoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.fornecedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(276, 28);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // tiposDeProdutosToolStripMenuItem
            // 
            this.tiposDeProdutosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.tiposDeProdutosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tiposDeProdutosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tiposDeProdutosToolStripMenuItem.Name = "tiposDeProdutosToolStripMenuItem";
            this.tiposDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(276, 28);
            this.tiposDeProdutosToolStripMenuItem.Text = "Tipos de produtos";
            this.tiposDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeProdutosToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImpressoraToolStripMenuItem,
            this.listasDeContatosToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // ImpressoraToolStripMenuItem
            // 
            this.ImpressoraToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.ImpressoraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ImpressoraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ImpressoraToolStripMenuItem.Name = "ImpressoraToolStripMenuItem";
            this.ImpressoraToolStripMenuItem.Size = new System.Drawing.Size(184, 28);
            this.ImpressoraToolStripMenuItem.Text = "Impressora";
            this.ImpressoraToolStripMenuItem.Click += new System.EventHandler(this.ImpressoraToolStripMenuItem_Click);
            // 
            // listasDeContatosToolStripMenuItem
            // 
            this.listasDeContatosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.listasDeContatosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.listasDeContatosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.listasDeContatosToolStripMenuItem.Name = "listasDeContatosToolStripMenuItem";
            this.listasDeContatosToolStripMenuItem.Size = new System.Drawing.Size(184, 28);
            this.listasDeContatosToolStripMenuItem.Text = "Nd";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.usuáriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.usuáriosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(184, 28);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.EntradaManualToolStripMenuItem,
            this.pesquisarToolStripMenuItem});
            this.estoqueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.entradaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.entradaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(293, 28);
            this.entradaToolStripMenuItem.Text = "Entrada xml";
            this.entradaToolStripMenuItem.Click += new System.EventHandler(this.entradaToolStripMenuItem_Click);
            // 
            // EntradaManualToolStripMenuItem
            // 
            this.EntradaManualToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.EntradaManualToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.EntradaManualToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.EntradaManualToolStripMenuItem.Name = "EntradaManualToolStripMenuItem";
            this.EntradaManualToolStripMenuItem.Size = new System.Drawing.Size(293, 28);
            this.EntradaManualToolStripMenuItem.Text = "Entrada Manual";
            this.EntradaManualToolStripMenuItem.Click += new System.EventHandler(this.EntradaManualToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.pesquisarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.pesquisarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(293, 28);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar movimentação";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioLogin.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUsuarioLogin.Location = new System.Drawing.Point(11, 120);
            this.lblUsuarioLogin.Margin = new System.Windows.Forms.Padding(3, 10, 11, 10);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(102, 1);
            this.lblUsuarioLogin.TabIndex = 59;
            this.lblUsuarioLogin.Text = "usuario logado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(0, 735);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Pressione barra de espaço para abrir o caixa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox_abertura
            // 
            this.pictureBox_abertura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_abertura.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox_abertura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_abertura.Location = new System.Drawing.Point(280, 92);
            this.pictureBox_abertura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_abertura.Name = "pictureBox_abertura";
            this.pictureBox_abertura.Size = new System.Drawing.Size(796, 446);
            this.pictureBox_abertura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_abertura.TabIndex = 61;
            this.pictureBox_abertura.TabStop = false;
            // 
            // mtxtCodProduto
            // 
            this.mtxtCodProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtxtCodProduto.Depth = 0;
            this.mtxtCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCodProduto.Hint = "";
            this.mtxtCodProduto.Location = new System.Drawing.Point(11, 92);
            this.mtxtCodProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtCodProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtxtCodProduto.Name = "mtxtCodProduto";
            this.mtxtCodProduto.PasswordChar = '\0';
            this.mtxtCodProduto.SelectedText = "";
            this.mtxtCodProduto.SelectionLength = 0;
            this.mtxtCodProduto.SelectionStart = 0;
            this.mtxtCodProduto.Size = new System.Drawing.Size(241, 28);
            this.mtxtCodProduto.TabIndex = 62;
            this.mtxtCodProduto.TabStop = false;
            this.mtxtCodProduto.UseSystemPasswordChar = false;
            // 
            // lblLogedin
            // 
            this.lblLogedin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogedin.AutoSize = true;
            this.lblLogedin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogedin.ForeColor = System.Drawing.Color.Teal;
            this.lblLogedin.Location = new System.Drawing.Point(1028, 73);
            this.lblLogedin.Name = "lblLogedin";
            this.lblLogedin.Size = new System.Drawing.Size(48, 17);
            this.lblLogedin.TabIndex = 65;
            this.lblLogedin.Text = "loged";
            this.lblLogedin.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1273, 752);
            this.Controls.Add(this.lblLogedin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxtCodProduto);
            this.Controls.Add(this.pictureBox_abertura);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_abertura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receberContatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImpressoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasDeContatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeMovimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasDePagamentoToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_abertura;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtxtCodProduto;
        private System.Windows.Forms.Label lblLogedin;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EntradaManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
    }
}