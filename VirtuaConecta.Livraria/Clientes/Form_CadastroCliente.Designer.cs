namespace VirtuaConecta.Outbound.AI.Clientes
{
    partial class Form_CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CadastroCliente));
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.lblNome = new MaterialSkin.Controls.MaterialLabel();
            this.lblEnd = new MaterialSkin.Controls.MaterialLabel();
            this.lblBairro = new MaterialSkin.Controls.MaterialLabel();
            this.lblData = new MaterialSkin.Controls.MaterialLabel();
            this.lblContri = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblCidade = new MaterialSkin.Controls.MaterialLabel();
            this.lblNum = new MaterialSkin.Controls.MaterialLabel();
            this.lblTelefone = new MaterialSkin.Controls.MaterialLabel();
            this.lblCPF = new MaterialSkin.Controls.MaterialLabel();
            this.lbPesquisar = new MaterialSkin.Controls.MaterialLabel();
            this.txtPesquisarCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnPesquisaHistorico = new System.Windows.Forms.Button();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEnd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCPF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCidade = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBairro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContri = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtData = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCep = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCep = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscaCep = new VirtuaConecta.Outbound.AI.VirtuaButton();
            this.txtUf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblUf = new MaterialSkin.Controls.MaterialLabel();
            this.btnLimpa = new VirtuaConecta.Outbound.AI.VirtuaButton();
            this.btnConfirmar = new VirtuaConecta.Outbound.AI.VirtuaButton();
            this.btnHistorico = new VirtuaConecta.Outbound.AI.VirtuaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCliente
            // 
            this.dgCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Location = new System.Drawing.Point(16, 126);
            this.dgCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.RowHeadersVisible = false;
            this.dgCliente.RowHeadersWidth = 51;
            this.dgCliente.Size = new System.Drawing.Size(1045, 178);
            this.dgCliente.TabIndex = 0;
            this.dgCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellDoubleClick);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Depth = 0;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(11, 315);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 24);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnd.Depth = 0;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEnd.Location = new System.Drawing.Point(315, 378);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(94, 24);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "Endereço";
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBairro.Depth = 0;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBairro.Location = new System.Drawing.Point(8, 445);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(59, 24);
            this.lblBairro.TabIndex = 3;
            this.lblBairro.Text = "Bairro";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblData.Depth = 0;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblData.Location = new System.Drawing.Point(505, 514);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(181, 24);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data da contribuição";
            // 
            // lblContri
            // 
            this.lblContri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblContri.AutoSize = true;
            this.lblContri.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContri.Depth = 0;
            this.lblContri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblContri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblContri.Location = new System.Drawing.Point(313, 514);
            this.lblContri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContri.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContri.Name = "lblContri";
            this.lblContri.Size = new System.Drawing.Size(182, 24);
            this.lblContri.TabIndex = 5;
            this.lblContri.Text = "Contribuição mensal";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(9, 514);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCidade.Depth = 0;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCidade.Location = new System.Drawing.Point(214, 445);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(70, 24);
            this.lblCidade.TabIndex = 7;
            this.lblCidade.Text = "Cidade";
            // 
            // lblNum
            // 
            this.lblNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNum.Depth = 0;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNum.Location = new System.Drawing.Point(839, 378);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(31, 24);
            this.lblNum.TabIndex = 8;
            this.lblNum.Text = "Nº";
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTelefone.Depth = 0;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelefone.Location = new System.Drawing.Point(859, 445);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(85, 24);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCPF.Depth = 0;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCPF.Location = new System.Drawing.Point(621, 445);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(47, 24);
            this.lblCPF.TabIndex = 10;
            this.lblCPF.Text = "CPF";
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPesquisar.Depth = 0;
            this.lbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPesquisar.Location = new System.Drawing.Point(16, 90);
            this.lbPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(156, 24);
            this.lbPesquisar.TabIndex = 39;
            this.lbPesquisar.Text = "Pesquisar Cliente";
            // 
            // txtPesquisarCliente
            // 
            this.txtPesquisarCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPesquisarCliente.Depth = 0;
            this.txtPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarCliente.Hint = "";
            this.txtPesquisarCliente.Location = new System.Drawing.Point(217, 90);
            this.txtPesquisarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisarCliente.Name = "txtPesquisarCliente";
            this.txtPesquisarCliente.PasswordChar = '\0';
            this.txtPesquisarCliente.SelectedText = "";
            this.txtPesquisarCliente.SelectionLength = 0;
            this.txtPesquisarCliente.SelectionStart = 0;
            this.txtPesquisarCliente.Size = new System.Drawing.Size(316, 28);
            this.txtPesquisarCliente.TabIndex = 40;
            this.txtPesquisarCliente.TabStop = false;
            this.txtPesquisarCliente.UseSystemPasswordChar = false;
            this.txtPesquisarCliente.TextChanged += new System.EventHandler(this.txtPesquisarCliente_TextChanged);
            // 
            // btnPesquisaHistorico
            // 
            this.btnPesquisaHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisaHistorico.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisaHistorico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisaHistorico.BackgroundImage")));
            this.btnPesquisaHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisaHistorico.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisaHistorico.FlatAppearance.BorderSize = 0;
            this.btnPesquisaHistorico.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisaHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisaHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaHistorico.Location = new System.Drawing.Point(1989, 1412);
            this.btnPesquisaHistorico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisaHistorico.Name = "btnPesquisaHistorico";
            this.btnPesquisaHistorico.Size = new System.Drawing.Size(133, 95);
            this.btnPesquisaHistorico.TabIndex = 41;
            this.btnPesquisaHistorico.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(11, 545);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(287, 28);
            this.txtEmail.TabIndex = 42;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtNum
            // 
            this.txtNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNum.Depth = 0;
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Hint = "";
            this.txtNum.Location = new System.Drawing.Point(843, 406);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNum.Name = "txtNum";
            this.txtNum.PasswordChar = '\0';
            this.txtNum.SelectedText = "";
            this.txtNum.SelectionLength = 0;
            this.txtNum.SelectionStart = 0;
            this.txtNum.Size = new System.Drawing.Size(117, 28);
            this.txtNum.TabIndex = 43;
            this.txtNum.TabStop = false;
            this.txtNum.UseSystemPasswordChar = false;
            // 
            // txtEnd
            // 
            this.txtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEnd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEnd.Depth = 0;
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Hint = "";
            this.txtEnd.Location = new System.Drawing.Point(319, 406);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.PasswordChar = '\0';
            this.txtEnd.SelectedText = "";
            this.txtEnd.SelectionLength = 0;
            this.txtEnd.SelectionStart = 0;
            this.txtEnd.Size = new System.Drawing.Size(489, 28);
            this.txtEnd.TabIndex = 44;
            this.txtEnd.TabStop = false;
            this.txtEnd.UseSystemPasswordChar = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTelefone.Depth = 0;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Hint = "";
            this.txtTelefone.Location = new System.Drawing.Point(863, 472);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.Size = new System.Drawing.Size(179, 28);
            this.txtTelefone.TabIndex = 45;
            this.txtTelefone.TabStop = false;
            this.txtTelefone.UseSystemPasswordChar = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPF.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCPF.Depth = 0;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.txtCPF.Hint = "";
            this.txtCPF.Location = new System.Drawing.Point(634, 472);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCPF.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.SelectedText = "";
            this.txtCPF.SelectionLength = 0;
            this.txtCPF.SelectionStart = 0;
            this.txtCPF.Size = new System.Drawing.Size(208, 28);
            this.txtCPF.TabIndex = 46;
            this.txtCPF.TabStop = false;
            this.txtCPF.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(9, 343);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(397, 28);
            this.txtNome.TabIndex = 47;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCidade.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCidade.Depth = 0;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Hint = "";
            this.txtCidade.Location = new System.Drawing.Point(218, 472);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.Size = new System.Drawing.Size(266, 28);
            this.txtCidade.TabIndex = 48;
            this.txtCidade.TabStop = false;
            this.txtCidade.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBairro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBairro.Depth = 0;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Hint = "";
            this.txtBairro.Location = new System.Drawing.Point(15, 473);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBairro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.Size = new System.Drawing.Size(179, 28);
            this.txtBairro.TabIndex = 49;
            this.txtBairro.TabStop = false;
            this.txtBairro.UseSystemPasswordChar = false;
            // 
            // txtContri
            // 
            this.txtContri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtContri.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtContri.Depth = 0;
            this.txtContri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContri.Hint = "";
            this.txtContri.Location = new System.Drawing.Point(319, 545);
            this.txtContri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContri.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContri.Name = "txtContri";
            this.txtContri.PasswordChar = '\0';
            this.txtContri.SelectedText = "";
            this.txtContri.SelectionLength = 0;
            this.txtContri.SelectionStart = 0;
            this.txtContri.Size = new System.Drawing.Size(171, 28);
            this.txtContri.TabIndex = 50;
            this.txtContri.TabStop = false;
            this.txtContri.UseSystemPasswordChar = false;
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtData.Depth = 0;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Hint = "";
            this.txtData.Location = new System.Drawing.Point(511, 545);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtData.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.SelectedText = "";
            this.txtData.SelectionLength = 0;
            this.txtData.SelectionStart = 0;
            this.txtData.Size = new System.Drawing.Size(180, 28);
            this.txtData.TabIndex = 51;
            this.txtData.TabStop = false;
            this.txtData.UseSystemPasswordChar = false;
            // 
            // txtCep
            // 
            this.txtCep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCep.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCep.Depth = 0;
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Hint = "";
            this.txtCep.Location = new System.Drawing.Point(15, 406);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4);
            this.txtCep.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCep.Name = "txtCep";
            this.txtCep.PasswordChar = '\0';
            this.txtCep.SelectedText = "";
            this.txtCep.SelectionLength = 0;
            this.txtCep.SelectionStart = 0;
            this.txtCep.Size = new System.Drawing.Size(192, 28);
            this.txtCep.TabIndex = 54;
            this.txtCep.TabStop = false;
            this.txtCep.UseSystemPasswordChar = false;
            // 
            // lblCep
            // 
            this.lblCep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCep.AutoSize = true;
            this.lblCep.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCep.Depth = 0;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCep.Location = new System.Drawing.Point(9, 379);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(45, 24);
            this.lblCep.TabIndex = 53;
            this.lblCep.Text = "Cep";
            // 
            // btnBuscaCep
            // 
            this.btnBuscaCep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscaCep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaCep.BackgroundImage")));
            this.btnBuscaCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscaCep.BorderThickness = 0F;
            this.btnBuscaCep.Location = new System.Drawing.Point(217, 406);
            this.btnBuscaCep.Name = "btnBuscaCep";
            this.btnBuscaCep.Size = new System.Drawing.Size(29, 28);
            this.btnBuscaCep.TabIndex = 55;
            this.btnBuscaCep.Click += new System.EventHandler(this.btnBuscaCep_Click);
            // 
            // txtUf
            // 
            this.txtUf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUf.Depth = 0;
            this.txtUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUf.Hint = "";
            this.txtUf.Location = new System.Drawing.Point(509, 473);
            this.txtUf.Margin = new System.Windows.Forms.Padding(4);
            this.txtUf.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUf.Name = "txtUf";
            this.txtUf.PasswordChar = '\0';
            this.txtUf.SelectedText = "";
            this.txtUf.SelectionLength = 0;
            this.txtUf.SelectionStart = 0;
            this.txtUf.Size = new System.Drawing.Size(74, 28);
            this.txtUf.TabIndex = 57;
            this.txtUf.TabStop = false;
            this.txtUf.UseSystemPasswordChar = false;
            // 
            // lblUf
            // 
            this.lblUf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUf.AutoSize = true;
            this.lblUf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUf.Depth = 0;
            this.lblUf.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUf.Location = new System.Drawing.Point(505, 446);
            this.lblUf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUf.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(29, 24);
            this.lblUf.TabIndex = 56;
            this.lblUf.Text = "Uf";
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpa.BackgroundImage")));
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpa.BorderThickness = 0F;
            this.btnLimpa.Location = new System.Drawing.Point(885, 527);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 66);
            this.btnLimpa.TabIndex = 58;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.BackgroundImage")));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmar.BorderThickness = 0F;
            this.btnConfirmar.Location = new System.Drawing.Point(986, 527);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 66);
            this.btnConfirmar.TabIndex = 59;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistorico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistorico.BackgroundImage")));
            this.btnHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHistorico.BorderThickness = 0F;
            this.btnHistorico.Location = new System.Drawing.Point(1009, 82);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(42, 37);
            this.btnHistorico.TabIndex = 60;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            this.btnHistorico.MouseHover += new System.EventHandler(this.btnHistorico_MouseHover_1);
            // 
            // Form_CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1104, 628);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.btnBuscaCep);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtContri);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnPesquisaHistorico);
            this.Controls.Add(this.txtPesquisarCliente);
            this.Controls.Add(this.lbPesquisar);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblContri);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.Form_CadastroCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_CadastroCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCliente;
        private MaterialSkin.Controls.MaterialLabel lblNome;
        private MaterialSkin.Controls.MaterialLabel lblEnd;
        private MaterialSkin.Controls.MaterialLabel lblBairro;
        private MaterialSkin.Controls.MaterialLabel lblData;
        private MaterialSkin.Controls.MaterialLabel lblContri;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialLabel lblCidade;
        private MaterialSkin.Controls.MaterialLabel lblNum;
        private MaterialSkin.Controls.MaterialLabel lblTelefone;
        private MaterialSkin.Controls.MaterialLabel lblCPF;
        private MaterialSkin.Controls.MaterialLabel lbPesquisar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisarCliente;
        private System.Windows.Forms.Button btnPesquisaHistorico;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNum;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEnd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefone;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCPF;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCidade;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBairro;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContri;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtData;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCep;
        private MaterialSkin.Controls.MaterialLabel lblCep;
        private VirtuaButton btnBuscaCep;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUf;
        private MaterialSkin.Controls.MaterialLabel lblUf;
        private VirtuaButton btnLimpa;
        private VirtuaButton btnConfirmar;
        private VirtuaButton btnHistorico;
    }
}