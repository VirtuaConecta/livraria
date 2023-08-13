using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtuaConecta.Livraria.Model;
using xDialog;

namespace VirtuaConecta.Outbound.AI.Relatorios
{
    public partial class Form_rel_mov_estoque : MaterialForm
    {
        private List<MovEstoqueDTO> _lista;
        public Form_rel_mov_estoque(List<MovEstoqueDTO> lista)
        {
            InitializeComponent();
            _lista = lista;
            CarregaRelatorio();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);

            PageSettings setup = new System.Drawing.Printing.PageSettings();

            setup.Landscape = true;
            setup.Margins = new Margins(0, 0, 0, 0);
            setup.PaperSize = new PaperSize("A3", 1654, 1169);
            //setup.PaperSize = new PaperSize("A4", 1170, 827);
            setup.PaperSize.RawKind = (int)PaperKind.A3;
            this.reportViewer_mov_estoque.SetPageSettings(setup);
        }

        private void Form_rel_mov_estoque_Load(object sender, EventArgs e)
        {

              this.reportViewer_mov_estoque.RefreshReport();
        }

        private void CarregaRelatorio()
        {
            try
            {
              
             //   var setup = reportViewer_mov_estoque.GetPageSettings();
              

                var GetMov = _lista;
                ReportDataSource rds = new ReportDataSource("DataSetMovEstoque", GetMov);



                this.reportViewer_mov_estoque.LocalReport.DataSources.Add(rds);
                // reportViewer_mov_estoque.LocalReport.SetParameters(repParam);
                this.reportViewer_mov_estoque.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer_mov_estoque.RefreshReport();

            }
            catch (Exception ex)
            {
                MsgBox.Show($"Erro {ex.Message}", "Erro ao gerar relatorio Mov de estoque", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }
        }
    }
}
