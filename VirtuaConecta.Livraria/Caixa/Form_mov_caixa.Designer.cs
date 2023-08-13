
namespace VirtuaConecta.Outbound.AI.Caixa
{
    partial class Form_mov_caixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mov_caixa));
            this.dg_caixa = new System.Windows.Forms.DataGridView();
            this.dg_MovCaixa = new System.Windows.Forms.DataGridView();
            this.lblStatusCaixa = new System.Windows.Forms.Label();
            this.txtTotalOp = new System.Windows.Forms.TextBox();
            this.cmbOperacoes = new System.Windows.Forms.ComboBox();
            this.btnImprimirFechamento = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblEntradas = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblSaidas = new MaterialSkin.Controls.MaterialLabel();
            this.lblSaldo = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lblNrOperacao = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTerminal = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dg_caixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_MovCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_caixa
            // 
            this.dg_caixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_caixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_caixa.Location = new System.Drawing.Point(15, 111);
            this.dg_caixa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dg_caixa.Name = "dg_caixa";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_caixa.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_caixa.RowHeadersVisible = false;
            this.dg_caixa.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_caixa.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_caixa.RowTemplate.Height = 24;
            this.dg_caixa.Size = new System.Drawing.Size(917, 141);
            this.dg_caixa.TabIndex = 0;
            // 
            // dg_MovCaixa
            // 
            this.dg_MovCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_MovCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_MovCaixa.Location = new System.Drawing.Point(15, 263);
            this.dg_MovCaixa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dg_MovCaixa.Name = "dg_MovCaixa";
            this.dg_MovCaixa.RowHeadersVisible = false;
            this.dg_MovCaixa.RowHeadersWidth = 51;
            this.dg_MovCaixa.RowTemplate.Height = 24;
            this.dg_MovCaixa.Size = new System.Drawing.Size(920, 240);
            this.dg_MovCaixa.TabIndex = 1;
            // 
            // lblStatusCaixa
            // 
            this.lblStatusCaixa.AutoSize = true;
            this.lblStatusCaixa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatusCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCaixa.ForeColor = System.Drawing.Color.Teal;
            this.lblStatusCaixa.Location = new System.Drawing.Point(182, 605);
            this.lblStatusCaixa.Name = "lblStatusCaixa";
            this.lblStatusCaixa.Size = new System.Drawing.Size(87, 18);
            this.lblStatusCaixa.TabIndex = 27;
            this.lblStatusCaixa.Text = "Operação:";
            // 
            // txtTotalOp
            // 
            this.txtTotalOp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOp.Location = new System.Drawing.Point(833, 523);
            this.txtTotalOp.Name = "txtTotalOp";
            this.txtTotalOp.Size = new System.Drawing.Size(100, 24);
            this.txtTotalOp.TabIndex = 23;
            this.txtTotalOp.Text = "0";
            // 
            // cmbOperacoes
            // 
            this.cmbOperacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOperacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperacoes.FormattingEnabled = true;
            this.cmbOperacoes.Items.AddRange(new object[] {
            "1-Abertura do Caixa",
            "2-Sangria de Caixa",
            "4-Reforço de Caixa",
            "3-Fechamento do Caixa"});
            this.cmbOperacoes.Location = new System.Drawing.Point(506, 524);
            this.cmbOperacoes.Name = "cmbOperacoes";
            this.cmbOperacoes.Size = new System.Drawing.Size(197, 24);
            this.cmbOperacoes.TabIndex = 21;
            // 
            // btnImprimirFechamento
            // 
            this.btnImprimirFechamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirFechamento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimirFechamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimirFechamento.BackgroundImage")));
            this.btnImprimirFechamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimirFechamento.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimirFechamento.FlatAppearance.BorderSize = 0;
            this.btnImprimirFechamento.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimirFechamento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimirFechamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirFechamento.Location = new System.Drawing.Point(702, 554);
            this.btnImprimirFechamento.Name = "btnImprimirFechamento";
            this.btnImprimirFechamento.Size = new System.Drawing.Size(100, 77);
            this.btnImprimirFechamento.TabIndex = 35;
            this.btnImprimirFechamento.UseVisualStyleBackColor = false;
            this.btnImprimirFechamento.Click += new System.EventHandler(this.btnImprimirFechamento_Click);
            this.btnImprimirFechamento.MouseHover += new System.EventHandler(this.btnImprimirFechamento_MouseHover);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(833, 554);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 77);
            this.btnSair.TabIndex = 34;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseHover += new System.EventHandler(this.btnSair_MouseHover);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.BackgroundImage")));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(556, 554);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 77);
            this.btnConfirmar.TabIndex = 36;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            this.btnConfirmar.MouseHover += new System.EventHandler(this.btnConfirmar_MouseHover);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(34, 525);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 19);
            this.materialLabel1.TabIndex = 37;
            this.materialLabel1.Text = "Entradas:  R$";
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEntradas.Depth = 0;
            this.lblEntradas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEntradas.Location = new System.Drawing.Point(182, 524);
            this.lblEntradas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntradas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(97, 19);
            this.lblEntradas.TabIndex = 38;
            this.lblEntradas.Text = "Entradas:  R$";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(394, 523);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(77, 19);
            this.materialLabel2.TabIndex = 39;
            this.materialLabel2.Text = "Operação:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(50, 551);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(83, 19);
            this.materialLabel3.TabIndex = 40;
            this.materialLabel3.Text = "Saidas:  R$";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(60, 579);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(73, 19);
            this.materialLabel4.TabIndex = 41;
            this.materialLabel4.Text = "Total:  R$";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(36, 607);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(97, 19);
            this.materialLabel5.TabIndex = 42;
            this.materialLabel5.Text = "Status Caixa:";
            // 
            // lblSaidas
            // 
            this.lblSaidas.AutoSize = true;
            this.lblSaidas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaidas.Depth = 0;
            this.lblSaidas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSaidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSaidas.Location = new System.Drawing.Point(185, 550);
            this.lblSaidas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaidas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSaidas.Name = "lblSaidas";
            this.lblSaidas.Size = new System.Drawing.Size(33, 19);
            this.lblSaidas.TabIndex = 43;
            this.lblSaidas.Text = "lbl2";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaldo.Depth = 0;
            this.lblSaldo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSaldo.Location = new System.Drawing.Point(185, 578);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(33, 19);
            this.lblSaldo.TabIndex = 44;
            this.lblSaldo.Text = "lbl3";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(776, 525);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(26, 19);
            this.materialLabel6.TabIndex = 45;
            this.materialLabel6.Text = "R$";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(21, 79);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(115, 19);
            this.materialLabel7.TabIndex = 46;
            this.materialLabel7.Text = "Usuario logado:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(182, 79);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(30, 19);
            this.lblUsuario.TabIndex = 47;
            this.lblUsuario.Text = "usr";
            // 
            // lblNrOperacao
            // 
            this.lblNrOperacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNrOperacao.AutoSize = true;
            this.lblNrOperacao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNrOperacao.Depth = 0;
            this.lblNrOperacao.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNrOperacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNrOperacao.Location = new System.Drawing.Point(536, 79);
            this.lblNrOperacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNrOperacao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNrOperacao.Name = "lblNrOperacao";
            this.lblNrOperacao.Size = new System.Drawing.Size(30, 19);
            this.lblNrOperacao.TabIndex = 49;
            this.lblNrOperacao.Text = "usr";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(394, 79);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(97, 19);
            this.materialLabel8.TabIndex = 48;
            this.materialLabel8.Text = "Operação Nr:";
            // 
            // lblTerminal
            // 
            this.lblTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTerminal.Depth = 0;
            this.lblTerminal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTerminal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTerminal.Location = new System.Drawing.Point(877, 79);
            this.lblTerminal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTerminal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(30, 19);
            this.lblTerminal.TabIndex = 51;
            this.lblTerminal.Text = "usr";
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(735, 79);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(92, 19);
            this.materialLabel9.TabIndex = 50;
            this.materialLabel9.Text = "Terminal Nr:";
            // 
            // Form_mov_caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.lblTerminal);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.lblNrOperacao);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblSaidas);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lblEntradas);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnImprimirFechamento);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblStatusCaixa);
            this.Controls.Add(this.txtTotalOp);
            this.Controls.Add(this.cmbOperacoes);
            this.Controls.Add(this.dg_MovCaixa);
            this.Controls.Add(this.dg_caixa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_mov_caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de caixa";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_mov_caixa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_mov_caixa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dg_caixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_MovCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_caixa;
        private System.Windows.Forms.DataGridView dg_MovCaixa;
        private System.Windows.Forms.Label lblStatusCaixa;
        private System.Windows.Forms.TextBox txtTotalOp;
        private System.Windows.Forms.ComboBox cmbOperacoes;
        private System.Windows.Forms.Button btnImprimirFechamento;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConfirmar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblEntradas;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lblSaidas;
        private MaterialSkin.Controls.MaterialLabel lblSaldo;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialLabel lblNrOperacao;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lblTerminal;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
    }
}