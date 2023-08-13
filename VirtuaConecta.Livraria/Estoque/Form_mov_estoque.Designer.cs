
namespace VirtuaConecta.Outbound.AI.Estoque
{
    partial class Form_mov_estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mov_estoque));
            this.txtPesquisarProduto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgMovEstoque = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPickerFim = new System.Windows.Forms.DateTimePicker();
            this.dtPickerIni = new System.Windows.Forms.DateTimePicker();
            this.btnGerarReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisarProduto
            // 
            this.txtPesquisarProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPesquisarProduto.Depth = 0;
            this.txtPesquisarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarProduto.Hint = "";
            this.txtPesquisarProduto.Location = new System.Drawing.Point(95, 91);
            this.txtPesquisarProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisarProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisarProduto.Name = "txtPesquisarProduto";
            this.txtPesquisarProduto.PasswordChar = '\0';
            this.txtPesquisarProduto.SelectedText = "";
            this.txtPesquisarProduto.SelectionLength = 0;
            this.txtPesquisarProduto.SelectionStart = 0;
            this.txtPesquisarProduto.Size = new System.Drawing.Size(243, 28);
            this.txtPesquisarProduto.TabIndex = 51;
            this.txtPesquisarProduto.TabStop = false;
            this.txtPesquisarProduto.UseSystemPasswordChar = false;
            this.txtPesquisarProduto.TextChanged += new System.EventHandler(this.txtPesquisarProduto_TextChanged);
            // 
            // dgMovEstoque
            // 
            this.dgMovEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMovEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovEstoque.Location = new System.Drawing.Point(12, 137);
            this.dgMovEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgMovEstoque.Name = "dgMovEstoque";
            this.dgMovEstoque.RowHeadersVisible = false;
            this.dgMovEstoque.RowHeadersWidth = 51;
            this.dgMovEstoque.RowTemplate.Height = 24;
            this.dgMovEstoque.Size = new System.Drawing.Size(1108, 290);
            this.dgMovEstoque.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(908, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Data Final:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(669, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Data Inicial:";
            // 
            // dtPickerFim
            // 
            this.dtPickerFim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPickerFim.CustomFormat = "yyyy-MM-dd";
            this.dtPickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerFim.Location = new System.Drawing.Point(1005, 91);
            this.dtPickerFim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPickerFim.Name = "dtPickerFim";
            this.dtPickerFim.Size = new System.Drawing.Size(113, 22);
            this.dtPickerFim.TabIndex = 55;
            this.dtPickerFim.ValueChanged += new System.EventHandler(this.dtPickerFim_ValueChanged);
            // 
            // dtPickerIni
            // 
            this.dtPickerIni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPickerIni.CustomFormat = "yyyy-MM-dd";
            this.dtPickerIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerIni.Location = new System.Drawing.Point(776, 91);
            this.dtPickerIni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPickerIni.Name = "dtPickerIni";
            this.dtPickerIni.Size = new System.Drawing.Size(113, 22);
            this.dtPickerIni.TabIndex = 54;
            this.dtPickerIni.ValueChanged += new System.EventHandler(this.dtPickerIni_ValueChanged);
            // 
            // btnGerarReport
            // 
            this.btnGerarReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGerarReport.BackgroundImage")));
            this.btnGerarReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGerarReport.Location = new System.Drawing.Point(1077, 592);
            this.btnGerarReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerarReport.Name = "btnGerarReport";
            this.btnGerarReport.Size = new System.Drawing.Size(43, 39);
            this.btnGerarReport.TabIndex = 53;
            this.btnGerarReport.UseVisualStyleBackColor = true;
            this.btnGerarReport.Click += new System.EventHandler(this.btnGerarReport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Produto:";
            // 
            // Form_mov_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 645);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPickerFim);
            this.Controls.Add(this.dtPickerIni);
            this.Controls.Add(this.btnGerarReport);
            this.Controls.Add(this.dgMovEstoque);
            this.Controls.Add(this.txtPesquisarProduto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_mov_estoque";
            this.Text = "Movimentação de produtos";
            this.Load += new System.EventHandler(this.Form_mov_estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMovEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisarProduto;
        private System.Windows.Forms.DataGridView dgMovEstoque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPickerFim;
        private System.Windows.Forms.DateTimePicker dtPickerIni;
        private System.Windows.Forms.Button btnGerarReport;
        private System.Windows.Forms.Label label3;
    }
}