using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;
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
using xDialog;

namespace VirtuaConecta.Outbound.AI.Configuracoes
{
    public partial class Form_Imprimir : MaterialForm
    {
        String _id_ticket;
        IticketBLL _ticket;
        public Form_Imprimir(String id_ticket)
        {
            InitializeComponent();
            _ticket = Factory.CriarTicketBLL();

           _id_ticket = id_ticket;


            if (!String.IsNullOrWhiteSpace(_id_ticket))
            {
                TxtNrTicket.Text = _id_ticket;
            }

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Information.IsNumeric(TxtNrTicket.Text))
                {
                    var nrTicket = Convert.ToInt32(TxtNrTicket.Text);

                    var tiketpesquisado = _ticket.ListaTickets().Where(x => x.Nr_ticket == nrTicket).FirstOrDefault();
                    if (tiketpesquisado != null)
                    {
                        var resp = _ticket.ImprimirTicket(tiketpesquisado.Id);
                       //var resp = _ticket.ImprimirTicketMP4200(tiketpesquisado.Id);
                    }
                    else
                    {
                        MsgBox.Show("Ticket não encontrado", "Erro Impressora", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                    }
                }


            }
            catch (Exception)
            {

                MsgBox.Show("Houve um erro ao tentar imprimir", "Erro Impressora",MsgBox.Buttons.OK,MsgBox.Icon.Error);
            }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
