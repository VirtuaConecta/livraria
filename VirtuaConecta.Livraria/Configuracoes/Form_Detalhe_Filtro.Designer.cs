namespace VirtuaConecta.Outbound.AI.Configuracoes
{
    partial class Form_Detalhe_Filtro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdFiltro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNomeFiltro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bntnexecutar = new System.Windows.Forms.Button();
            this.txtSql = new System.Windows.Forms.PlaceholderTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Id Filtro";
            // 
            // txtIdFiltro
            // 
            this.txtIdFiltro.Depth = 0;
            this.txtIdFiltro.Enabled = false;
            this.txtIdFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFiltro.Hint = "";
            this.txtIdFiltro.Location = new System.Drawing.Point(11, 90);
            this.txtIdFiltro.Margin = new System.Windows.Forms.Padding(2);
       
            this.txtIdFiltro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdFiltro.Name = "txtIdFiltro";
            this.txtIdFiltro.PasswordChar = '\0';
            this.txtIdFiltro.SelectedText = "";
            this.txtIdFiltro.SelectionLength = 0;
            this.txtIdFiltro.SelectionStart = 0;
            this.txtIdFiltro.Size = new System.Drawing.Size(71, 23);
            this.txtIdFiltro.TabIndex = 20;
            this.txtIdFiltro.TabStop = false;
            this.txtIdFiltro.Text = "Id Filtro";
            this.txtIdFiltro.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(178, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome Filtro";
            // 
            // TxtNomeFiltro
            // 
            this.TxtNomeFiltro.Depth = 0;
            this.TxtNomeFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeFiltro.Hint = "";
            this.TxtNomeFiltro.Location = new System.Drawing.Point(180, 90);
            this.TxtNomeFiltro.Margin = new System.Windows.Forms.Padding(2);
       
            this.TxtNomeFiltro.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNomeFiltro.Name = "TxtNomeFiltro";
            this.TxtNomeFiltro.PasswordChar = '\0';
            this.TxtNomeFiltro.SelectedText = "";
            this.TxtNomeFiltro.SelectionLength = 0;
            this.TxtNomeFiltro.SelectionStart = 0;
            this.TxtNomeFiltro.Size = new System.Drawing.Size(561, 23);
            this.TxtNomeFiltro.TabIndex = 22;
            this.TxtNomeFiltro.TabStop = false;
            this.TxtNomeFiltro.Text = "Nome";
            this.TxtNomeFiltro.UseSystemPasswordChar = false;
            // 
            // bntnexecutar
            // 
            this.bntnexecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.bntnexecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntnexecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntnexecutar.ForeColor = System.Drawing.Color.White;
            this.bntnexecutar.Location = new System.Drawing.Point(632, 410);
            this.bntnexecutar.Margin = new System.Windows.Forms.Padding(2);
            this.bntnexecutar.Name = "bntnexecutar";
            this.bntnexecutar.Size = new System.Drawing.Size(157, 29);
            this.bntnexecutar.TabIndex = 71;
            this.bntnexecutar.UseVisualStyleBackColor = false;
            this.bntnexecutar.Click += new System.EventHandler(this.bntnexecutar_Click);
            // 
            // txtSql
            // 
            this.txtSql.BackColor = System.Drawing.Color.MintCream;
            this.txtSql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSql.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSql.Location = new System.Drawing.Point(12, 151);
            this.txtSql.Margin = new System.Windows.Forms.Padding(2);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.PlaceholderText = "Sql";
            this.txtSql.PlaceholderTextColor = System.Drawing.Color.DarkGreen;
            this.txtSql.Size = new System.Drawing.Size(767, 238);
            this.txtSql.TabIndex = 35;
            // 
            // Form_Detalhe_Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntnexecutar);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNomeFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdFiltro);
            this.Name = "Form_Detalhe_Filtro";
            this.Text = "Detalhe Filtro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Detalhe_Filtro_FormClosing);
            this.Load += new System.EventHandler(this.Form_Detalhe_Filtro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdFiltro;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNomeFiltro;
        private System.Windows.Forms.PlaceholderTextBox txtSql;
        private System.Windows.Forms.Button bntnexecutar;
    }
}