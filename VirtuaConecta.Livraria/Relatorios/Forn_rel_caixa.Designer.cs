
namespace VirtuaConecta.Outbound.AI.Relatorios
{
    partial class Forn_rel_caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forn_rel_caixa));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.dtPickerIni = new System.Windows.Forms.DateTimePicker();
            this.dtPickerFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExpandWindows = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer2.DocumentMapWidth = 79;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "VirtuaConecta.Outbound.AI.Relatorios.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 114);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1204, 576);
            this.reportViewer2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(550, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtPickerIni
            // 
            this.dtPickerIni.CustomFormat = "yyyy-MM-dd";
            this.dtPickerIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerIni.Location = new System.Drawing.Point(150, 67);
            this.dtPickerIni.Name = "dtPickerIni";
            this.dtPickerIni.Size = new System.Drawing.Size(113, 22);
            this.dtPickerIni.TabIndex = 2;
            // 
            // dtPickerFim
            // 
            this.dtPickerFim.CustomFormat = "yyyy-MM-dd";
            this.dtPickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerFim.Location = new System.Drawing.Point(405, 67);
            this.dtPickerFim.Name = "dtPickerFim";
            this.dtPickerFim.Size = new System.Drawing.Size(113, 22);
            this.dtPickerFim.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(22, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(286, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Final:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnExpandWindows);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 43);
            this.panel1.TabIndex = 6;
            // 
            // btnExpandWindows
            // 
            this.btnExpandWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandWindows.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExpandWindows.BackgroundImage")));
            this.btnExpandWindows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExpandWindows.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExpandWindows.FlatAppearance.BorderSize = 0;
            this.btnExpandWindows.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExpandWindows.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExpandWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandWindows.Location = new System.Drawing.Point(1083, 0);
            this.btnExpandWindows.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpandWindows.Name = "btnExpandWindows";
            this.btnExpandWindows.Size = new System.Drawing.Size(59, 42);
            this.btnExpandWindows.TabIndex = 11;
            this.btnExpandWindows.UseVisualStyleBackColor = false;
            this.btnExpandWindows.Click += new System.EventHandler(this.btnExpandWindows_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1161, 0);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 42);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Relatório de Fechamento de Caixa";
            // 
            // Forn_rel_caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1228, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPickerFim);
            this.Controls.Add(this.dtPickerIni);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer2);
            this.Name = "Forn_rel_caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Fechamento";
            this.Load += new System.EventHandler(this.Forn_rel_caixa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtPickerIni;
        private System.Windows.Forms.DateTimePicker dtPickerFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExpandWindows;
        //   private System.Windows.Forms.BindingSource repmovcaixaBindingSource;
    }
}