using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtuaConecta.Outbound.Business;
using VirtuaConecta.Outbound.Utility;
using VirtuaConecta.Outbound.Model;
using Newtonsoft.Json;
using System.Windows.Forms.DataVisualization.Charting;
using xDialog;
using MaterialSkin.Controls;
using MaterialSkin;
using VirtuaConecta.Livraria.Model;
using System.Windows.Media.Animation;

namespace VirtuaConecta.Outbound.AI.Relatorios
{
    public partial class Form_dash : MaterialForm
    {

        Business.BaseBis.IusuarioBll _user;
        private Business.BaseBis.IcontatoBLL _contato;
        DataTable tabelaTotal = new DataTable();
        DataTable tabelaVendaProdutoQtd = new DataTable();
        DataTable tabelaVendaProduto = new DataTable();
        DataTable tabelaTotalVendasFamilia = new DataTable();
        DataTable tabelavisaoMeioPagto = new DataTable();

        private Business.BaseBis.IreportsBll _report;
        public Form_dash()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);
            _contato = Factory.CriarContatosBLL();
            _report = Factory.CriaReportBll();
            _user = Factory.CriaUsuarioBLL();
        }
        private void Form_dash_Load(object sender, EventArgs e)
        {
         
          //  btnExcel.Enabled = false;

        }
        private void btnListaHistorico_Click(object sender, EventArgs e)
        {
            try
            {

                var dt_ini = DtPkInicio.Text;
                var dt_fim = DtPkFinal.Text;


               


                #region Ligações x Vendas
                //=============================================================================
                // Serie_Lig
                //   var ObjContatos = _report.HistoricoRetornoLigacoesBll(dt_ini, dt_fim, operador);

                //var carteira = Convert.ToInt32(Conversoes.GetValObjBy(ObjContatos, "Total_Carteira"));
                //var contatados = Convert.ToInt32(Conversoes.GetValObjBy(ObjContatos, "Total_Contatados"));
                //var retorno = Convert.ToInt32(Conversoes.GetValObjBy(ObjContatos, "Total_retorno"));
                //List<ChartContatosDTO> dt = new List<ChartContatosDTO>();

                //dt.Add(new ChartContatosDTO { Motivo = "Total Ativos", Total = carteira });
                //dt.Add(new ChartContatosDTO { Motivo = "Não Contatados", Total = carteira - contatados });
                //dt.Add(new ChartContatosDTO { Motivo = "Contatados", Total = contatados });
                //dt.Add(new ChartContatosDTO { Motivo = "Retorno", Total = retorno });
                //tabelaTotal = Conversoes.ToDataTable(dt);

                //chartVendLigacoes.Series.Clear();
                //chartVendLigacoes.Palette = ChartColorPalette.Bright;
                //string[] seriesArray = { "Total Ativos", "Não Contatados", "Contatados", "Retorno" };

                //int NContatdosCarteira = 0;
                //if (carteira - contatados > 0)
                //{
                //    NContatdosCarteira = carteira - contatados;
                //}

                //int[] pointsArray = { carteira, NContatdosCarteira, contatados, retorno };

                //// Add series.
                //for (int i = 0; i < seriesArray.Length; i++)
                //{
                //    Series series = this.chartVendLigacoes.Series.Add(seriesArray[i]);
                //    series.Points.Add(pointsArray[i]);
                //}
                //chartVendLigacoes.Series["Total Ativos"].IsValueShownAsLabel = true;
                //if ((carteira - contatados) >= 0)
                //{
                //    chartVendLigacoes.Series["Não Contatados"].IsValueShownAsLabel = true;
                //}
                //chartVendLigacoes.ChartAreas[0].RecalculateAxesScale();
                //chartVendLigacoes.Series["Contatados"].IsValueShownAsLabel = true;
                //chartVendLigacoes.Series["Retorno"].IsValueShownAsLabel = true;

                //lblTotalg1.Text = " Total Ativos: " + carteira + " Clientes não Contatados: " + (carteira - contatados) + " Clientes Contatados: " + contatados + " Retorno: " + retorno;



                #endregion

               

                #region Vendas Meio
                //  =============================================================================
                List<DadosChart> dtvm = new List<DadosChart>();
                List<DashDTO> ListaVendaMeio = _report.Db_venda_meioValorBll(dt_ini, dt_fim);

                foreach (var item in ListaVendaMeio)
                {

                    dtvm.Add(new DadosChart { Motivo = item.Item, Total = item.Valor2 });

                }


                tabelavisaoMeioPagto = Conversoes.ToDataTable<DadosChart>(dtvm);

                chartvendasMeio.Series["SeriesVendasMeio"].XValueMember = "Motivo";
                chartvendasMeio.Series["SeriesVendasMeio"].YValueMembers = "Total";
                chartvendasMeio.DataSource = dtvm;
                chartvendasMeio.DataBind();

                #endregion

                #region Visao Vendas Produto valor
                List<DadosChart> dtcv = new List<DadosChart>();
                List<DashDTO> ListaVendaProduto = _report.Db_venda_produtoBll(dt_ini, dt_fim,"V");

                foreach (var item in ListaVendaProduto)
                {
           
                    dtcv.Add(new DadosChart { Motivo = item.Item, Total = item.Valor2 });

                }


                tabelaVendaProduto = Conversoes.ToDataTable<DadosChart>(dtcv);

                charVendaProduto.Series["SerieVendasProd"].XValueMember = "Motivo";
                charVendaProduto.Series["SerieVendasProd"].YValueMembers = "Total";
                charVendaProduto.DataSource = dtcv;
                charVendaProduto.DataBind();
                //  lblVendasCot.Text = "Total: " + (outros + vendas + cotacoes) + " Outros: " + outros + " Vendas: " + vendas + " Cotações: " + cotacoes;
                #endregion
             
                
                
                #region Visao Vendas Produto Qtd
                List<DadosChart> dtvpq = new List<DadosChart>();
                List<DashDTO> ListaVendaProdutoQtd = _report.Db_venda_produtoBll(dt_ini, dt_fim, "Q");

                foreach (var item in ListaVendaProdutoQtd)
                {

                    dtvpq.Add(new DadosChart { Motivo = item.Item, Total = item.Valor1 });

                }


                tabelaVendaProdutoQtd = Conversoes.ToDataTable<DadosChart>(dtvpq);

                VendasProdutosQtd.Series["SerieVendasProdQtd"].XValueMember = "Motivo";
                VendasProdutosQtd.Series["SerieVendasProdQtd"].YValueMembers = "Total";
                VendasProdutosQtd.DataSource = dtvpq;
                VendasProdutosQtd.DataBind();
                //  lblVendasCot.Text = "Total: " + (outros + vendas + cotacoes) + " Outros: " + outros + " Vendas: " + vendas + " Cotações: " + cotacoes;
                #endregion


                #region Visao Vendas familia valor
                List<DadosChart> dtvf = new List<DadosChart>();
                List<DashDTO> ListaVendafamilia = _report.Db_venda_familiaBll(dt_ini, dt_fim);

                foreach (var item in ListaVendafamilia)
                {

                    dtvf.Add(new DadosChart { Motivo = item.Item, Total = item.Valor2 });

                }


                tabelaTotalVendasFamilia = Conversoes.ToDataTable<DadosChart>(dtvf);

                chartVendasFamilia.Series["SerieVendasFamilia"].XValueMember = "Motivo";
                chartVendasFamilia.Series["SerieVendasFamilia"].YValueMembers = "Total";
                chartVendasFamilia.DataSource = dtvf;
                chartVendasFamilia.DataBind();
                //  lblVendasCot.Text = "Total: " + (outros + vendas + cotacoes) + " Outros: " + outros + " Vendas: " + vendas + " Cotações: " + cotacoes;
                #endregion



            }
            catch (Exception ex)
            {
                var ee = ex;
                MsgBox.Show("Os Filtros selecionados não geraram algumas informações", "Aviso", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
            }


        }


        private void btnVendasProdValor_Click(object sender, EventArgs e)
        {
            var d = DateTime.Now;
            var nomeArq = "Relatorio_VendasProdutoValor_" + d.Year + d.Month + d.Day + d.Hour + d.Minute + d.Second + ".xlsx";

            Form_ExportaExcel _formXls = new Form_ExportaExcel(tabelaVendaProduto, nomeArq);

            _formXls.Show();
        }

        private void btnVendasProdQtd_Click(object sender, EventArgs e)
        {
            var d = DateTime.Now;
            var nomeArq = "Relatorio_TotalVendaQtd_" + d.Year + d.Month + d.Day + d.Hour + d.Minute + d.Second + ".xlsx";

            Form_ExportaExcel _formXls = new Form_ExportaExcel(tabelaVendaProdutoQtd, nomeArq);

            _formXls.Show();
        }


        private void btnVendasFamilia_Click(object sender, EventArgs e)
        {
            var d = DateTime.Now;
            var nomeArq = "Relatorio_TotalFamilia_" + d.Year + d.Month + d.Day + d.Hour + d.Minute + d.Second + ".xlsx";

            Form_ExportaExcel _formXls = new Form_ExportaExcel(tabelaTotalVendasFamilia, nomeArq);

            _formXls.Show();
        }

        private void btnVendasMeio_Click(object sender, EventArgs e)
        {
            var d = DateTime.Now;
            var nomeArq = "Relatorio_TotalMeioPagto_" + d.Year + d.Month + d.Day + d.Hour + d.Minute + d.Second + ".xlsx";

            Form_ExportaExcel _formXls = new Form_ExportaExcel(tabelavisaoMeioPagto, nomeArq);

            _formXls.Show();
        }
    }

    public class DadosChart
    {
        public  String Motivo { get; set; }
        public Decimal Total { get; set; }

    }
}
