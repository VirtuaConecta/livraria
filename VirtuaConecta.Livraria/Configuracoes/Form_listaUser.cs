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
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Outbound.Business;
using VirtuaConecta.Livraria.Model;

namespace VirtuaConecta.Outbound.AI.Configuracoes
{
    public partial class Form_listaUser : MaterialForm
    {
        Business.BaseBis.IusuarioBll _iusuario;
        public Form_listaUser()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);
            _iusuario = Factory.CriaUsuarioBLL();
        }


        public void CarregaGrid(String filtro)
        {
            var filt = new List<UsuariosDTO>();

            if (String.IsNullOrWhiteSpace(filtro))
            {
                filt = _iusuario.ListaUsuarios();
            }
            else
            {
                filt = _iusuario.ListaUsuarios().Where(x => x.LoginUsuario.Contains(filtro)).ToList();
            }

            var ListaFiltros = filt
                .Select(e => new
                {
                    e.LoginUsuario,
                    e.NomeUsuario,
                    e.Bloqueado,
                    e.Obs,
                    e.Id,
                    e.IdPerfil,
                    e.SenhaUsuario

                })


                .ToList();

            dgUsers.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top);


            var Source = new BindingSource(ListaFiltros, null);
            dgUsers.DataSource = Source;


            dgUsers.AutoResizeColumn(0);

            dgUsers.AutoResizeColumn(1);

            dgUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
            // DgListaContatos.DefaultCellStyle.Font = new Font("Arial", 10);


            dgUsers.Columns[0].HeaderText = "Login";
            dgUsers.Columns[1].HeaderText = "Nome";
            dgUsers.Columns[2].HeaderText = "Bloqueio";
            dgUsers.Columns[3].HeaderText = "Obs";

            dgUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgUsers.Columns[4].Visible = false;
            dgUsers.Columns[5].Visible = false;
            dgUsers.Columns[6].Visible = false;
            dgUsers.BorderStyle = BorderStyle.None;
            dgUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgUsers.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgUsers.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgUsers.BackgroundColor = Color.White;

            dgUsers.EnableHeadersVisualStyles = false;
            dgUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 81, 100);
            dgUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void Form_listaUser_Load(object sender, EventArgs e)
        {
            this.CarregaGrid(null);
        }

        private void dgUsers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataItemJson = JsonConvert.SerializeObject(dgUsers.CurrentRow.DataBoundItem);
            var item = JsonConvert.DeserializeObject<UsuariosDTO>(dataItemJson);

            Form_Detalhe_User form = new Form_Detalhe_User(this, item);
            form.Show();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Form_Detalhe_User form = new Form_Detalhe_User(this, null);
            form.Show();
        }
    }
}
