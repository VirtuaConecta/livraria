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
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Business;
using xDialog;

namespace VirtuaConecta.Outbound.AI.Caixa
{
    public partial class Form_mov_caixa : MaterialForm
    {
        private Business.BaseBis.ImovCaixa _movCaixaBLL;
        private Business.BaseBis.IusuarioBll _iUsuarios;
        String ItemDescricao = "";
        Int32 ItemIndex = 0;
        Int32 UltimoCodigo;

        MainForm _form;
        ToolTip toolTip1 = new ToolTip();
        public Form_mov_caixa(MainForm form)
        {
            InitializeComponent();
            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);

            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal400, Primary.Cyan900, Primary.Teal200, Accent.Teal700, TextShade.WHITE);

            _movCaixaBLL = Factory.CriaMovCaixa();
            _iUsuarios = Factory.CriaUsuarioBLL();

            _form = form;
        }

        #region Botoes
        private void btnImprimirFechamento_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            confirmar_Click();
        }

   
        private void Form_mov_caixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }

            if (e.KeyValue.Equals(13)) //Enter
            {
                this.confirmar_Click();

            }
        }

        #endregion
        private void Form_mov_caixa_Load(object sender, EventArgs e)
        {
            materialLabel1.ForeColor = Color.Teal;
            materialLabel1.Font = new Font(materialLabel1.Font, FontStyle.Bold);
            materialLabel2.ForeColor = Color.Teal;
            materialLabel2.Font = new Font(materialLabel2.Font, FontStyle.Bold);
            materialLabel3.ForeColor = Color.Teal;
            materialLabel3.Font = new Font(materialLabel3.Font, FontStyle.Bold);
            materialLabel4.ForeColor = Color.Teal;
            materialLabel4.Font = new Font(materialLabel4.Font, FontStyle.Bold);
            materialLabel5.ForeColor = Color.Teal;
            materialLabel5.Font = new Font(materialLabel5.Font, FontStyle.Bold);
            materialLabel6.ForeColor = Color.Teal;
            materialLabel6.Font = new Font(materialLabel6.Font, FontStyle.Bold);
            materialLabel7.ForeColor = Color.Teal;
            materialLabel7.Font = new Font(materialLabel7.Font, FontStyle.Bold);

            materialLabel8.ForeColor = Color.Teal;
            materialLabel8.Font = new Font(materialLabel8.Font, FontStyle.Bold);

            materialLabel9.ForeColor = Color.Teal;
            materialLabel9.Font = new Font(materialLabel9.Font, FontStyle.Bold);

            lblEntradas.ForeColor = Color.Teal;
            lblSaidas.ForeColor = Color.Teal;
            lblSaldo.ForeColor = Color.Teal;
            lblStatusCaixa.ForeColor = Color.Teal;
            lblUsuario.ForeColor = Color.Teal;
            lblUsuario.Text = VarGlobal.LoginName;
            lblNrOperacao.ForeColor = Color.Teal;
            lblTerminal.ForeColor = Color.Teal;
            lblTerminal.Text = Parametros.Parametros.NrTerminal();

            cmbOperacoes.Font = new Font("Arial", 12);
            this.autoriza();

            #region configuracoes dg_caixa
            dg_caixa.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
           if(dg_caixa.RowCount>0)
            dg_caixa.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          //  dg_caixa.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
            dg_caixa = dg.GetDgStyle(dg_caixa,10,9);

            #endregion

            #region Configurações dg_movCaixa

             dg_MovCaixa.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //   dg_caixa.AutoResizeColumn(3);
          
          //  dg_MovCaixa.DefaultCellStyle.Font = new Font("Arial", 9);
            dg_MovCaixa.DefaultCellStyle.Format = "N2";
            dg_MovCaixa = dg.GetDgStyle(dg_MovCaixa,10,9);
            if(dg_MovCaixa.RowCount>0)
            dg_MovCaixa.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            #endregion
        }


        #region funções

        private void confirmar_Click()
        {
            // verifica o status atual
            var StatusMovCaixa = _movCaixaBLL.StatusMovCaixa();
            var x = cmbOperacoes.SelectedItem;
            if (x == null)
            {
                ItemIndex = 0;
                ItemDescricao = "";
            }
            else
            {
                ItemIndex = Int32.Parse(x.ToString().Substring(0, 1));
                ItemDescricao = x.ToString().Substring(2).Trim();
            }
            switch (ItemIndex)
            {
                //Abertura 
                case 1:
                    //Verifica se o caixa está fechado antes de abrir
                    if (StatusMovCaixa == 3)
                    {
                        //Confirma o valor com o qual o caixa será aberto
                        if (MessageBox.Show("Deseja Abrir o Caixa Com R$ " + txtTotalOp.Text, "Aviso:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            _movCaixaBLL.AlteraStatusCaixa(ItemIndex, ItemDescricao, txtTotalOp.Text);
                            this.AtualizaTela();
                        }
                        else
                        {
                            cmbOperacoes.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O Caixa NÃO ESTÁ FECHADO.", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        cmbOperacoes.Focus();
                    }
                    break;


                //Sagria
                case 2:
                    //Verifica se o caixa está Aberto antes Sangria
                    if (StatusMovCaixa != 3)
                    {
                        _movCaixaBLL.AlteraStatusCaixa(ItemIndex, ItemDescricao, txtTotalOp.Text);
                        this.AtualizaTela();

                    }
                    else
                    {
                        MessageBox.Show("O Caixa ESTÁ FECHADO.", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        cmbOperacoes.Focus();
                    }

                    break;

                //Fechamento
                case 3:
                    //Verifica se o caixa Já está fechado
                    if (StatusMovCaixa != 3)
                    {
                        _movCaixaBLL.AlteraStatusCaixa(ItemIndex, ItemDescricao, txtTotalOp.Text);


                    }
                    else
                    {
                        MessageBox.Show("O Caixa JÁ ESTÁ FECHADO.", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        cmbOperacoes.Focus();
                    }

                    break;

                //Reforço
                case 4:
                    //Verifica se o caixa  está Aberto
                    if (StatusMovCaixa != 3)
                    {
                        _movCaixaBLL.AlteraStatusCaixa(ItemIndex, ItemDescricao, txtTotalOp.Text);
                        this.AtualizaTela();

                    }
                    else
                    {
                        MessageBox.Show("O Caixa ESTÁ FECHADO.", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        cmbOperacoes.Focus();
                    }

                    break;

                default:
                    MessageBox.Show("Escolher uma Opção Válida", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    cmbOperacoes.Focus();
                    break;

            }

            //zero o valor da operação
            txtTotalOp.Text = "";
            //Atualiza dados no grid
            this.carregaGrids();
            //Atualisa o Status na tela
            this.AtualizaStatusCaixa();
        }
        private void AtualizaTela()
        {
            try
            {

                UltimoCodigo = _movCaixaBLL.CapturaUltimoCodigo();

            }
            catch (Exception ex)
            {
                var e = ex.Message; 
                UltimoCodigo = 0;
            }


            this.carregaGrids();
            this.AtualizaStatusCaixa();
            this.posicaoAtual();
        }
        private void AtualizaStatusCaixa()
        {
            var StatusMovCaixa = _movCaixaBLL.StatusMovCaixa();

            if (StatusMovCaixa == 3)
            {
                lblStatusCaixa.ForeColor = System.Drawing.Color.Red;
                lblStatusCaixa.Text = "Caixa Encerrado";

                btnImprimirFechamento.Enabled = true;

            }
            else
            {
                lblStatusCaixa.ForeColor = System.Drawing.Color.Blue;
                lblStatusCaixa.Text = "Caixa Aberto";
                btnImprimirFechamento.Enabled = false;

            }

            _form.CarregaImagemCentral();
        }
        public void posicaoAtual()
        {
            var saidas = _movCaixaBLL.ListarCaixa().Where(c => c.Nr_caixa == UltimoCodigo).Where(y => y.Cod_Operacao == 2).Sum(z => z.Valor);
            var Reforco = _movCaixaBLL.ListarCaixa().Where(c => c.Nr_caixa == UltimoCodigo).Where(y => y.Cod_Operacao != 2).Sum(z => z.Valor);

            var Entradas = _movCaixaBLL.ListarMovCaixa().Where(x => x.Id_caixa == UltimoCodigo).Sum(v => v.Valor);

            lblEntradas.Text = String.Format("{0:0.00}", Entradas);
            lblSaidas.Text = String.Format("{0:0.00}", saidas);
            lblSaldo.Text = String.Format("{0:0.00}", Reforco + Entradas - saidas);
        }
        public void carregaGrids()
        {
            listadgCaixa();
           listarDgMovCaixa();
        }
        private void listadgCaixa()
        {
            //Captura a ultima sesssão aberta


            var novaListMovCaixa = _movCaixaBLL.ListarCaixa().Where(c => c.Nr_caixa == UltimoCodigo).Select(Caixa => new
            {
                Terminal = Caixa.Terminal,
                Caixa = Caixa.Nr_caixa,
                Data = Caixa.Dt_Hr_operacao,
                Operador = Caixa.Nome_Usr,
                Operação = Caixa.Nome_operacao,
                Valor = Caixa.Valor
               

            }).ToList().Where(y => y.Terminal == Parametros.Parametros.NrTerminal()).OrderBy(x => x.Data);

            var Source = new BindingSource(novaListMovCaixa, null);
            dg_caixa.DataSource = Source;
            //dg_caixa.AutoResizeColumn(2);




        }
        private void listarDgMovCaixa()
        {
            var novaListHitMov = _movCaixaBLL.ListarMovCaixa().Where(x => x.Id_caixa == UltimoCodigo).Select(MovCaixa => new
            {
                Ticket = MovCaixa.Nr_ticket,
                Data = MovCaixa.Dt_operacao,
                Operador = MovCaixa.Nome_operador,
                Meio_Pagto = MovCaixa.Meio_pagto,
                Valor = MovCaixa.Valor,
                Desconto = MovCaixa.Desconto,
                Cnpj_Cpf = MovCaixa.Cpf_cnpj,
              



            }).ToList().OrderByDescending(x => Convert.ToDateTime(x.Data));

            var Source = new BindingSource(novaListHitMov, null);
            dg_MovCaixa.DataSource = Source;


        }

        #endregion

        #region Eventos
        private void autoriza()
        {
            var usuario = _iUsuarios.ListaUsuarios().Where(x=>x.Id== VarGlobal.Id_usr).FirstOrDefault();


            if (usuario.IdPerfil > 2)
            {
                MsgBox.Show("Necessário login e senha validos", "Erro ao logar", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);

                    this.Close();
            }
            else
            {
                this.AtualizaTela();

                lblNrOperacao.Text = UltimoCodigo.ToString();
            }

        }
  
        private void btnConfirmar_MouseHover(object sender, EventArgs e)
        {
           

            toolTip1.SetToolTip(sender as Control, "Concluir Operação");
            toolTip1.IsBalloon = true;
        }

        private void btnImprimirFechamento_MouseHover(object sender, EventArgs e)
        {

            toolTip1.SetToolTip(sender as Control, "Imprimir Caixa");
            toolTip1.IsBalloon = true;
        }

        private void btnSair_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(sender as Control, "Sair");
            toolTip1.IsBalloon = true;
        }
        #endregion
    }
}
