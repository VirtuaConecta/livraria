
namespace VirtuaConecta.Livraria.Caixa
{
    partial class Form_caixa1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_caixa1));
            this.mtxtCodProduto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPEsquisaProduto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.dgprodutos = new System.Windows.Forms.DataGridView();
            this.dgCaixa = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltroco = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtentregue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listforma = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcompra = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgprodutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCaixa)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxtCodProduto
            // 
            this.mtxtCodProduto.Depth = 0;
            this.mtxtCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCodProduto.Hint = "";
            this.mtxtCodProduto.Location = new System.Drawing.Point(12, 84);
            this.mtxtCodProduto.Margin = new System.Windows.Forms.Padding(3, 50, 3, 2);
            this.mtxtCodProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtxtCodProduto.Name = "mtxtCodProduto";
            this.mtxtCodProduto.PasswordChar = '\0';
            this.mtxtCodProduto.SelectedText = "";
            this.mtxtCodProduto.SelectionLength = 0;
            this.mtxtCodProduto.SelectionStart = 0;
            this.mtxtCodProduto.Size = new System.Drawing.Size(523, 28);
            this.mtxtCodProduto.TabIndex = 1;
            this.mtxtCodProduto.TabStop = false;
            this.mtxtCodProduto.UseSystemPasswordChar = false;
            // 
            // txtPEsquisaProduto
            // 
            this.txtPEsquisaProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPEsquisaProduto.Depth = 0;
            this.txtPEsquisaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPEsquisaProduto.Hint = "";
            this.txtPEsquisaProduto.Location = new System.Drawing.Point(253, 10);
            this.txtPEsquisaProduto.Margin = new System.Windows.Forms.Padding(3, 50, 3, 2);
            this.txtPEsquisaProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPEsquisaProduto.Name = "txtPEsquisaProduto";
            this.txtPEsquisaProduto.PasswordChar = '\0';
            this.txtPEsquisaProduto.SelectedText = "";
            this.txtPEsquisaProduto.SelectionLength = 0;
            this.txtPEsquisaProduto.SelectionStart = 0;
            this.txtPEsquisaProduto.Size = new System.Drawing.Size(256, 28);
            this.txtPEsquisaProduto.TabIndex = 2;
            this.txtPEsquisaProduto.TabStop = false;
            this.txtPEsquisaProduto.UseSystemPasswordChar = false;
            this.txtPEsquisaProduto.TextChanged += new System.EventHandler(this.txtPEsquisaProduto_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Pesquisar produto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgprodutos
            // 
            this.dgprodutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgprodutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprodutos.Location = new System.Drawing.Point(1, -1);
            this.dgprodutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgprodutos.Name = "dgprodutos";
            this.dgprodutos.RowHeadersVisible = false;
            this.dgprodutos.RowHeadersWidth = 51;
            this.dgprodutos.RowTemplate.Height = 24;
            this.dgprodutos.Size = new System.Drawing.Size(525, 248);
            this.dgprodutos.TabIndex = 41;
            this.dgprodutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgprodutos_CellDoubleClick);
            // 
            // dgCaixa
            // 
            this.dgCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCaixa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCaixa.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgCaixa.Location = new System.Drawing.Point(4, 4);
            this.dgCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.dgCaixa.Name = "dgCaixa";
            this.dgCaixa.RowHeadersVisible = false;
            this.dgCaixa.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgCaixa.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgCaixa.RowTemplate.Height = 40;
            this.dgCaixa.Size = new System.Drawing.Size(522, 256);
            this.dgCaixa.TabIndex = 40;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(895, 612);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(115, 97);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPagar.BackgroundImage")));
            this.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPagar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Location = new System.Drawing.Point(1042, 612);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(115, 97);
            this.btnPagar.TabIndex = 7;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpf.BackColor = System.Drawing.Color.MintCream;
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(852, 488);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(184, 29);
            this.txtCpf.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(590, 488);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 58;
            this.label5.Text = "Cnpj/Cpf:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltroco
            // 
            this.lbltroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltroco.AutoSize = true;
            this.lbltroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltroco.Location = new System.Drawing.Point(842, 438);
            this.lbltroco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltroco.Name = "lbltroco";
            this.lbltroco.Size = new System.Drawing.Size(28, 29);
            this.lbltroco.TabIndex = 57;
            this.lbltroco.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(590, 438);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 56;
            this.label3.Text = "Troco: R$";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(842, 378);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(28, 29);
            this.lbltotal.TabIndex = 55;
            this.lbltotal.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(590, 378);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 29);
            this.label11.TabIndex = 54;
            this.label11.Text = "Total: R$";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtentregue
            // 
            this.txtentregue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtentregue.BackColor = System.Drawing.Color.MintCream;
            this.txtentregue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtentregue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtentregue.Location = new System.Drawing.Point(850, 310);
            this.txtentregue.Margin = new System.Windows.Forms.Padding(4);
            this.txtentregue.Name = "txtentregue";
            this.txtentregue.Size = new System.Drawing.Size(195, 29);
            this.txtentregue.TabIndex = 5;
            this.txtentregue.TextChanged += new System.EventHandler(this.txtentregue_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(593, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "Entregue: R$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtdesconto
            // 
            this.txtdesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdesconto.BackColor = System.Drawing.Color.MintCream;
            this.txtdesconto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesconto.Location = new System.Drawing.Point(849, 249);
            this.txtdesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(195, 29);
            this.txtdesconto.TabIndex = 4;
            this.txtdesconto.TextChanged += new System.EventHandler(this.txtdesconto_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(590, 246);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 29);
            this.label9.TabIndex = 50;
            this.label9.Text = "Desconto: %";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listforma
            // 
            this.listforma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listforma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listforma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listforma.BackColor = System.Drawing.Color.MintCream;
            this.listforma.Cursor = System.Windows.Forms.Cursors.Default;
            this.listforma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listforma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listforma.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listforma.FormattingEnabled = true;
            this.listforma.Location = new System.Drawing.Point(850, 182);
            this.listforma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listforma.Name = "listforma";
            this.listforma.Size = new System.Drawing.Size(263, 32);
            this.listforma.TabIndex = 3;
            this.listforma.SelectedIndexChanged += new System.EventHandler(this.listforma_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(593, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 48;
            this.label4.Text = "Forma Pagto:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblcompra
            // 
            this.lblcompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcompra.AutoSize = true;
            this.lblcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompra.Location = new System.Drawing.Point(845, 122);
            this.lblcompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcompra.Name = "lblcompra";
            this.lblcompra.Size = new System.Drawing.Size(66, 29);
            this.lblcompra.TabIndex = 47;
            this.lblcompra.Text = "0,00";
            this.lblcompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblcompra.TextChanged += new System.EventHandler(this.lblcompra_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(593, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 29);
            this.label8.TabIndex = 46;
            this.label8.Text = "Valor R$: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgCaixa);
            this.panel1.Location = new System.Drawing.Point(11, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 264);
            this.panel1.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPEsquisaProduto);
            this.panel2.Location = new System.Drawing.Point(12, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 50);
            this.panel2.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgprodutos);
            this.panel3.Location = new System.Drawing.Point(11, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 265);
            this.panel3.TabIndex = 64;
            // 
            // Form_caixa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1193, 722);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltroco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtentregue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listforma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblcompra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtxtCodProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_caixa1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.Form_caixa1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Caixa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgprodutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCaixa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField mtxtCodProduto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPEsquisaProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgprodutos;
        private System.Windows.Forms.DataGridView dgCaixa;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltroco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtentregue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox listforma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}