
namespace VirtuaConecta.Outbound.AI.Relatorios
{
    partial class Form_rel_mov_estoque
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
            this.components = new System.ComponentModel.Container();
            this.MovEstoqueDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer_mov_estoque = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.MovEstoqueDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer_mov_estoque
            // 
            this.reportViewer_mov_estoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer_mov_estoque.LocalReport.ReportEmbeddedResource = "VirtuaConecta.Outbound.AI.Relatorios.Report2.rdlc";
            this.reportViewer_mov_estoque.Location = new System.Drawing.Point(12, 75);
            this.reportViewer_mov_estoque.Name = "reportViewer_mov_estoque";
            this.reportViewer_mov_estoque.ServerReport.BearerToken = null;
            this.reportViewer_mov_estoque.Size = new System.Drawing.Size(1251, 588);
            this.reportViewer_mov_estoque.TabIndex = 0;
            // 
            // Form_rel_mov_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 689);
            this.Controls.Add(this.reportViewer_mov_estoque);
            this.Name = "Form_rel_mov_estoque";
            this.Text = "Movimentação de estaque";
            this.Load += new System.EventHandler(this.Form_rel_mov_estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovEstoqueDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource MovEstoqueDTOBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_mov_estoque;
    }
}