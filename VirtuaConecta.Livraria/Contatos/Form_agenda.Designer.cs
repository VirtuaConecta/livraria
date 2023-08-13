namespace VirtuaConecta.Outbound.AI.Contatos
{
    partial class Form_agenda
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIrParaDetalhes = new System.Windows.Forms.Button();
            this.txtCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDataAgenda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(557, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Data Agenda:";
            // 
            // btnIrParaDetalhes
            // 
            this.btnIrParaDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btnIrParaDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrParaDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrParaDetalhes.ForeColor = System.Drawing.Color.White;
            this.btnIrParaDetalhes.Location = new System.Drawing.Point(632, 149);
            this.btnIrParaDetalhes.Margin = new System.Windows.Forms.Padding(2);
            this.btnIrParaDetalhes.Name = "btnIrParaDetalhes";
            this.btnIrParaDetalhes.Size = new System.Drawing.Size(157, 32);
            this.btnIrParaDetalhes.TabIndex = 56;
            this.btnIrParaDetalhes.Text = "Ir";
            this.btnIrParaDetalhes.UseVisualStyleBackColor = false;
            this.btnIrParaDetalhes.Click += new System.EventHandler(this.btnIrParaDetalhes_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Depth = 0;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Hint = "";
            this.txtCliente.Location = new System.Drawing.Point(11, 89);
   
            this.txtCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.SelectedText = "";
            this.txtCliente.SelectionLength = 0;
            this.txtCliente.SelectionStart = 0;
            this.txtCliente.Size = new System.Drawing.Size(497, 23);
            this.txtCliente.TabIndex = 57;
            this.txtCliente.TabStop = false;
            this.txtCliente.Text = "Cliente";
            this.txtCliente.UseSystemPasswordChar = false;
            // 
            // txtDataAgenda
            // 
            this.txtDataAgenda.Depth = 0;
            this.txtDataAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAgenda.Hint = "";
            this.txtDataAgenda.Location = new System.Drawing.Point(561, 89);
            this.txtDataAgenda.Margin = new System.Windows.Forms.Padding(2);
 
            this.txtDataAgenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDataAgenda.Name = "txtDataAgenda";
            this.txtDataAgenda.PasswordChar = '\0';
            this.txtDataAgenda.SelectedText = "";
            this.txtDataAgenda.SelectionLength = 0;
            this.txtDataAgenda.SelectionStart = 0;
            this.txtDataAgenda.Size = new System.Drawing.Size(224, 23);
            this.txtDataAgenda.TabIndex = 58;
            this.txtDataAgenda.TabStop = false;
            this.txtDataAgenda.Text = "Data";
            this.txtDataAgenda.UseSystemPasswordChar = false;
            // 
            // Form_agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 192);
            this.Controls.Add(this.txtDataAgenda);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnIrParaDetalhes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Form_agenda";
            this.Text = "Contato Agendado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_agenda_FormClosed);
            this.Load += new System.EventHandler(this.Form_agenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIrParaDetalhes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDataAgenda;
    }
}