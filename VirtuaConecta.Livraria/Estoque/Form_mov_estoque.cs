using MaterialSkin;
using MaterialSkin.Controls;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
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
using VirtuaConecta.Livraria.Model;
using Newtonsoft.Json;
using VirtuaConecta.Outbound.Utility;
using VirtuaConecta.Outbound.Parametros;

namespace VirtuaConecta.Outbound.AI.Estoque
{
    public partial class Form_mov_estoque : MaterialForm
    {
        Business.BaseBis.IEstoqueBLL _estoque;
        public Form_mov_estoque()
        {
            InitializeComponent();
            _estoque = Factory.CriaEstoqueBll();
              MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);

            this.Font = new Font("Arial", 11);
            dgMovEstoque = dg.GetDgStyle(dgMovEstoque, 10, 9);

        }

        private void Form_mov_estoque_Load(object sender, EventArgs e)
        {
            dtPickerIni.Value =DateTime.Now.AddDays(-30);
            dtPickerFim.Value = DateTime.Now;
            CarregaDataGrid(null);
        }

        private void CarregaDataGrid(String txtPesquisa)
        {
            var lista = new List<MovEstoqueDTO>();
            try
            {
                if (String.IsNullOrEmpty(txtPesquisa))
                {
                    lista = _estoque.ListaMovEstoque(dtPickerIni.Text, dtPickerFim.Text);
                }
                else
                {
                    lista = _estoque
                        .ListaMovEstoque(dtPickerIni.Text, dtPickerFim.Text)
                       .Where(x => x.Descricao.ToUpper().Contains(txtPesquisa.ToUpper()))
                       .ToList();
                }

                var Source = new BindingSource(lista, null);
                dgMovEstoque.DataSource = Source;
                dgMovEstoque.Columns[0].Width = 40;
                dgMovEstoque.Columns[1].Width = 40;
                dgMovEstoque.Columns[2].Width = 60;

                dgMovEstoque.Columns[0].HeaderText = "Doc";
                dgMovEstoque.Columns[1].HeaderText = "E/S";
                dgMovEstoque.Columns[3].HeaderText = "Data";
                dgMovEstoque.Columns[6].HeaderText = "Entrada";
                dgMovEstoque.Columns[7].HeaderText = "Saída";

                dgMovEstoque.AutoResizeColumn(0);
                dgMovEstoque.AutoResizeColumn(3);
                dgMovEstoque.AutoResizeColumn(4);
                dgMovEstoque.AutoResizeColumn(5);


                dgMovEstoque.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento($"Erro ao carregar lista de Estoque {ex.Message}", MessageType.Error);
            }


        }
        #region Eventos
        private void dtPickerIni_ValueChanged(object sender, EventArgs e)
        {
            CarregaDataGrid(txtPesquisarProduto.Text);
        }

        private void dtPickerFim_ValueChanged(object sender, EventArgs e)
        {
            CarregaDataGrid(txtPesquisarProduto.Text);
        } 
        private void txtPesquisarProduto_TextChanged(object sender, EventArgs e)
        {
            CarregaDataGrid(txtPesquisarProduto.Text);
        }

        #endregion

        private void btnGerarReport_Click(object sender, EventArgs e)
        {
          

            var dataItemJson = JsonConvert.SerializeObject(dgMovEstoque.DataSource);
            var listaRep = JsonConvert.DeserializeObject<List<MovEstoqueDTO>>(dataItemJson);



            Relatorios.Form_rel_mov_estoque formMov = new Relatorios.Form_rel_mov_estoque(listaRep);
            formMov.Show();
        }
    }
}
