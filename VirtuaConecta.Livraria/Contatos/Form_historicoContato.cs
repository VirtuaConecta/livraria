using MaterialSkin;
using MaterialSkin.Controls;
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
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.AI.Contatos
{
    public partial class Form_historicoContato : MaterialForm
    {
        private Business.BaseBis.IcontatoBLL _icontato;
        private ContatosDTO _contato = new ContatosDTO();
        public Form_historicoContato(ContatosDTO contato)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Green400, Primary.Cyan900, Primary.Cyan700,
                Accent.Cyan400, TextShade.WHITE);
            _contato = contato;
            _icontato = Factory.CriarContatosBLL();
        }

        private void Form_historicoContato_Load(object sender, EventArgs e)
        {
            this.Text = "Histórico de contato Cliente: "+ _contato.Cliente;
           this.CarregaGrid();
        }

        public void CarregaGrid()
        {
            var listaContatos = _icontato.ListaHistoricoContato(_contato.Id)
                .Select(e => new
                {
                    e.Historico_Desc,
                    e.Dt_contato,
                    e.Dt_retorno,
                    e.Desc_status,
                    e.Operador,


                }).OrderByDescending(x=>x.Dt_contato).ToList();
            var Source = new BindingSource(listaContatos, null);
            dgHistorico.DataSource = Source;
            dgHistorico.AutoResizeColumn(0);

            dgHistorico.AutoResizeColumn(3);
            //  DgListaContatos.AutoResizeColumn(4);

            dgHistorico.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
            // DgListaContatos.DefaultCellStyle.Font = new Font("Arial", 10);

            dgHistorico.Columns[0].HeaderText = "Historico";
            dgHistorico.Columns[1].HeaderText = "Dt Contato";
            dgHistorico.Columns[2].HeaderText = "Dt Retorno";
            dgHistorico.Columns[3].HeaderText = "Status";
            dgHistorico.Columns[4].HeaderText = "Operador";

            dgHistorico.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgHistorico.BorderStyle = BorderStyle.None;
            dgHistorico.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgHistorico.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgHistorico.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgHistorico.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgHistorico.BackgroundColor = Color.White;

            dgHistorico.EnableHeadersVisualStyles = false;
            dgHistorico.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgHistorico.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 81, 100);
            dgHistorico.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
    }
}
