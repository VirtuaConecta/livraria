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
using VirtuaConecta.Outbound.Utility;
using xDialog;

namespace VirtuaConecta.Outbound.AI.Configuracoes
{
    public partial class Form_Detalhe_Filtro : MaterialForm
    {
        private Form_Filtros _form;
        FiltrosDTO _item = new FiltrosDTO();
        private Business.BaseBis.IfiltroBLL _ifiltro;
        public Form_Detalhe_Filtro(Form_Filtros form , FiltrosDTO item)
        {
            InitializeComponent();

            _form = form;
            _item = item;
            _ifiltro = Factory.CriarFiltroBLL();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);
        }

        private void Form_Detalhe_Filtro_Load(object sender, EventArgs e)
        {
            
            if (_item.Id >0)
            {
                bntnexecutar.Text ="Editar";

                txtIdFiltro.Text = _item.Id.ToString();
                TxtNomeFiltro.Text = _item.Descricao;
                txtSql.Text = _item.Sql;

             
            }
            else
            {
                bntnexecutar.Text = "Novo";

            }




        }

        private void Form_Detalhe_Filtro_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form.CarregaGrid(null);
        }

        private void bntnexecutar_Click(object sender, EventArgs e)
        {
            var item = CapaturaTela();

            var itemValidado = FiltrosConsultaBusiness.ValidarFIltro(item);


            if (itemValidado=="OK")
            {
                if (bntnexecutar.Text == "Editar")
                {
                    var respEditar = _ifiltro.EditaFiltro(item);

                    if (respEditar=="OK")
                    {
                        MsgBox.Show("Item Editado","Sucesso", MsgBox.Buttons.OK, MsgBox.Icon.Info);

                        this.Close();

                    }
                    else
                    {
                        MsgBox.Show("Erro ao Editar","Falha", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                    }
                }
                else
                {

                    var respInsere = _ifiltro.InsereFiltro(item);

                    if (respInsere == "OK")
                    {
                        MsgBox.Show("Item Inserido", "Sucesso", MsgBox.Buttons.OK, MsgBox.Icon.Info);

                        this.Close();

                    }
                    else
                    {
                        MsgBox.Show("Erro ao Inserir", "Falha", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                    }

                }

            }
            else
            {
                MsgBox.Show(itemValidado, "Erro ao Executar", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }



        }


        private FiltrosDTO CapaturaTela()
        {
            var item = new FiltrosDTO();
            if (bntnexecutar.Text == "Editar")
               item.Id = Convert.ToInt32(Conversoes.Nz(txtIdFiltro.Text,"0"));
            item.Descricao = TxtNomeFiltro.Text;
            item.Sql = txtSql.Text;

            return item;
        }
    }
}
