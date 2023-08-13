namespace VirtuaConecta.Outbound.AI.Produtos
{
    partial class Form_CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CadastroProduto));
            this.lblDescricao = new MaterialSkin.Controls.MaterialLabel();
            this.lblPreco = new MaterialSkin.Controls.MaterialLabel();
            this.lblCod_barra = new MaterialSkin.Controls.MaterialLabel();
            this.lblObs = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescricao = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFornecedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFornecedor = new MaterialSkin.Controls.MaterialLabel();
            this.txtPreco = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtObs = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtPesquisa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblAcao = new MaterialSkin.Controls.MaterialLabel();
            this.listtipo = new System.Windows.Forms.ComboBox();
            this.lblNcm = new MaterialSkin.Controls.MaterialLabel();
            this.txtNcm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblLocal = new MaterialSkin.Controls.MaterialLabel();
            this.txtLocal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSaldo = new MaterialSkin.Controls.MaterialLabel();
            this.txtSaldo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSku = new MaterialSkin.Controls.MaterialLabel();
            this.txtSku = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgProduto1 = new System.Windows.Forms.DataGridView();
            this.txtCod_barra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFamilia = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescricao.Depth = 0;
            this.lblDescricao.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescricao.Location = new System.Drawing.Point(10, 347);
            this.lblDescricao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(77, 19);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblPreco
            // 
            this.lblPreco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreco.AutoSize = true;
            this.lblPreco.Depth = 0;
            this.lblPreco.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPreco.Location = new System.Drawing.Point(259, 346);
            this.lblPreco.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(48, 19);
            this.lblPreco.TabIndex = 3;
            this.lblPreco.Text = "Preço";
            // 
            // lblCod_barra
            // 
            this.lblCod_barra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCod_barra.AutoSize = true;
            this.lblCod_barra.Depth = 0;
            this.lblCod_barra.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCod_barra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCod_barra.Location = new System.Drawing.Point(619, 347);
            this.lblCod_barra.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCod_barra.Name = "lblCod_barra";
            this.lblCod_barra.Size = new System.Drawing.Size(34, 19);
            this.lblCod_barra.TabIndex = 4;
            this.lblCod_barra.Text = "Ean";
            // 
            // lblObs
            // 
            this.lblObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObs.AutoSize = true;
            this.lblObs.Depth = 0;
            this.lblObs.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObs.Location = new System.Drawing.Point(189, 405);
            this.lblObs.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(88, 19);
            this.lblObs.TabIndex = 5;
            this.lblObs.Text = "Observação";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDescricao.Depth = 0;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Hint = "";
            this.txtDescricao.Location = new System.Drawing.Point(11, 369);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescricao.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.Size = new System.Drawing.Size(236, 23);
            this.txtDescricao.TabIndex = 57;
            this.txtDescricao.TabStop = false;
            this.txtDescricao.UseSystemPasswordChar = false;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFornecedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFornecedor.Depth = 0;
            this.txtFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Hint = "";
            this.txtFornecedor.Location = new System.Drawing.Point(11, 427);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFornecedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.PasswordChar = '\0';
            this.txtFornecedor.SelectedText = "";
            this.txtFornecedor.SelectionLength = 0;
            this.txtFornecedor.SelectionStart = 0;
            this.txtFornecedor.Size = new System.Drawing.Size(173, 23);
            this.txtFornecedor.TabIndex = 58;
            this.txtFornecedor.TabStop = false;
            this.txtFornecedor.UseSystemPasswordChar = false;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Depth = 0;
            this.lblFornecedor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFornecedor.Location = new System.Drawing.Point(8, 405);
            this.lblFornecedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(85, 19);
            this.lblFornecedor.TabIndex = 2;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPreco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPreco.Depth = 0;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Hint = "";
            this.txtPreco.Location = new System.Drawing.Point(259, 369);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPreco.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.SelectedText = "";
            this.txtPreco.SelectionLength = 0;
            this.txtPreco.SelectionStart = 0;
            this.txtPreco.Size = new System.Drawing.Size(88, 23);
            this.txtPreco.TabIndex = 59;
            this.txtPreco.TabStop = false;
            this.txtPreco.UseSystemPasswordChar = false;
            // 
            // txtObs
            // 
            this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtObs.Depth = 0;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Hint = "";
            this.txtObs.Location = new System.Drawing.Point(189, 427);
            this.txtObs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObs.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObs.Name = "txtObs";
            this.txtObs.PasswordChar = '\0';
            this.txtObs.SelectedText = "";
            this.txtObs.SelectionLength = 0;
            this.txtObs.SelectionStart = 0;
            this.txtObs.Size = new System.Drawing.Size(428, 23);
            this.txtObs.TabIndex = 60;
            this.txtObs.TabStop = false;
            this.txtObs.UseSystemPasswordChar = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.BackgroundImage")));
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(735, 474);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(56, 46);
            this.btnCadastrar.TabIndex = 62;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(628, 470);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 50);
            this.btnLimpar.TabIndex = 63;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPesquisa.Depth = 0;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Hint = "";
            this.txtPesquisa.Location = new System.Drawing.Point(94, 73);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPesquisa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.Size = new System.Drawing.Size(214, 23);
            this.txtPesquisa.TabIndex = 64;
            this.txtPesquisa.TabStop = false;
            this.txtPesquisa.UseSystemPasswordChar = false;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 65;
            this.materialLabel1.Text = "Descrição";
            // 
            // lblAcao
            // 
            this.lblAcao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAcao.AutoSize = true;
            this.lblAcao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAcao.Depth = 0;
            this.lblAcao.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAcao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAcao.Location = new System.Drawing.Point(719, 77);
            this.lblAcao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(13, 19);
            this.lblAcao.TabIndex = 66;
            this.lblAcao.Text = "-";
            // 
            // listtipo
            // 
            this.listtipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listtipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listtipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listtipo.BackColor = System.Drawing.Color.MintCream;
            this.listtipo.Cursor = System.Windows.Forms.Cursors.Default;
            this.listtipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listtipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listtipo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listtipo.FormattingEnabled = true;
            this.listtipo.Location = new System.Drawing.Point(621, 427);
            this.listtipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listtipo.Name = "listtipo";
            this.listtipo.Size = new System.Drawing.Size(148, 27);
            this.listtipo.TabIndex = 67;
            // 
            // lblNcm
            // 
            this.lblNcm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNcm.AutoSize = true;
            this.lblNcm.Depth = 0;
            this.lblNcm.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNcm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNcm.Location = new System.Drawing.Point(526, 346);
            this.lblNcm.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNcm.Name = "lblNcm";
            this.lblNcm.Size = new System.Drawing.Size(41, 19);
            this.lblNcm.TabIndex = 68;
            this.lblNcm.Text = "Ncm";
            // 
            // txtNcm
            // 
            this.txtNcm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNcm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNcm.Depth = 0;
            this.txtNcm.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNcm.Hint = "";
            this.txtNcm.Location = new System.Drawing.Point(527, 369);
            this.txtNcm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNcm.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNcm.Name = "txtNcm";
            this.txtNcm.PasswordChar = '\0';
            this.txtNcm.SelectedText = "";
            this.txtNcm.SelectionLength = 0;
            this.txtNcm.SelectionStart = 0;
            this.txtNcm.Size = new System.Drawing.Size(88, 23);
            this.txtNcm.TabIndex = 69;
            this.txtNcm.TabStop = false;
            this.txtNcm.UseSystemPasswordChar = false;
            // 
            // lblLocal
            // 
            this.lblLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocal.AutoSize = true;
            this.lblLocal.Depth = 0;
            this.lblLocal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLocal.Location = new System.Drawing.Point(245, 459);
            this.lblLocal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(46, 19);
            this.lblLocal.TabIndex = 70;
            this.lblLocal.Text = "Local";
            // 
            // txtLocal
            // 
            this.txtLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLocal.Depth = 0;
            this.txtLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.Hint = "";
            this.txtLocal.Location = new System.Drawing.Point(248, 480);
            this.txtLocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.PasswordChar = '\0';
            this.txtLocal.SelectedText = "";
            this.txtLocal.SelectionLength = 0;
            this.txtLocal.SelectionStart = 0;
            this.txtLocal.Size = new System.Drawing.Size(236, 23);
            this.txtLocal.TabIndex = 71;
            this.txtLocal.TabStop = false;
            this.txtLocal.UseSystemPasswordChar = false;
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaldo.Depth = 0;
            this.lblSaldo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSaldo.Location = new System.Drawing.Point(10, 459);
            this.lblSaldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(47, 19);
            this.lblSaldo.TabIndex = 72;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaldo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSaldo.Depth = 0;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Hint = "";
            this.txtSaldo.Location = new System.Drawing.Point(14, 480);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSaldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.PasswordChar = '\0';
            this.txtSaldo.SelectedText = "";
            this.txtSaldo.SelectionLength = 0;
            this.txtSaldo.SelectionStart = 0;
            this.txtSaldo.Size = new System.Drawing.Size(75, 23);
            this.txtSaldo.TabIndex = 73;
            this.txtSaldo.TabStop = false;
            this.txtSaldo.UseSystemPasswordChar = false;
            // 
            // lblSku
            // 
            this.lblSku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSku.AutoSize = true;
            this.lblSku.Depth = 0;
            this.lblSku.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSku.Location = new System.Drawing.Point(90, 459);
            this.lblSku.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSku.Name = "lblSku";
            this.lblSku.Size = new System.Drawing.Size(34, 19);
            this.lblSku.TabIndex = 74;
            this.lblSku.Text = "Sku";
            // 
            // txtSku
            // 
            this.txtSku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSku.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSku.Depth = 0;
            this.txtSku.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSku.Hint = "";
            this.txtSku.Location = new System.Drawing.Point(94, 480);
            this.txtSku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSku.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSku.Name = "txtSku";
            this.txtSku.PasswordChar = '\0';
            this.txtSku.SelectedText = "";
            this.txtSku.SelectionLength = 0;
            this.txtSku.SelectionStart = 0;
            this.txtSku.Size = new System.Drawing.Size(141, 23);
            this.txtSku.TabIndex = 75;
            this.txtSku.TabStop = false;
            this.txtSku.UseSystemPasswordChar = false;
            // 
            // dgProduto1
            // 
            this.dgProduto1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProduto1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto1.Location = new System.Drawing.Point(9, 100);
            this.dgProduto1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgProduto1.Name = "dgProduto1";
            this.dgProduto1.RowHeadersVisible = false;
            this.dgProduto1.RowHeadersWidth = 51;
            this.dgProduto1.RowTemplate.Height = 24;
            this.dgProduto1.Size = new System.Drawing.Size(768, 224);
            this.dgProduto1.TabIndex = 76;
            this.dgProduto1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduto_CellDoubleClick);
            // 
            // txtCod_barra
            // 
            this.txtCod_barra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCod_barra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCod_barra.Depth = 0;
            this.txtCod_barra.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod_barra.Hint = "";
            this.txtCod_barra.Location = new System.Drawing.Point(621, 369);
            this.txtCod_barra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCod_barra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCod_barra.Name = "txtCod_barra";
            this.txtCod_barra.PasswordChar = '\0';
            this.txtCod_barra.SelectedText = "";
            this.txtCod_barra.SelectionLength = 0;
            this.txtCod_barra.SelectionStart = 0;
            this.txtCod_barra.Size = new System.Drawing.Size(152, 23);
            this.txtCod_barra.TabIndex = 61;
            this.txtCod_barra.TabStop = false;
            this.txtCod_barra.UseSystemPasswordChar = false;
            // 
            // lblFamilia
            // 
            this.lblFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Depth = 0;
            this.lblFamilia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFamilia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFamilia.Location = new System.Drawing.Point(625, 405);
            this.lblFamilia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(58, 19);
            this.lblFamilia.TabIndex = 77;
            this.lblFamilia.Text = "Familia";
            // 
            // Form_CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.dgProduto1);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.lblSku);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.txtNcm);
            this.Controls.Add(this.lblNcm);
            this.Controls.Add(this.listtipo);
            this.Controls.Add(this.lblAcao);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCod_barra);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.lblCod_barra);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblDescricao);
            this.KeyPreview = true;
            this.Name = "Form_CadastroProduto";
            this.Text = "Cadastro de produto";
            this.Load += new System.EventHandler(this.Form_CadastroProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_CadastroProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblDescricao;
        private MaterialSkin.Controls.MaterialLabel lblPreco;
        private MaterialSkin.Controls.MaterialLabel lblCod_barra;
        private MaterialSkin.Controls.MaterialLabel lblObs;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescricao;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFornecedor;
        private MaterialSkin.Controls.MaterialLabel lblFornecedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPreco;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtObs;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisa;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblAcao;
        private System.Windows.Forms.ComboBox listtipo;
        private MaterialSkin.Controls.MaterialLabel lblNcm;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNcm;
        private MaterialSkin.Controls.MaterialLabel lblLocal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLocal;
        private MaterialSkin.Controls.MaterialLabel lblSaldo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSaldo;
        private MaterialSkin.Controls.MaterialLabel lblSku;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSku;
        private System.Windows.Forms.DataGridView dgProduto1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCod_barra;
        private MaterialSkin.Controls.MaterialLabel lblFamilia;
    }
}