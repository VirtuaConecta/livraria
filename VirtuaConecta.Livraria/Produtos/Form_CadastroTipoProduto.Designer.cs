namespace VirtuaConecta.Outbound.AI.Produtos
{
    partial class Form_CadastroTipoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CadastroTipoProduto));
            this.dgTipo = new System.Windows.Forms.DataGridView();
            this.lbPesquisar = new MaterialSkin.Controls.MaterialLabel();
            this.lblTipo = new MaterialSkin.Controls.MaterialLabel();
            this.txtTipo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPesquisarTipo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTipo
            // 
            this.dgTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTipo.Location = new System.Drawing.Point(4, 111);
            this.dgTipo.Name = "dgTipo";
            this.dgTipo.RowHeadersVisible = false;
            this.dgTipo.RowHeadersWidth = 51;
            this.dgTipo.Size = new System.Drawing.Size(784, 167);
            this.dgTipo.TabIndex = 1;
            this.dgTipo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTipo_CellDoubleClick);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPesquisar.Depth = 0;
            this.lbPesquisar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPesquisar.Location = new System.Drawing.Point(12, 74);
            this.lbPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(110, 19);
            this.lbPesquisar.TabIndex = 40;
            this.lbPesquisar.Text = "Pesquisar Tipo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTipo.Depth = 0;
            this.lblTipo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipo.Location = new System.Drawing.Point(12, 301);
            this.lblTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(116, 19);
            this.lblTipo.TabIndex = 41;
            this.lblTipo.Text = "Tipo do produto";
            // 
            // txtTipo
            // 
            this.txtTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTipo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTipo.Depth = 0;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Hint = "";
            this.txtTipo.Location = new System.Drawing.Point(16, 336);
            this.txtTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.PasswordChar = '\0';
            this.txtTipo.SelectedText = "";
            this.txtTipo.SelectionLength = 0;
            this.txtTipo.SelectionStart = 0;
            this.txtTipo.Size = new System.Drawing.Size(298, 23);
            this.txtTipo.TabIndex = 48;
            this.txtTipo.TabStop = false;
            this.txtTipo.UseSystemPasswordChar = false;
            // 
            // txtPesquisarTipo
            // 
            this.txtPesquisarTipo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPesquisarTipo.Depth = 0;
            this.txtPesquisarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarTipo.Hint = "";
            this.txtPesquisarTipo.Location = new System.Drawing.Point(145, 74);
            this.txtPesquisarTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisarTipo.Name = "txtPesquisarTipo";
            this.txtPesquisarTipo.PasswordChar = '\0';
            this.txtPesquisarTipo.SelectedText = "";
            this.txtPesquisarTipo.SelectionLength = 0;
            this.txtPesquisarTipo.SelectionStart = 0;
            this.txtPesquisarTipo.Size = new System.Drawing.Size(237, 23);
            this.txtPesquisarTipo.TabIndex = 49;
            this.txtPesquisarTipo.TabStop = false;
            this.txtPesquisarTipo.UseSystemPasswordChar = false;
            this.txtPesquisarTipo.TextChanged += new System.EventHandler(this.txtPesquisarTipo_TextChanged);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpa.BackgroundImage")));
            this.btnLimpa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpa.FlatAppearance.BorderSize = 0;
            this.btnLimpa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpa.Location = new System.Drawing.Point(565, 361);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(100, 77);
            this.btnLimpa.TabIndex = 51;
            this.btnLimpa.UseVisualStyleBackColor = false;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
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
            this.btnConfirmar.Location = new System.Drawing.Point(688, 361);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 77);
            this.btnConfirmar.TabIndex = 50;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Form_CadastroTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtPesquisarTipo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lbPesquisar);
            this.Controls.Add(this.dgTipo);
            this.Name = "Form_CadastroTipoProduto";
            this.Text = "Cadastro tipo produto";
            this.Load += new System.EventHandler(this.Form_CadastroTipoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTipo;
        private MaterialSkin.Controls.MaterialLabel lbPesquisar;
        private MaterialSkin.Controls.MaterialLabel lblTipo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTipo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisarTipo;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnConfirmar;
    }
}