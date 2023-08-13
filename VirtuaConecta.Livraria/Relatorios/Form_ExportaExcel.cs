using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using xDialog;
using VirtuaConecta.Outbound.Utility;
using VirtuaConecta.Outbound.Parametros;

namespace VirtuaConecta.Outbound.AI.Relatorios
{
    public partial class Form_ExportaExcel : MaterialForm
    {
        
        private DataTable _dt;
        private string _nomeArq;
        public Form_ExportaExcel(DataTable Dt, String NomeArq)
        {
            InitializeComponent();
            _dt = Dt;
            _nomeArq = NomeArq;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Green400, Primary.Cyan900, Primary.Cyan700,
                Accent.Cyan400, TextShade.WHITE);

            materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Arial", 12);
            materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Arial", 10);
            materialSkinManager.ROBOTO_REGULAR_11 = new Font("Arial", 11);
            materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Arial", 11);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            //inclusao do toolbox  folder browsing dialog
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoArq.Text = FBD.SelectedPath;
                

            }

        }

        private void btnGerarExcel_Click(object sender, EventArgs e)
        {
            try
            {

                if (!String.IsNullOrEmpty(txtCaminhoArq.Text))
                {
                    String Arquivos = txtCaminhoArq.Text + "\\" + _nomeArq;


                    if (File.Exists(Arquivos))
                        File.Delete(Arquivos);

                    var existingFile = new FileInfo(Arquivos);

                    using (ExcelPackage pck = new ExcelPackage(existingFile))
                    {
                        ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Relatorio");
                        ws.Cells["A1"].LoadFromDataTable(_dt, true);
                        pck.Save();
                    }




                    MsgBox.Show("Arquivo Gerado!", "Esportar Excel", MsgBox.Buttons.OK, MsgBox.Icon.Info);

                    this.Close();
                }
                else
                {
                    MsgBox.Show("Escolher um local para o Arquivo!", "Exportar Excel", MsgBox.Buttons.OK, MsgBox.Icon.Error);

                    txtCaminhoArq.Focus();
                }
            }
            catch (Exception ex)
            {
                LogEvento.EscreverEvento("Erro ao exportar excel: " + ex.Message, MessageType.Error);
                MsgBox.Show("Erro ao exportar Arquivo! \r\n" + ex.Message, "Exportar Excel", MsgBox.Buttons.OK, MsgBox.Icon.Error);

            }
        }
    }
}
