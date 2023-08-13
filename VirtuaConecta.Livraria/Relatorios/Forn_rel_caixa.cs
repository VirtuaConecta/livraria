using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtuaConecta.Outbound.Business;
using VirtuaConecta.Outbound.Business.BaseBis;
using VirtuaConecta.Outbound.Repository.BaseRepo;
using xDialog;

namespace VirtuaConecta.Outbound.AI.Relatorios
{
    public partial class Forn_rel_caixa : Form
    {
        ImovCaixa _mov;
        public Forn_rel_caixa()
        {
            _mov = Factory.CriaMovCaixa();
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Forn_rel_caixa_Load(object sender, EventArgs e)
        {

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Information.IsDate(dtPickerIni.Text) && Information.IsDate(dtPickerFim.Text) 
                && Convert.ToDateTime(dtPickerFim.Text) >= Convert.ToDateTime(dtPickerIni.Text)

                )
            {

                try
                {
                    var totais = _mov.TotaisFechamento(dtPickerIni.Text, dtPickerFim.Text).Split('|');
                    var setup = reportViewer2.GetPageSettings();
                    setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
                    reportViewer2.SetPageSettings(setup);

                    var GetMov = _mov.GetReport(dtPickerIni.Text, dtPickerFim.Text);
                    ReportDataSource rds = new ReportDataSource("DataSetMovFecha", GetMov);

                    ReportParameterCollection repParam = new ReportParameterCollection();

                    Decimal somatotal = 0;
                    Decimal dinheiro = 0;
                    Decimal cc = 0;
                    Decimal cd = 0;
                    Decimal cq = 0;
                    Decimal pix = 0;
                    for (int i = 0; i < totais.Length; i++)
                    {
                        var valorMeio = totais[i].Split(':');

                        if (!String.IsNullOrWhiteSpace(valorMeio[0]))
                        {

                            switch (valorMeio[0].ToString())
                            {
                                case "Cartão de Crédito":
                                    cc = Convert.ToDecimal(valorMeio[1]);
                                    break;
                                case "Cartão de Débito":
                                    cd = Convert.ToDecimal(valorMeio[1]);
                                    break;
                                case "Dinheiro":
                                    dinheiro = Convert.ToDecimal(valorMeio[1]);
                                    break;
                                case "Cheque":
                                    cq = Convert.ToDecimal(valorMeio[1]);
                                    break;
                                case "Pix":
                                    pix = Convert.ToDecimal(valorMeio[1]);
                                    break;

                            }


                            somatotal += Convert.ToDecimal(valorMeio[1]);

                        }
                    }

                    repParam.Add(new ReportParameter("ReportParamValorCredito", cc.ToString("#,##0.00")));
                    repParam.Add(new ReportParameter("ReportParamValorDebito", cd.ToString("#,##0.00")));
                    repParam.Add(new ReportParameter("ReportParamValorDinheiro", dinheiro.ToString("#,##0.00")));
                    repParam.Add(new ReportParameter("ReportParamValorCheque", cq.ToString("#,##0.00")));
                    repParam.Add(new ReportParameter("ReportParamValorPix", pix.ToString("#,##0.00")));
                    repParam.Add(new ReportParameter("ReportParamValorTotal", somatotal.ToString("#,##0.00")));

                    reportViewer2.LocalReport.DataSources.Add(rds);
                    reportViewer2.LocalReport.SetParameters(repParam);
                    reportViewer2.SetDisplayMode(DisplayMode.PrintLayout);
                    this.reportViewer2.RefreshReport();

                }
                catch (Exception ex)
                {

                    MsgBox.Show($"Erro {ex.Message}", "Erro ao gerar relatorio", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                }
            }
            else
            {
                MsgBox.Show("Intervalo de datas incorreto","Erro ao gerar relatorio",MsgBox.Buttons.OK,MsgBox.Icon.Error);
            }
        }

           private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExpandWindows_Click(object sender, EventArgs e)
        {
            if (this.WindowState== FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.MaximizeBox = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.MaximizeBox = false;
            }
        }
    }
}
