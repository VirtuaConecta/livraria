
namespace VirtuaConecta.Outbound.AI.Estoque
{
    partial class From_Entra_Manual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(From_Entra_Manual));
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNrNf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label14 = new System.Windows.Forms.Label();
            this.txtChaveNf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbListaFornecedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dg_itensProdutos = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnInserirproduto = new System.Windows.Forms.Button();
            this.dtEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerie = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dg_itensProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(389, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 79;
            this.label13.Text = "Data Nf";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(18, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 77;
            this.label12.Text = "Nr nf";
            // 
            // txtNrNf
            // 
            this.txtNrNf.Depth = 0;
            this.txtNrNf.Hint = "";
            this.txtNrNf.Location = new System.Drawing.Point(21, 117);
            this.txtNrNf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNrNf.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNrNf.Name = "txtNrNf";
            this.txtNrNf.PasswordChar = '\0';
            this.txtNrNf.SelectedText = "";
            this.txtNrNf.SelectionLength = 0;
            this.txtNrNf.SelectionStart = 0;
            this.txtNrNf.Size = new System.Drawing.Size(123, 28);
            this.txtNrNf.TabIndex = 76;
            this.txtNrNf.UseSystemPasswordChar = false;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(763, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 81;
            this.label14.Text = "Chave Nf";
            // 
            // txtChaveNf
            // 
            this.txtChaveNf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChaveNf.Depth = 0;
            this.txtChaveNf.Hint = "";
            this.txtChaveNf.Location = new System.Drawing.Point(767, 117);
            this.txtChaveNf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChaveNf.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtChaveNf.Name = "txtChaveNf";
            this.txtChaveNf.PasswordChar = '\0';
            this.txtChaveNf.SelectedText = "";
            this.txtChaveNf.SelectionLength = 0;
            this.txtChaveNf.SelectionStart = 0;
            this.txtChaveNf.Size = new System.Drawing.Size(472, 28);
            this.txtChaveNf.TabIndex = 80;
            this.txtChaveNf.UseSystemPasswordChar = false;
            // 
            // cmbListaFornecedor
            // 
            this.cmbListaFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbListaFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbListaFornecedor.BackColor = System.Drawing.Color.MintCream;
            this.cmbListaFornecedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbListaFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbListaFornecedor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbListaFornecedor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbListaFornecedor.FormattingEnabled = true;
            this.cmbListaFornecedor.Location = new System.Drawing.Point(21, 170);
            this.cmbListaFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbListaFornecedor.Name = "cmbListaFornecedor";
            this.cmbListaFornecedor.Size = new System.Drawing.Size(432, 27);
            this.cmbListaFornecedor.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(16, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "Fornecedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(17, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(939, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "Qtd";
            // 
            // txtQtd
            // 
            this.txtQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtd.Depth = 0;
            this.txtQtd.Hint = "";
            this.txtQtd.Location = new System.Drawing.Point(942, 246);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQtd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.PasswordChar = '\0';
            this.txtQtd.SelectedText = "";
            this.txtQtd.SelectionLength = 0;
            this.txtQtd.SelectionStart = 0;
            this.txtQtd.Size = new System.Drawing.Size(113, 28);
            this.txtQtd.TabIndex = 86;
            this.txtQtd.UseSystemPasswordChar = false;
            // 
            // dg_itensProdutos
            // 
            this.dg_itensProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_itensProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_itensProdutos.Location = new System.Drawing.Point(12, 465);
            this.dg_itensProdutos.Name = "dg_itensProdutos";
            this.dg_itensProdutos.RowHeadersVisible = false;
            this.dg_itensProdutos.RowHeadersWidth = 51;
            this.dg_itensProdutos.RowTemplate.Height = 24;
            this.dg_itensProdutos.Size = new System.Drawing.Size(1175, 150);
            this.dg_itensProdutos.TabIndex = 88;
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
            this.btnLimpar.Location = new System.Drawing.Point(990, 622);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 79);
            this.btnLimpar.TabIndex = 90;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
            this.btnCadastrar.Location = new System.Drawing.Point(1137, 625);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(91, 75);
            this.btnCadastrar.TabIndex = 89;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnInserirproduto
            // 
            this.btnInserirproduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserirproduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInserirproduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInserirproduto.BackgroundImage")));
            this.btnInserirproduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInserirproduto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInserirproduto.FlatAppearance.BorderSize = 0;
            this.btnInserirproduto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInserirproduto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInserirproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirproduto.Location = new System.Drawing.Point(1138, 241);
            this.btnInserirproduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserirproduto.Name = "btnInserirproduto";
            this.btnInserirproduto.Size = new System.Drawing.Size(30, 33);
            this.btnInserirproduto.TabIndex = 91;
            this.btnInserirproduto.UseVisualStyleBackColor = false;
            this.btnInserirproduto.Click += new System.EventHandler(this.btnInserirproduto_Click);
            this.btnInserirproduto.MouseEnter += new System.EventHandler(this.btnInserirproduto_MouseEnter);
            this.btnInserirproduto.MouseLeave += new System.EventHandler(this.btnInserirproduto_MouseLeave);
            this.btnInserirproduto.MouseHover += new System.EventHandler(this.btnInserirproduto_MouseHover);
            // 
            // dtEmissao
            // 
            this.dtEmissao.CustomFormat = "yyyy-MM-dd";
            this.dtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEmissao.Location = new System.Drawing.Point(392, 123);
            this.dtEmissao.Name = "dtEmissao";
            this.dtEmissao.Size = new System.Drawing.Size(200, 22);
            this.dtEmissao.TabIndex = 92;
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.Color.MintCream;
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProduto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(19, 254);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(402, 20);
            this.txtProduto.TabIndex = 93;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(19, 280);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(402, 100);
            this.listBox1.TabIndex = 94;
            this.listBox1.Visible = false;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(179, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 96;
            this.label4.Text = "Série";
            // 
            // txtSerie
            // 
            this.txtSerie.Depth = 0;
            this.txtSerie.Hint = "";
            this.txtSerie.Location = new System.Drawing.Point(182, 117);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerie.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.PasswordChar = '\0';
            this.txtSerie.SelectedText = "";
            this.txtSerie.SelectionLength = 0;
            this.txtSerie.SelectionStart = 0;
            this.txtSerie.Size = new System.Drawing.Size(54, 28);
            this.txtSerie.TabIndex = 95;
            this.txtSerie.UseSystemPasswordChar = false;
            // 
            // From_Entra_Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1251, 714);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.dtEmissao);
            this.Controls.Add(this.btnInserirproduto);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dg_itensProdutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbListaFornecedor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtChaveNf);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNrNf);
            this.Name = "From_Entra_Manual";
            this.Text = "Entrada de produtos Manual";
            this.Load += new System.EventHandler(this.From_Entra_Manual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_itensProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNrNf;
        private System.Windows.Forms.Label label14;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtChaveNf;
        private System.Windows.Forms.ComboBox cmbListaFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtQtd;
        private System.Windows.Forms.DataGridView dg_itensProdutos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnInserirproduto;
        private System.Windows.Forms.DateTimePicker dtEmissao;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSerie;
    }
}