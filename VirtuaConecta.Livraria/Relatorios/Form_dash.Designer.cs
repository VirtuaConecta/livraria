namespace VirtuaConecta.Outbound.AI.Relatorios
{
    partial class Form_dash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_dash));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnListaHistorico = new System.Windows.Forms.Button();
            this.DtPkFinal = new System.Windows.Forms.DateTimePicker();
            this.DtPkInicio = new System.Windows.Forms.DateTimePicker();
            this.btnVendasProdValor = new System.Windows.Forms.Button();
            this.charVendaProduto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnVendasProdQtd = new System.Windows.Forms.Button();
            this.VendasProdutosQtd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVendasFamilia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartvendasMeio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnVendasFamilia = new System.Windows.Forms.Button();
            this.btnVendasMeio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.charVendaProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendasProdutosQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVendasFamilia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartvendasMeio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(196, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Dt Final";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(13, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Dt Início";
            // 
            // btnListaHistorico
            // 
            this.btnListaHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btnListaHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaHistorico.ForeColor = System.Drawing.Color.White;
            this.btnListaHistorico.Location = new System.Drawing.Point(993, 79);
            this.btnListaHistorico.Margin = new System.Windows.Forms.Padding(2);
            this.btnListaHistorico.Name = "btnListaHistorico";
            this.btnListaHistorico.Size = new System.Drawing.Size(157, 29);
            this.btnListaHistorico.TabIndex = 66;
            this.btnListaHistorico.Text = "Executar";
            this.btnListaHistorico.UseVisualStyleBackColor = false;
            this.btnListaHistorico.Click += new System.EventHandler(this.btnListaHistorico_Click);
            // 
            // DtPkFinal
            // 
            this.DtPkFinal.CalendarTitleBackColor = System.Drawing.Color.PaleGreen;
            this.DtPkFinal.CustomFormat = "yyyy-MM-dd";
            this.DtPkFinal.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtPkFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtPkFinal.Location = new System.Drawing.Point(199, 84);
            this.DtPkFinal.Margin = new System.Windows.Forms.Padding(2);
            this.DtPkFinal.Name = "DtPkFinal";
            this.DtPkFinal.Size = new System.Drawing.Size(147, 24);
            this.DtPkFinal.TabIndex = 33;
            // 
            // DtPkInicio
            // 
            this.DtPkInicio.CalendarTitleBackColor = System.Drawing.Color.PaleGreen;
            this.DtPkInicio.CustomFormat = "yyyy-MM-dd";
            this.DtPkInicio.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtPkInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtPkInicio.Location = new System.Drawing.Point(16, 84);
            this.DtPkInicio.Margin = new System.Windows.Forms.Padding(2);
            this.DtPkInicio.Name = "DtPkInicio";
            this.DtPkInicio.Size = new System.Drawing.Size(150, 24);
            this.DtPkInicio.TabIndex = 32;
            // 
            // btnVendasProdValor
            // 
            this.btnVendasProdValor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVendasProdValor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVendasProdValor.BackgroundImage")));
            this.btnVendasProdValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVendasProdValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendasProdValor.Location = new System.Drawing.Point(442, 338);
            this.btnVendasProdValor.Name = "btnVendasProdValor";
            this.btnVendasProdValor.Size = new System.Drawing.Size(44, 35);
            this.btnVendasProdValor.TabIndex = 15;
            this.btnVendasProdValor.UseVisualStyleBackColor = false;
            this.btnVendasProdValor.Click += new System.EventHandler(this.btnVendasProdValor_Click);
            // 
            // charVendaProduto
            // 
            chartArea1.Name = "ChartArea1";
            this.charVendaProduto.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charVendaProduto.Legends.Add(legend1);
            this.charVendaProduto.Location = new System.Drawing.Point(79, 147);
            this.charVendaProduto.Name = "charVendaProduto";
            this.charVendaProduto.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "SerieVendasProd";
            this.charVendaProduto.Series.Add(series1);
            this.charVendaProduto.Size = new System.Drawing.Size(429, 248);
            this.charVendaProduto.TabIndex = 18;
            this.charVendaProduto.Text = "charVendaProduto";
            title1.Name = "Title1";
            title1.Text = "Vendas por produto top 10 em Reias";
            this.charVendaProduto.Titles.Add(title1);
            // 
            // btnVendasProdQtd
            // 
            this.btnVendasProdQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVendasProdQtd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVendasProdQtd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVendasProdQtd.BackgroundImage")));
            this.btnVendasProdQtd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVendasProdQtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendasProdQtd.Location = new System.Drawing.Point(1080, 360);
            this.btnVendasProdQtd.Name = "btnVendasProdQtd";
            this.btnVendasProdQtd.Size = new System.Drawing.Size(44, 35);
            this.btnVendasProdQtd.TabIndex = 2;
            this.btnVendasProdQtd.UseVisualStyleBackColor = false;
            this.btnVendasProdQtd.Click += new System.EventHandler(this.btnVendasProdQtd_Click);
            // 
            // VendasProdutosQtd
            // 
            this.VendasProdutosQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.VendasProdutosQtd.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendasProdutosQtd.Legends.Add(legend2);
            this.VendasProdutosQtd.Location = new System.Drawing.Point(721, 156);
            this.VendasProdutosQtd.Name = "VendasProdutosQtd";
            this.VendasProdutosQtd.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.VendasProdutosQtd.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Lime,
        System.Drawing.Color.Aqua,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Fuchsia,
        System.Drawing.Color.Maroon,
        System.Drawing.Color.Green,
        System.Drawing.Color.Navy,
        System.Drawing.Color.Purple};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "SerieVendasProdQtd";
            this.VendasProdutosQtd.Series.Add(series2);
            this.VendasProdutosQtd.Size = new System.Drawing.Size(429, 248);
            this.VendasProdutosQtd.TabIndex = 1;
            this.VendasProdutosQtd.Text = "VendasProdutosQtd";
            this.VendasProdutosQtd.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            title2.Name = "TitleContatosTotalEfetivos";
            title2.Text = "Vendas por porduto top 10 em Quantidade";
            this.VendasProdutosQtd.Titles.Add(title2);
            // 
            // chartVendasFamilia
            // 
            this.chartVendasFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea3.Name = "ChartArea1";
            this.chartVendasFamilia.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartVendasFamilia.Legends.Add(legend3);
            this.chartVendasFamilia.Location = new System.Drawing.Point(57, 513);
            this.chartVendasFamilia.Name = "chartVendasFamilia";
            this.chartVendasFamilia.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartVendasFamilia.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Yellow,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Aqua,
        System.Drawing.Color.Maroon,
        System.Drawing.Color.Navy,
        System.Drawing.Color.Purple,
        System.Drawing.Color.Orange,
        System.Drawing.Color.Pink,
        System.Drawing.Color.RoyalBlue,
        System.Drawing.Color.DarkOliveGreen};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "SerieVendasFamilia";
            this.chartVendasFamilia.Series.Add(series3);
            this.chartVendasFamilia.Size = new System.Drawing.Size(429, 248);
            this.chartVendasFamilia.TabIndex = 14;
            this.chartVendasFamilia.Text = "chartVendasFamilia";
            title3.Name = "Title1";
            title3.Text = "Vendas Famila produtos top 10";
            this.chartVendasFamilia.Titles.Add(title3);
            // 
            // chartvendasMeio
            // 
            this.chartvendasMeio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartvendasMeio.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartvendasMeio.Legends.Add(legend4);
            this.chartvendasMeio.Location = new System.Drawing.Point(721, 513);
            this.chartvendasMeio.Name = "chartvendasMeio";
            this.chartvendasMeio.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Lime};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "SeriesVendasMeio";
            this.chartvendasMeio.Series.Add(series4);
            this.chartvendasMeio.Size = new System.Drawing.Size(429, 248);
            this.chartvendasMeio.TabIndex = 11;
            this.chartvendasMeio.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Vendas Meio de pagamentos";
            this.chartvendasMeio.Titles.Add(title4);
            // 
            // btnVendasFamilia
            // 
            this.btnVendasFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVendasFamilia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVendasFamilia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVendasFamilia.BackgroundImage")));
            this.btnVendasFamilia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVendasFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendasFamilia.Location = new System.Drawing.Point(420, 703);
            this.btnVendasFamilia.Name = "btnVendasFamilia";
            this.btnVendasFamilia.Size = new System.Drawing.Size(44, 35);
            this.btnVendasFamilia.TabIndex = 69;
            this.btnVendasFamilia.UseVisualStyleBackColor = false;
            this.btnVendasFamilia.Click += new System.EventHandler(this.btnVendasFamilia_Click);
            // 
            // btnVendasMeio
            // 
            this.btnVendasMeio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVendasMeio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVendasMeio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVendasMeio.BackgroundImage")));
            this.btnVendasMeio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVendasMeio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendasMeio.Location = new System.Drawing.Point(1080, 703);
            this.btnVendasMeio.Name = "btnVendasMeio";
            this.btnVendasMeio.Size = new System.Drawing.Size(44, 35);
            this.btnVendasMeio.TabIndex = 70;
            this.btnVendasMeio.UseVisualStyleBackColor = false;
            this.btnVendasMeio.Click += new System.EventHandler(this.btnVendasMeio_Click);
            // 
            // Form_dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1178, 785);
            this.Controls.Add(this.btnVendasMeio);
            this.Controls.Add(this.btnVendasFamilia);
            this.Controls.Add(this.chartvendasMeio);
            this.Controls.Add(this.btnVendasProdQtd);
            this.Controls.Add(this.VendasProdutosQtd);
            this.Controls.Add(this.btnVendasProdValor);
            this.Controls.Add(this.btnListaHistorico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtPkFinal);
            this.Controls.Add(this.DtPkInicio);
            this.Controls.Add(this.chartVendasFamilia);
            this.Controls.Add(this.charVendaProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_dash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dash Board";
            this.Load += new System.EventHandler(this.Form_dash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charVendaProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendasProdutosQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVendasFamilia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartvendasMeio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DtPkFinal;
        private System.Windows.Forms.DateTimePicker DtPkInicio;
        private System.Windows.Forms.Button btnListaHistorico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart VendasProdutosQtd;
        private System.Windows.Forms.Button btnVendasProdQtd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartvendasMeio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVendasFamilia;
        private System.Windows.Forms.Button btnVendasProdValor;
        private System.Windows.Forms.DataVisualization.Charting.Chart charVendaProduto;
        private System.Windows.Forms.Button btnVendasFamilia;
        private System.Windows.Forms.Button btnVendasMeio;
    }
}