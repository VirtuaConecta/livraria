namespace VirtuaConecta.Outbound.AI.Contatos
{
    partial class Form_ListaContatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ListaContatos));
            this.DgListaContatos = new System.Windows.Forms.DataGridView();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.rsPausa = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdInicia = new MaterialSkin.Controls.MaterialRadioButton();
            this.ckb_chamarAuto = new MaterialSkin.Controls.MaterialCheckBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtCaixaPesquisa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTimer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerAlerta = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgListaContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgListaContatos
            // 
            this.DgListaContatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgListaContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListaContatos.Location = new System.Drawing.Point(13, 15);
            this.DgListaContatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgListaContatos.Name = "DgListaContatos";
            this.DgListaContatos.RowHeadersVisible = false;
            this.DgListaContatos.RowHeadersWidth = 51;
            this.DgListaContatos.RowTemplate.Height = 24;
            this.DgListaContatos.Size = new System.Drawing.Size(1707, 697);
            this.DgListaContatos.TabIndex = 0;
            this.DgListaContatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgListaContatos_CellDoubleClick);
            this.DgListaContatos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgListaContatos_ColumnHeaderMouseClick);
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btnRecarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecarregar.ForeColor = System.Drawing.Color.White;
            this.btnRecarregar.Location = new System.Drawing.Point(459, 31);
            this.btnRecarregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(209, 39);
            this.btnRecarregar.TabIndex = 41;
            this.btnRecarregar.Text = "Importar Logix";
            this.btnRecarregar.UseVisualStyleBackColor = false;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // rsPausa
            // 
            this.rsPausa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rsPausa.AutoSize = true;
            this.rsPausa.Depth = 0;
            this.rsPausa.Font = new System.Drawing.Font("Roboto", 10F);
            this.rsPausa.Location = new System.Drawing.Point(11, 33);
            this.rsPausa.Margin = new System.Windows.Forms.Padding(0);
            this.rsPausa.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rsPausa.MouseState = MaterialSkin.MouseState.HOVER;
            this.rsPausa.Name = "rsPausa";
            this.rsPausa.Ripple = true;
            this.rsPausa.Size = new System.Drawing.Size(25, 30);
            this.rsPausa.TabIndex = 42;
            this.rsPausa.TabStop = true;
            this.rsPausa.UseVisualStyleBackColor = true;
            // 
            // rdInicia
            // 
            this.rdInicia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdInicia.AutoSize = true;
            this.rdInicia.Depth = 0;
            this.rdInicia.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdInicia.Location = new System.Drawing.Point(11, 2);
            this.rdInicia.Margin = new System.Windows.Forms.Padding(0);
            this.rdInicia.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdInicia.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdInicia.Name = "rdInicia";
            this.rdInicia.Ripple = true;
            this.rdInicia.Size = new System.Drawing.Size(25, 30);
            this.rdInicia.TabIndex = 43;
            this.rdInicia.TabStop = true;
            this.rdInicia.UseVisualStyleBackColor = true;
            this.rdInicia.CheckedChanged += new System.EventHandler(this.rdInicia_CheckedChanged);
            // 
            // ckb_chamarAuto
            // 
            this.ckb_chamarAuto.AutoSize = true;
            this.ckb_chamarAuto.Depth = 0;
            this.ckb_chamarAuto.Font = new System.Drawing.Font("Roboto", 10F);
            this.ckb_chamarAuto.Location = new System.Drawing.Point(5, 47);
            this.ckb_chamarAuto.Margin = new System.Windows.Forms.Padding(0);
            this.ckb_chamarAuto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckb_chamarAuto.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckb_chamarAuto.Name = "ckb_chamarAuto";
            this.ckb_chamarAuto.Ripple = true;
            this.ckb_chamarAuto.Size = new System.Drawing.Size(26, 30);
            this.ckb_chamarAuto.TabIndex = 44;
            this.ckb_chamarAuto.UseVisualStyleBackColor = true;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.BackColor = System.Drawing.Color.MintCream;
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFiltro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Ativo",
            "Cancelado",
            "Pendente"});
            this.cmbFiltro.Location = new System.Drawing.Point(15, 31);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(319, 31);
            this.cmbFiltro.TabIndex = 45;
            this.cmbFiltro.SelectedValueChanged += new System.EventHandler(this.cmbFiltro_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(9, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(43, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Chamada automática";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(45, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Inicia Contato";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(45, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Pausa Contato";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(15, 100);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgListaContatos);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1741, 826);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 51;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtCaixaPesquisa);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Controls.Add(this.cmbFiltro);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.cmbTimer);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.txtDias);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.ckb_chamarAuto);
            this.splitContainer2.Panel2.Controls.Add(this.btnRecarregar);
            this.splitContainer2.Size = new System.Drawing.Size(1741, 82);
            this.splitContainer2.SplitterDistance = 927;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtCaixaPesquisa
            // 
            this.txtCaixaPesquisa.Location = new System.Drawing.Point(351, 34);
            this.txtCaixaPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCaixaPesquisa.Name = "txtCaixaPesquisa";
            this.txtCaixaPesquisa.Size = new System.Drawing.Size(343, 22);
            this.txtCaixaPesquisa.TabIndex = 54;
            this.txtCaixaPesquisa.TextChanged += new System.EventHandler(this.txtCaixaPesquisa_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(347, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Pesquisar: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rdInicia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rsPausa);
            this.panel1.Location = new System.Drawing.Point(712, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 66);
            this.panel1.TabIndex = 52;
            // 
            // cmbTimer
            // 
            this.cmbTimer.BackColor = System.Drawing.Color.MintCream;
            this.cmbTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTimer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbTimer.FormattingEnabled = true;
            this.cmbTimer.Location = new System.Drawing.Point(283, 47);
            this.cmbTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTimer.Name = "cmbTimer";
            this.cmbTimer.Size = new System.Drawing.Size(139, 26);
            this.cmbTimer.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(279, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Timer";
            // 
            // txtDias
            // 
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(105, 12);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(60, 26);
            this.txtDias.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(173, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Dias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(8, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Ultimos:";
            // 
            // timerAlerta
            // 
            this.timerAlerta.Interval = 1000;
            this.timerAlerta.Tick += new System.EventHandler(this.timerAlerta_Tick);
            // 
            // Form_ListaContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_ListaContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Contatos";
            this.Load += new System.EventHandler(this.Form_ListaContatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgListaContatos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgListaContatos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRecarregar;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialRadioButton rsPausa;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRadioButton rdInicia;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialCheckBox ckb_chamarAuto;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCaixaPesquisa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timerAlerta;
    }
}