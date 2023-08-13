namespace VirtuaConecta.Outbound.AI.Clientes
{
    partial class Form_ClienteHistorico
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
            this.dgClienteHistorico = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbCliente = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgClienteHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClienteHistorico
            // 
            this.dgClienteHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClienteHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.valor,
            this.referencia});
            this.dgClienteHistorico.Location = new System.Drawing.Point(12, 105);
            this.dgClienteHistorico.Name = "dgClienteHistorico";
            this.dgClienteHistorico.RowHeadersVisible = false;
            this.dgClienteHistorico.Size = new System.Drawing.Size(776, 333);
            this.dgClienteHistorico.TabIndex = 0;
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.data.HeaderText = "data";
            this.data.Name = "data";
            this.data.Width = 53;
            // 
            // valor
            // 
            this.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valor.HeaderText = "valor";
            this.valor.Name = "valor";
            this.valor.Width = 55;
            // 
            // referencia
            // 
            this.referencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.referencia.HeaderText = "referencia";
            this.referencia.Name = "referencia";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCliente.Depth = 0;
            this.lbCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCliente.Location = new System.Drawing.Point(8, 74);
            this.lbCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(13, 19);
            this.lbCliente.TabIndex = 40;
            this.lbCliente.Text = "-";
            // 
            // Form_ClienteHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.dgClienteHistorico);
            this.Name = "Form_ClienteHistorico";
            this.Text = "Histórico cliente";
            this.Load += new System.EventHandler(this.Form_ClienteHistorico_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_ClienteHistorico_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgClienteHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClienteHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private MaterialSkin.Controls.MaterialLabel lbCliente;
    }
}