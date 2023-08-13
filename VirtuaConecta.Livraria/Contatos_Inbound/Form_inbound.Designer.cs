namespace VirtuaConecta.Outbound.AI.Contatos_Inbound
{
    partial class Form_inbound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_inbound));
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaixaPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(29, 145);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersVisible = false;
            this.dgClientes.Size = new System.Drawing.Size(719, 293);
            this.dgClientes.TabIndex = 44;
            this.dgClientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgClientes_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Pesquisar: ";
            // 
            // txtCaixaPesquisa
            // 
            this.txtCaixaPesquisa.Location = new System.Drawing.Point(35, 101);
            this.txtCaixaPesquisa.Name = "txtCaixaPesquisa";
            this.txtCaixaPesquisa.Size = new System.Drawing.Size(329, 20);
            this.txtCaixaPesquisa.TabIndex = 46;
            this.txtCaixaPesquisa.TextChanged += new System.EventHandler(this.txtCaixaPesquisa_TextChanged);
            // 
            // Form_inbound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.txtCaixaPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_inbound";
            this.Text = "Receber Chamada";
            this.Load += new System.EventHandler(this.Form_inbound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaixaPesquisa;
    }
}