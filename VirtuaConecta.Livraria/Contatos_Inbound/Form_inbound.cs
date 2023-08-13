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
using VirtuaConecta.Outbound.AI.Contatos;
using VirtuaConecta.Outbound.Business;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.AI.Contatos_Inbound
{
    public partial class Form_inbound : MaterialForm
    {
        private Business.BaseBis.ClienteLogixBLL _cliente;

        List<ClienteLogixDTO> listacli = new List<ClienteLogixDTO>();
        public Form_inbound()
        {
            InitializeComponent();

            _cliente = Factory.CriarClienteLogix();
          

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);

            materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Arial", 12);
            materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Arial", 10);
            materialSkinManager.ROBOTO_REGULAR_11 = new Font("Arial", 11);
            materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Arial", 11);
        }



        private void CarregaGrid(String dado)
        {
            List<ClienteLogixDTO> listacli1 = new List<ClienteLogixDTO>();

            //.Where(x => x.Telefone.Contains(dado)).ToList();

            //if (!String.IsNullOrWhiteSpace(dado))
            //{

            //    listacli1 = listacli.Where(x => x.Cliente.ToUpper().Contains(dado.ToUpper()) || x.Telefone.ToUpper().Contains(dado.ToUpper())
            //        ).ToList();
            //}
            //else
            //{
            //    listacli1 = listacli;
            //}
            if (!String.IsNullOrWhiteSpace(dado) && dado.Length>3)
            {


                var list = _cliente.ListaClienteLogix(dado.ToUpper())
            .Select(e => new
            {
                e.Id_cliente,
                e.Cliente,


                e.Cnpj,

                e.Telefone,

                e.Email,
                e.Endereco,
                e.Bairro

            }).ToList();
                var Source = new BindingSource(list, null);
                dgClientes.DataSource = Source;

            }
        }

        private void txtCaixaPesquisa_TextChanged(object sender, EventArgs e)
        {
           CarregaGrid(txtCaixaPesquisa.Text);
        }

        private void Form_inbound_Load(object sender, EventArgs e)
        {
            //  listacli = _cliente.ListaClienteLogix();
          //  CarregaGrid(null);
        }

        private void dgClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //var itemSelect = dgClientes.SelectedRows;

            var dataItemJson = JsonConvert.SerializeObject(dgClientes.CurrentRow.DataBoundItem);
            var item = JsonConvert.DeserializeObject<ContatosDTO>(dataItemJson);


            item.Chamar = false;

            FormDetalheContato formDt = new FormDetalheContato(null, item);
            formDt.Show();
        }
    }
}
