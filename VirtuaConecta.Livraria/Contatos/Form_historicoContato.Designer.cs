namespace VirtuaConecta.Outbound.AI.Contatos
{
    partial class Form_historicoContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_historicoContato));
            this.dgHistorico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHistorico
            // 
            this.dgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorico.Location = new System.Drawing.Point(9, 88);
            this.dgHistorico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgHistorico.Name = "dgHistorico";
            this.dgHistorico.RowHeadersVisible = false;
            this.dgHistorico.RowHeadersWidth = 51;
            this.dgHistorico.RowTemplate.Height = 24;
            this.dgHistorico.Size = new System.Drawing.Size(860, 474);
            this.dgHistorico.TabIndex = 0;
            // 
            // Form_historicoContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 572);
            this.Controls.Add(this.dgHistorico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_historicoContato";
            this.Text = "Historico";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_historicoContato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHistorico;
    }
}