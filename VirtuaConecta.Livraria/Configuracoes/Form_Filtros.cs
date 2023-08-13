using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
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
namespace VirtuaConecta.Outbound.AI.Configuracoes
{
    public partial class Form_Filtros : MaterialForm
    {

        private Business.BaseBis.IfiltroBLL _filtro;


        public Form_Filtros()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);
            _filtro = Factory.CriarFiltroBLL();
        }


        private void Form_Filtros_Load(object sender, EventArgs e)
        {
            CarregaGrid(null);
        }

        public void CarregaGrid(String filtro)
        {
          var  filt = new List<FiltrosDTO>();

            if (String.IsNullOrWhiteSpace(filtro))
            {
                filt = _filtro.ListaFiltros();
            }
            else
            {
                filt = _filtro.ListaFiltros().Where(x=>x.Descricao.Contains(filtro)).ToList();
            }

            var ListaFiltros = filt
                .Select(e => new
                {
                    e.Id,
                    e.Descricao,
                    e.Sql,
                  

                })

              
                .ToList();

            dgFiltros.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top);


            var Source = new BindingSource(ListaFiltros, null);
            dgFiltros.DataSource = Source;


            dgFiltros.AutoResizeColumn(0);

            dgFiltros.AutoResizeColumn(1);

            dgFiltros.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
            // DgListaContatos.DefaultCellStyle.Font = new Font("Arial", 10);


            dgFiltros.Columns[0].HeaderText = "Canal";
            dgFiltros.Columns[1].HeaderText = "Cnpj";
            dgFiltros.Columns[2].HeaderText = "Cod Cliente";


            dgFiltros.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgFiltros.BorderStyle = BorderStyle.None;
            dgFiltros.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgFiltros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgFiltros.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgFiltros.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgFiltros.BackgroundColor = Color.White;

            dgFiltros.EnableHeadersVisualStyles = false;
            dgFiltros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgFiltros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 81, 100);
            dgFiltros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void dgFiltros_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            var dataItemJson = JsonConvert.SerializeObject(dgFiltros.CurrentRow.DataBoundItem);
            var item = JsonConvert.DeserializeObject<FiltrosDTO>(dataItemJson);

            var formDetFiltro = new Form_Detalhe_Filtro(this, item);
            formDetFiltro.Show();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            var item = new FiltrosDTO();

            var formDetFiltro = new Form_Detalhe_Filtro(this, item);
            formDetFiltro.Show();
        }
    }
}
