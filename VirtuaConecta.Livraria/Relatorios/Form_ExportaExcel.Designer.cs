namespace VirtuaConecta.Outbound.AI.Relatorios
{
    partial class Form_ExportaExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ExportaExcel));
            this.txtCaminhoArq = new System.Windows.Forms.TextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.btnGerarExcel = new System.Windows.Forms.Button();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // txtCaminhoArq
            // 
            this.txtCaminhoArq.Enabled = false;
            this.txtCaminhoArq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoArq.Location = new System.Drawing.Point(67, 163);
            this.txtCaminhoArq.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaminhoArq.Name = "txtCaminhoArq";
            this.txtCaminhoArq.Size = new System.Drawing.Size(460, 23);
            this.txtCaminhoArq.TabIndex = 24;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.ForeColor = System.Drawing.Color.White;
            this.btnLocalizar.Location = new System.Drawing.Point(553, 163);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(157, 29);
            this.btnLocalizar.TabIndex = 41;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.ForeColor = System.Drawing.Color.DarkGreen;
            this.label23.Location = new System.Drawing.Point(64, 144);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 13);
            this.label23.TabIndex = 75;
            this.label23.Text = "Local do Arquivo";
            // 
            // btnGerarExcel
            // 
            this.btnGerarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btnGerarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarExcel.ForeColor = System.Drawing.Color.White;
            this.btnGerarExcel.Location = new System.Drawing.Point(553, 228);
            this.btnGerarExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerarExcel.Name = "btnGerarExcel";
            this.btnGerarExcel.Size = new System.Drawing.Size(157, 29);
            this.btnGerarExcel.TabIndex = 76;
            this.btnGerarExcel.Text = "Gerar Excel";
            this.btnGerarExcel.UseVisualStyleBackColor = false;
            this.btnGerarExcel.Click += new System.EventHandler(this.btnGerarExcel_Click);
            // 
            // Form_ExportaExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 312);
            this.Controls.Add(this.btnGerarExcel);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.txtCaminhoArq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ExportaExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCaminhoArq;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnGerarExcel;
        private System.Windows.Forms.FolderBrowserDialog FBD;
    }
}