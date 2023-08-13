namespace VirtuaConecta.Outbound.AI.Pagamento
{
    partial class Form_CadastrarFormaPagamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CadastrarFormaPagamento));
            this.txtGrupo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblGrupo = new MaterialSkin.Controls.MaterialLabel();
            this.txtForma = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblForma = new MaterialSkin.Controls.MaterialLabel();
            this.txtPesquisarForma = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblPesquisar = new MaterialSkin.Controls.MaterialLabel();
            this.dgForma = new System.Windows.Forms.DataGridView();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgForma)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGrupo
            // 
            this.txtGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrupo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGrupo.Depth = 0;
            this.txtGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupo.Hint = "";
            this.txtGrupo.Location = new System.Drawing.Point(497, 320);
            this.txtGrupo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.PasswordChar = '\0';
            this.txtGrupo.SelectedText = "";
            this.txtGrupo.SelectionLength = 0;
            this.txtGrupo.SelectionStart = 0;
            this.txtGrupo.Size = new System.Drawing.Size(261, 23);
            this.txtGrupo.TabIndex = 93;
            this.txtGrupo.TabStop = false;
            this.txtGrupo.UseSystemPasswordChar = false;
            // 
            // lblGrupo
            // 
            this.lblGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGrupo.Depth = 0;
            this.lblGrupo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGrupo.Location = new System.Drawing.Point(493, 297);
            this.lblGrupo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(49, 19);
            this.lblGrupo.TabIndex = 92;
            this.lblGrupo.Text = "Grupo";
            // 
            // txtForma
            // 
            this.txtForma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtForma.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtForma.Depth = 0;
            this.txtForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForma.Hint = "";
            this.txtForma.Location = new System.Drawing.Point(9, 320);
            this.txtForma.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtForma.Name = "txtForma";
            this.txtForma.PasswordChar = '\0';
            this.txtForma.SelectedText = "";
            this.txtForma.SelectionLength = 0;
            this.txtForma.SelectionStart = 0;
            this.txtForma.Size = new System.Drawing.Size(216, 23);
            this.txtForma.TabIndex = 91;
            this.txtForma.TabStop = false;
            this.txtForma.UseSystemPasswordChar = false;
            // 
            // lblForma
            // 
            this.lblForma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblForma.AutoSize = true;
            this.lblForma.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForma.Depth = 0;
            this.lblForma.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblForma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblForma.Location = new System.Drawing.Point(5, 298);
            this.lblForma.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(151, 19);
            this.lblForma.TabIndex = 90;
            this.lblForma.Text = "Forma de pagamento";
            // 
            // txtPesquisarForma
            // 
            this.txtPesquisarForma.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPesquisarForma.Depth = 0;
            this.txtPesquisarForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarForma.Hint = "";
            this.txtPesquisarForma.Location = new System.Drawing.Point(231, 66);
            this.txtPesquisarForma.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisarForma.Name = "txtPesquisarForma";
            this.txtPesquisarForma.PasswordChar = '\0';
            this.txtPesquisarForma.SelectedText = "";
            this.txtPesquisarForma.SelectionLength = 0;
            this.txtPesquisarForma.SelectionStart = 0;
            this.txtPesquisarForma.Size = new System.Drawing.Size(193, 23);
            this.txtPesquisarForma.TabIndex = 89;
            this.txtPesquisarForma.TabStop = false;
            this.txtPesquisarForma.UseSystemPasswordChar = false;
            this.txtPesquisarForma.TextChanged += new System.EventHandler(this.txtPesquisarForma_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPesquisar.Depth = 0;
            this.lblPesquisar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPesquisar.Location = new System.Drawing.Point(6, 66);
            this.lblPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(219, 19);
            this.lblPesquisar.TabIndex = 88;
            this.lblPesquisar.Text = "Pesquisar forma de pagamento";
            // 
            // dgForma
            // 
            this.dgForma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgForma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgForma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgForma.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgForma.Location = new System.Drawing.Point(12, 92);
            this.dgForma.Name = "dgForma";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgForma.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgForma.RowHeadersVisible = false;
            this.dgForma.RowHeadersWidth = 51;
            this.dgForma.Size = new System.Drawing.Size(776, 119);
            this.dgForma.TabIndex = 87;
            this.dgForma.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgForma_CellDoubleClick);
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
            this.btnLimpa.Location = new System.Drawing.Point(674, 377);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(51, 61);
            this.btnLimpa.TabIndex = 95;
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
            this.btnConfirmar.Location = new System.Drawing.Point(742, 377);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(46, 61);
            this.btnConfirmar.TabIndex = 94;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Form_CadastrarFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.txtForma);
            this.Controls.Add(this.lblForma);
            this.Controls.Add(this.txtPesquisarForma);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.dgForma);
            this.Name = "Form_CadastrarFormaPagamento";
            this.Text = "Cadastrar forma de pagamento";
            this.Load += new System.EventHandler(this.Form_CadastrarFormaPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgForma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtGrupo;
        private MaterialSkin.Controls.MaterialLabel lblGrupo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtForma;
        private MaterialSkin.Controls.MaterialLabel lblForma;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisarForma;
        private MaterialSkin.Controls.MaterialLabel lblPesquisar;
        private System.Windows.Forms.DataGridView dgForma;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnConfirmar;
    }
}