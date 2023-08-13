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
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.AI.Contatos
{
    public partial class Form_agenda : MaterialForm
    {
        private Form_ListaContatos _form;
        private ContatosDTO _item;
        public Form_agenda(Form_ListaContatos form, ContatosDTO item)
        {
            InitializeComponent();
            _form = form;
            _item = item;

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);
        }

        private void Form_agenda_Load(object sender, EventArgs e)
        {

            txtCliente.Text = _item.Cliente;
            txtDataAgenda.Text = _item.Data_Agenda_contato.ToString();


        }

        private void btnIrParaDetalhes_Click(object sender, EventArgs e)
        {
            FormDetalheContato formDet = new FormDetalheContato(_form, _item);
            formDet.Show();
            this.Close();
        }

        private void Form_agenda_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
