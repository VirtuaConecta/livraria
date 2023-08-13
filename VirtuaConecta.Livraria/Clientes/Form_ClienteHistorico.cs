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
using VirtuaConecta.Outbound.Business.BaseBis;

namespace VirtuaConecta.Outbound.AI.Clientes
{
    public partial class Form_ClienteHistorico : MaterialForm
    {
        private IclienteBLL _cliente; 
        public Form_ClienteHistorico(int id, string nome)
        {
            
            InitializeComponent();
            _cliente = Factory.CriaClienteBLL();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);

             dgClienteHistorico.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
            dgClienteHistorico.BorderStyle = BorderStyle.None;
            dgClienteHistorico.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgClienteHistorico.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgClienteHistorico.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgClienteHistorico.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgClienteHistorico.BackgroundColor = Color.White;

            dgClienteHistorico.EnableHeadersVisualStyles = false;
            dgClienteHistorico.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgClienteHistorico.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 96, 100);
            dgClienteHistorico.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            lbCliente.ForeColor = Color.Teal;
            lbCliente.Text = nome;
            CarregaGrid(id);
        }

        private void Form_ClienteHistorico_Load(object sender, EventArgs e)
        {

        }

        private void CarregaGrid(int id)
        {
            dgClienteHistorico.Rows.Clear();

            var lista = _cliente.ClienteHistoricoListar().Where(x => x.id_cliente==id).ToList();
            
            for (int cont = 0; cont < lista.Count(); cont++)
                dgClienteHistorico.Rows.Add(lista[cont].data, lista[cont].valor, lista[cont].refrencia);

        }

        private void Form_ClienteHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }
    }
}
