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
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Business;
using VirtuaConecta.Outbound.Business.BaseBis;
using xDialog;

namespace VirtuaConecta.Outbound.AI.Pagamento
{
    public partial class Form_CadastrarFormaPagamento : MaterialForm
    {
        private Imeiopagto _forma;
        public Form_CadastrarFormaPagamento()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);

            this.Font = new Font("Arial", 10);

            dgForma= dg.GetDgStyle(dgForma, 10, 9);
            _forma = Factory.CriaMeioPagtoBLL();
        }
        FormaPagtoDTO forma = new FormaPagtoDTO();
        private void Form_CadastrarFormaPagamento_Load(object sender, EventArgs e)
        {
            Atualizar(null);
            getStyle();
        }

        private void Limpar()
        {
            txtForma.Text = null;
            txtGrupo.Text = null;
            forma = new FormaPagtoDTO();
        }

        private void Atualizar(string text)
        {


            var formas = new List<FormaPagtoDTO>();
            var lista = _forma.ListarMeioPagto().Where(x => !String.IsNullOrEmpty(x.Meio_pagto)).ToList();
            if (String.IsNullOrEmpty(text))
                formas = lista;

            else
                formas = lista.Where(x => x.Meio_pagto.ToUpper().Contains(text.ToUpper())).ToList();


            var Source = new BindingSource(formas, null);
            dgForma.DataSource = Source;
            dgForma.Columns[0].Visible = false;
            dgForma.AutoResizeColumns();

        }

        private void getStyle()
        {
            lblForma.ForeColor = Color.Teal;
            lblGrupo.ForeColor = Color.Teal;
            lblPesquisar.ForeColor = Color.Teal;
        }

        private void txtPesquisarForma_TextChanged(object sender, EventArgs e)
        {
            Atualizar(txtPesquisarForma.Text);
        }

        private void dgForma_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpar();
            var dataItemJson = JsonConvert.SerializeObject(dgForma.CurrentRow.DataBoundItem);
            var item = JsonConvert.DeserializeObject<FormaPagtoDTO>(dataItemJson);

            txtForma.Text = item.Meio_pagto;
            txtGrupo.Text = item.Grupo;
            forma.Id = item.Id;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtForma.Text))
            {
                if (!String.IsNullOrEmpty(txtGrupo.Text))
                {
                    forma.Meio_pagto = txtForma.Text;
                    forma.Grupo = txtGrupo.Text;
                    if (forma.Id != 0)
                    {
                        
                        if (_forma.FormaPagtoEditar(forma) == "OK")
                        {
                            MsgBox.Show("Editado com sucesso", "Sucesso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                            Atualizar(null);
                            Limpar();
                        }else
                            MsgBox.Show("Erro na edição", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                    }
                    else
                    {
                        if(_forma.FormaPagtoInserir(forma) == "OK")
                        {
                            MsgBox.Show("Inserido com sucesso", "Sucesso", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                            Limpar();
                            Atualizar(null);
                        }else
                            MsgBox.Show("Erro na inserção", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                    }
                }else
                    MsgBox.Show("Preencha o grupo", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
            }else
                MsgBox.Show("Preencha a forma de pagamento", "Erro", MsgBox.Buttons.OK, MsgBox.Icon.Error);
        }
    }
}
