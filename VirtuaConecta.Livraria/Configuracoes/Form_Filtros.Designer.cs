namespace VirtuaConecta.Outbound.AI.Configuracoes
{
    partial class Form_Filtros
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
            this.dgFiltros = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFiltros
            // 
            this.dgFiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiltros.Location = new System.Drawing.Point(12, 127);
            this.dgFiltros.Name = "dgFiltros";
            this.dgFiltros.RowHeadersVisible = false;
            this.dgFiltros.Size = new System.Drawing.Size(773, 243);
            this.dgFiltros.TabIndex = 0;
            this.dgFiltros.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgFiltros_CellMouseDoubleClick);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.Location = new System.Drawing.Point(670, 432);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(132, 29);
            this.btnInserir.TabIndex = 66;
            this.btnInserir.Text = "Novo";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // Form_Filtros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 472);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dgFiltros);
            this.Name = "Form_Filtros";
            this.Text = "Gerenciador de Filtros";
            this.Load += new System.EventHandler(this.Form_Filtros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFiltros;
        private System.Windows.Forms.Button btnInserir;
    }
}