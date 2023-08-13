namespace VirtuaConecta.Outbound.AI.Contatos
{
    partial class Form_Correio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Correio));
            this.label2 = new System.Windows.Forms.Label();
            this.cmdClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod_rastreio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.DtEnvio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCep = new System.Windows.Forms.Label();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LblDataPrevista = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CombCodigo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRatreio = new System.Windows.Forms.Button();
            this.txtObs1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtObs2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtObs3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtObs4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label11 = new System.Windows.Forms.Label();
            this.txtObs5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtObs6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label12 = new System.Windows.Forms.Label();
            this.cmdStatus = new System.Windows.Forms.ComboBox();
            this.lblCodMunicipio = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgRatreio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgRatreio)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome Cliente";
            // 
            // cmdClientes
            // 
            this.cmdClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmdClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmdClientes.BackColor = System.Drawing.Color.MintCream;
            this.cmdClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdClientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClientes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmdClientes.FormattingEnabled = true;
            this.cmdClientes.Location = new System.Drawing.Point(23, 84);
            this.cmdClientes.Margin = new System.Windows.Forms.Padding(2);
            this.cmdClientes.Name = "cmdClientes";
            this.cmdClientes.Size = new System.Drawing.Size(512, 26);
            this.cmdClientes.TabIndex = 29;
            this.cmdClientes.SelectionChangeCommitted += new System.EventHandler(this.cmdClientes_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(20, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cod de rastreio";
            // 
            // txtCod_rastreio
            // 
            this.txtCod_rastreio.BackColor = System.Drawing.Color.White;
            this.txtCod_rastreio.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCod_rastreio.Depth = 0;
            this.txtCod_rastreio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod_rastreio.Hint = "";
            this.txtCod_rastreio.Location = new System.Drawing.Point(17, 147);
            this.txtCod_rastreio.Margin = new System.Windows.Forms.Padding(2);

            this.txtCod_rastreio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCod_rastreio.Name = "txtCod_rastreio";
            this.txtCod_rastreio.PasswordChar = '\0';
            this.txtCod_rastreio.SelectedText = "";
            this.txtCod_rastreio.SelectionLength = 0;
            this.txtCod_rastreio.SelectionStart = 0;
            this.txtCod_rastreio.Size = new System.Drawing.Size(230, 23);
            this.txtCod_rastreio.TabIndex = 42;
            this.txtCod_rastreio.TabStop = false;
            this.txtCod_rastreio.UseSystemPasswordChar = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(596, 142);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(157, 29);
            this.btnPesquisar.TabIndex = 43;
            this.btnPesquisar.Text = "Calcula data entrega";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // DtEnvio
            // 
            this.DtEnvio.CalendarTitleBackColor = System.Drawing.Color.PaleGreen;
            this.DtEnvio.Cursor = System.Windows.Forms.Cursors.Default;
            this.DtEnvio.CustomFormat = "yyyy-MM-dd";
            this.DtEnvio.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtEnvio.Location = new System.Drawing.Point(596, 86);
            this.DtEnvio.Margin = new System.Windows.Forms.Padding(2);
            this.DtEnvio.Name = "DtEnvio";
            this.DtEnvio.Size = new System.Drawing.Size(105, 24);
            this.DtEnvio.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(593, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Dt Envio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(850, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Cep";
            // 
            // LblCep
            // 
            this.LblCep.AutoSize = true;
            this.LblCep.BackColor = System.Drawing.Color.Transparent;
            this.LblCep.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCep.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCep.ForeColor = System.Drawing.Color.Black;
            this.LblCep.Location = new System.Drawing.Point(856, 276);
            this.LblCep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCep.Name = "LblCep";
            this.LblCep.Size = new System.Drawing.Size(34, 16);
            this.LblCep.TabIndex = 48;
            this.LblCep.Text = "Cep";
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.LblEndereco.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblEndereco.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEndereco.ForeColor = System.Drawing.Color.Black;
            this.LblEndereco.Location = new System.Drawing.Point(857, 84);
            this.LblEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(33, 16);
            this.LblEndereco.TabIndex = 50;
            this.LblEndereco.Text = "End";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(850, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Endereço";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBairro.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.Black;
            this.lblBairro.Location = new System.Drawing.Point(856, 131);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(46, 16);
            this.lblBairro.TabIndex = 52;
            this.lblBairro.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(850, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.lblCidade.Location = new System.Drawing.Point(856, 176);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 16);
            this.lblCidade.TabIndex = 54;
            this.lblCidade.Text = "cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(850, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Cidade";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.BackColor = System.Drawing.Color.Transparent;
            this.LblEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblEstado.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.ForeColor = System.Drawing.Color.Black;
            this.LblEstado.Location = new System.Drawing.Point(857, 226);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(21, 16);
            this.LblEstado.TabIndex = 56;
            this.LblEstado.Text = "Uf";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(850, 202);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Uf";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1070, 709);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 29);
            this.button1.TabIndex = 57;
            this.button1.Text = "Atualizar Historico Cliente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblDataPrevista
            // 
            this.LblDataPrevista.AutoSize = true;
            this.LblDataPrevista.BackColor = System.Drawing.Color.Transparent;
            this.LblDataPrevista.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblDataPrevista.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataPrevista.ForeColor = System.Drawing.Color.Black;
            this.LblDataPrevista.Location = new System.Drawing.Point(856, 325);
            this.LblDataPrevista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDataPrevista.Name = "LblDataPrevista";
            this.LblDataPrevista.Size = new System.Drawing.Size(20, 16);
            this.LblDataPrevista.TabIndex = 59;
            this.LblDataPrevista.Text = "dt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(850, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Data Prevista de entraga";
            // 
            // CombCodigo
            // 
            this.CombCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CombCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CombCodigo.BackColor = System.Drawing.Color.MintCream;
            this.CombCodigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.CombCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CombCodigo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CombCodigo.FormattingEnabled = true;
            this.CombCodigo.Items.AddRange(new object[] {
            "40010 - SEDEX sem contrato",
            "40045 - SEDEX a Cobrar, sem contrato",
            "40126 - SEDEX a Cobrar, com contrato",
            "40215 - SEDEX 10, sem contrato",
            "40290 - SEDEX Hoje, sem contrato",
            "40096 - SEDEX com contrato",
            "40436 - SEDEX com contrato",
            "40444 - SEDEX com contrato",
            "40568 - SEDEX com contrato",
            "40606 - SEDEX com contrato",
            "41106 - PAC sem contrato",
            "41211 - PAC com contrato",
            "41068 - PAC com contrato",
            "81019 -  e-SEDEX, com contrato",
            "81035 -  e-SEDEX Express, com contrato",
            "81868 - (Grupo 1) e-SEDEX, com contrato",
            "81833 - (Grupo 2 ) e-SEDEX, com contrato",
            "81850 - (Grupo 3 ) e-SEDEX, com contrato",
            ""});
            this.CombCodigo.Location = new System.Drawing.Point(331, 146);
            this.CombCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.CombCodigo.Name = "CombCodigo";
            this.CombCodigo.Size = new System.Drawing.Size(229, 24);
            this.CombCodigo.TabIndex = 60;
            this.CombCodigo.SelectedValueChanged += new System.EventHandler(this.CombCodigo_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(328, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Cod Serviço";
            // 
            // btnRatreio
            // 
            this.btnRatreio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btnRatreio.CausesValidation = false;
            this.btnRatreio.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRatreio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRatreio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRatreio.ForeColor = System.Drawing.Color.White;
            this.btnRatreio.Location = new System.Drawing.Point(251, 141);
            this.btnRatreio.Margin = new System.Windows.Forms.Padding(2);
            this.btnRatreio.Name = "btnRatreio";
            this.btnRatreio.Size = new System.Drawing.Size(64, 29);
            this.btnRatreio.TabIndex = 63;
            this.btnRatreio.Text = "Rastreio";
            this.btnRatreio.UseVisualStyleBackColor = false;
            this.btnRatreio.Click += new System.EventHandler(this.btnRatreio_Click);
            // 
            // txtObs1
            // 
            this.txtObs1.BackColor = System.Drawing.Color.White;
            this.txtObs1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtObs1.Depth = 0;
            this.txtObs1.Hint = "";
            this.txtObs1.Location = new System.Drawing.Point(853, 494);
            this.txtObs1.Margin = new System.Windows.Forms.Padding(2);

            this.txtObs1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObs1.Name = "txtObs1";
            this.txtObs1.PasswordChar = '\0';
            this.txtObs1.SelectedText = "";
            this.txtObs1.SelectionLength = 0;
            this.txtObs1.SelectionStart = 0;
            this.txtObs1.Size = new System.Drawing.Size(352, 23);
            this.txtObs1.TabIndex = 64;
            this.txtObs1.TabStop = false;
            this.txtObs1.UseSystemPasswordChar = false;
            // 
            // txtObs2
            // 
            this.txtObs2.BackColor = System.Drawing.Color.White;
            this.txtObs2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtObs2.Depth = 0;
            this.txtObs2.Hint = "";
            this.txtObs2.Location = new System.Drawing.Point(853, 531);
            this.txtObs2.Margin = new System.Windows.Forms.Padding(2);
     
            this.txtObs2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObs2.Name = "txtObs2";
            this.txtObs2.PasswordChar = '\0';
            this.txtObs2.SelectedText = "";
            this.txtObs2.SelectionLength = 0;
            this.txtObs2.SelectionStart = 0;
            this.txtObs2.Size = new System.Drawing.Size(352, 23);
            this.txtObs2.TabIndex = 65;
            this.txtObs2.TabStop = false;
            this.txtObs2.UseSystemPasswordChar = false;
            // 
            // txtObs3
            // 
            this.txtObs3.BackColor = System.Drawing.Color.White;
            this.txtObs3.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtObs3.Depth = 0;
            this.txtObs3.Hint = "";
            this.txtObs3.Location = new System.Drawing.Point(853, 570);
            this.txtObs3.Margin = new System.Windows.Forms.Padding(2);
          
            this.txtObs3.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObs3.Name = "txtObs3";
            this.txtObs3.PasswordChar = '\0';
            this.txtObs3.SelectedText = "";
            this.txtObs3.SelectionLength = 0;
            this.txtObs3.SelectionStart = 0;
            this.txtObs3.Size = new System.Drawing.Size(352, 23);
            this.txtObs3.TabIndex = 66;
            this.txtObs3.TabStop = false;
            this.txtObs3.UseSystemPasswordChar = false;
            // 
            // txtObs4
            // 
            this.txtObs4.BackColor = System.Drawing.Color.White;
            this.txtObs4.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtObs4.Depth = 0;
            this.txtObs4.Hint = "";
            this.txtObs4.Location = new System.Drawing.Point(853, 606);
            this.txtObs4.Margin = new System.Windows.Forms.Padding(2);

            this.txtObs4.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObs4.Name = "txtObs4";
            this.txtObs4.PasswordChar = '\0';
            this.txtObs4.SelectedText = "";
            this.txtObs4.SelectionLength = 0;
            this.txtObs4.SelectionStart = 0;
            this.txtObs4.Size = new System.Drawing.Size(352, 23);
            this.txtObs4.TabIndex = 67;
            this.txtObs4.TabStop = false;
            this.txtObs4.UseSystemPasswordChar = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(850, 464);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Observações";
            // 
            // txtObs5
            // 
            this.txtObs5.BackColor = System.Drawing.Color.White;
            this.txtObs5.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtObs5.Depth = 0;
            this.txtObs5.Hint = "";
            this.txtObs5.Location = new System.Drawing.Point(853, 643);
            this.txtObs5.Margin = new System.Windows.Forms.Padding(2);

            this.txtObs5.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObs5.Name = "txtObs5";
            this.txtObs5.PasswordChar = '\0';
            this.txtObs5.SelectedText = "";
            this.txtObs5.SelectionLength = 0;
            this.txtObs5.SelectionStart = 0;
            this.txtObs5.Size = new System.Drawing.Size(355, 23);
            this.txtObs5.TabIndex = 69;
            this.txtObs5.TabStop = false;
            this.txtObs5.UseSystemPasswordChar = false;
            // 
            // txtObs6
            // 
            this.txtObs6.BackColor = System.Drawing.Color.White;
            this.txtObs6.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtObs6.Depth = 0;
            this.txtObs6.Hint = "";
            this.txtObs6.Location = new System.Drawing.Point(853, 682);
            this.txtObs6.Margin = new System.Windows.Forms.Padding(2);
   
            this.txtObs6.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObs6.Name = "txtObs6";
            this.txtObs6.PasswordChar = '\0';
            this.txtObs6.SelectedText = "";
            this.txtObs6.SelectionLength = 0;
            this.txtObs6.SelectionStart = 0;
            this.txtObs6.Size = new System.Drawing.Size(356, 23);
            this.txtObs6.TabIndex = 70;
            this.txtObs6.TabStop = false;
            this.txtObs6.UseSystemPasswordChar = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(850, 403);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 72;
            this.label12.Text = "Status Contato";
            // 
            // cmdStatus
            // 
            this.cmdStatus.BackColor = System.Drawing.Color.MintCream;
            this.cmdStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmdStatus.FormattingEnabled = true;
            this.cmdStatus.Location = new System.Drawing.Point(851, 427);
            this.cmdStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmdStatus.Name = "cmdStatus";
            this.cmdStatus.Size = new System.Drawing.Size(354, 26);
            this.cmdStatus.TabIndex = 71;
            // 
            // lblCodMunicipio
            // 
            this.lblCodMunicipio.AutoSize = true;
            this.lblCodMunicipio.BackColor = System.Drawing.Color.Transparent;
            this.lblCodMunicipio.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCodMunicipio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodMunicipio.ForeColor = System.Drawing.Color.Black;
            this.lblCodMunicipio.Location = new System.Drawing.Point(857, 376);
            this.lblCodMunicipio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodMunicipio.Name = "lblCodMunicipio";
            this.lblCodMunicipio.Size = new System.Drawing.Size(61, 16);
            this.lblCodMunicipio.TabIndex = 74;
            this.lblCodMunicipio.Text = "CodMun";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.ForeColor = System.Drawing.Color.DarkGreen;
            this.label14.Location = new System.Drawing.Point(850, 352);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 73;
            this.label14.Text = "Cod Município";
            // 
            // dgRatreio
            // 
            this.dgRatreio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRatreio.Location = new System.Drawing.Point(23, 202);
            this.dgRatreio.Name = "dgRatreio";
            this.dgRatreio.Size = new System.Drawing.Size(768, 439);
            this.dgRatreio.TabIndex = 75;
            // 
            // Form_Correio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 743);
            this.Controls.Add(this.dgRatreio);
            this.Controls.Add(this.lblCodMunicipio);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmdStatus);
            this.Controls.Add(this.txtObs6);
            this.Controls.Add(this.txtObs5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtObs4);
            this.Controls.Add(this.txtObs3);
            this.Controls.Add(this.txtObs2);
            this.Controls.Add(this.txtObs1);
            this.Controls.Add(this.btnRatreio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CombCodigo);
            this.Controls.Add(this.LblDataPrevista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblEndereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblCep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtEnvio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtCod_rastreio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdClientes);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Correio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remessa Correio";
            this.Load += new System.EventHandler(this.Form_Correio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRatreio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdClientes;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCod_rastreio;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DateTimePicker DtEnvio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblCep;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblDataPrevista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CombCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRatreio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtObs1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtObs2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtObs3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtObs4;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtObs5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtObs6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmdStatus;
        private System.Windows.Forms.Label lblCodMunicipio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgRatreio;
    }
}