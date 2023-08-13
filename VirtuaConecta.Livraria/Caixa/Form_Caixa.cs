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
using VirtuaConecta.Livraria.Model;
using xDialog;
using Microsoft.VisualBasic;
using VirtuaConecta.Outbound.Utility;
using VirtuaConecta.Outbound.Parametros;

namespace VirtuaConecta.Livraria.Caixa
{
    public partial class Form_Caixa : MaterialForm
    {
        IprodutoBLL _produto;
        ImovCaixa _movcaixa;
        Imeiopagto _meioPagto;
        IticketBLL _ticket;
        IcaixaBLL _caixa;
        List<PedidoDTO> NovoPedido;

        Int32 idCaixa;

        TicketDTO ticket;

        DateTime dataOperacao;
        public Form_Caixa(ProdutoDTO produto)
        {

            InitializeComponent();

            _produto = Factory.CriaProdutoBLL();
            _movcaixa = Factory.CriaMovCaixa();
            _meioPagto = Factory.CriaMeioPagtoBLL();
            _ticket = Factory.CriarTicketBLL();
            _caixa = Factory.CriaCaixaBLL();
            dataOperacao = DateTime.Now;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            var fontFamily = "Microsoft Sans Serif";
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ROBOTO_MEDIUM_10 = new Font(fontFamily, 24);
            materialSkinManager.ROBOTO_MEDIUM_11 = new Font(fontFamily, 24);
            materialSkinManager.ROBOTO_MEDIUM_12 = new Font(fontFamily, 24);
            materialSkinManager.ROBOTO_REGULAR_11 = new Font(fontFamily, 24);

            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Teal400, Primary.Cyan900, Primary.Teal200,
                Accent.Teal700, TextShade.WHITE);


            dgCaixa.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12);
            dgCaixa.BorderStyle = BorderStyle.None;
            dgCaixa.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgCaixa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgCaixa.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgCaixa.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgCaixa.BackgroundColor = Color.White;

            dgCaixa.EnableHeadersVisualStyles = false;
            dgCaixa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgCaixa.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 96, 100);
            dgCaixa.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgCaixa.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top);



            dgprodutos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12);
            dgprodutos.BorderStyle = BorderStyle.None;
            dgprodutos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgprodutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgprodutos.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgprodutos.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgprodutos.BackgroundColor = Color.White;

            dgprodutos.EnableHeadersVisualStyles = false;
            dgprodutos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgprodutos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 96, 100);
            dgprodutos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgprodutos.Anchor = (AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top);



            this.Size = new System.Drawing.Size(1895, 1039);












            //Captura o nr do caixa aberto
            idCaixa = _movcaixa.CapturaUltimoCodigo();

             ticket = CapturaTicket();

            NovoPedido = new List<PedidoDTO>();


            if (produto != null)
                AddProduto(produto);
        }


        private void Form_Caixa_Load(object sender, EventArgs e)
        {
            mtxtCodProduto.Focus();

            txtdesconto.Text = "0";
          //  NovoPedido = new List<PedidoDTO>();
            carregaComboMioPagto();

 
        }


        #region Botões Ações


        private void btnPagar_Click(object sender, EventArgs e)
        {

            try
            {

                var vendaValidada = validaTicket();
                // Dados ok enviar para fechar Ticket
                if (vendaValidada)
                {

                    // seo ticket está validado
                    if (ticket != null)
                    {
                        var movimento = CapturaDadosMovimento(idCaixa, ticket.Id);

                        ticket.Cpf_cnpj = Conversoes.LimpaFormato(txtCpf.Text.Trim());


                        if (movimento != null)
                        {
                            if (NovoPedido.Count > 0)
                            {

                                var resposta = _caixa.ExecutaVenda(NovoPedido, ticket, movimento);

                                if (resposta=="OK")
                                {
                                    // Imprimir

                                   var respImp = _ticket.ImprimirTicket(ticket.Id);
                                    if (respImp=="OK")
                                    {
                                        MsgBox.Show("Venda COncluida!","Sucesso!",MsgBox.Buttons.OK,MsgBox.Icon.Info);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MsgBox.Show("Ocorreu um erro ao imprimir!", "Erro de impressão!", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                                    }

                                }
                                else
                                {
                                    MsgBox.Show("Ocorreu um erro na venda!", "Erro de impressão!", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                                }

                            }

                        }

                    }

                }

            }
            catch (Exception ex)
            {

                throw;
            }



        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Eventos

        private void Form_Caixa_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {

                if (mtxtCodProduto.Text.Length >= 10 && mtxtCodProduto.Text.Length <= 13)
                {
                    var produto = _produto.Produto_Listar(mtxtCodProduto.Text);
                    if (produto.Count != 0)
                    {

                        AddProduto(produto[0]);



                    }

                    mtxtCodProduto.Text = null;
                }

            }

            if (e.KeyValue == 27)
            {
                this.Close();
            }

        }

        private void txtdesconto_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtentregue_TextChanged(object sender, EventArgs e)
        {

        }

        private void listforma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listforma.Text != "Dinheiro")
            {
                txtentregue.Text = "0";
                txtentregue.Enabled = false;
                lbltroco.Text = "0";
            }
            else
            {
                txtentregue.Enabled = true;
                AtualizaValor();
            }
        }

        private void lblcompra_TextChanged_1(object sender, EventArgs e)
        {
            AtualizaValor();
        }

        private void txtdesconto_TextChanged_1(object sender, EventArgs e)
        {
            AtualizaValor();
        }
        private void txtentregue_TextChanged_1(object sender, EventArgs e)
        {
            AtualizaValor();
        }
        #endregion

        #region Funcoes
        public void carregaComboMioPagto()
        {
            var listaCombo = _meioPagto.ListarMeioPagto().OrderBy(x => x.Meio_pagto).ToList();
            listforma.DataSource = listaCombo;
            listforma.DisplayMember = "Meio_pagto";
            listforma.ValueMember = "Id";
            listforma.SelectedIndex = -1;
        }

        public void carregaGridCaixa()
        {
           


       
            var fonte = NovoPedido.Select(e => new
            {
                e.DescGrid,
                e.Qtd,
                e.Valor

            }).ToList();
    
                dgCaixa.DataSource = fonte;

            dgCaixa.Columns[0].HeaderText = "Produto";
            dgCaixa.Columns[1].HeaderText = "Qtd";
            dgCaixa.Columns[2].HeaderText = "Valor R$";
            dgCaixa.Columns[0].Width = 280;
            dgCaixa.AutoResizeColumn(1);
            dgCaixa.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void AddProduto(ProdutoDTO produto)
        {
            PedidoDTO itemPedido = new PedidoDTO();

            itemPedido.Id_produto = produto.id;
            itemPedido.Qtd = 1;
            itemPedido.Valor = produto.preco;
            itemPedido.Id_ticket = ticket.Id;
            itemPedido.DescGrid = produto.descricao;
            itemPedido.Data = dataOperacao;


                var pesquisaItem = NovoPedido.Where(x => x.Id_produto == produto.id).FirstOrDefault();

                if (pesquisaItem == null || pesquisaItem.Id_produto == 0)
 
                    {
                    NovoPedido.Add(itemPedido);
                }
                else
                {

                    for (int i = 0; i < NovoPedido.Count; i++)
                    {
                        if (NovoPedido[i].Id_produto == pesquisaItem.Id_produto)
                        {
                            NovoPedido[i].Qtd = NovoPedido[i].Qtd + 1;
                            NovoPedido[i].Valor = NovoPedido[i].Valor + pesquisaItem.Valor;
                        }

                    }

                }

           
            // dgCaixa.Rows.Add(produto.descricao, produto.preco);

            lblcompra.Text = Math.Round(NovoPedido.Sum(x => x.Valor), 2).ToString("N");
            carregaGridCaixa();


            //if (lblcompra.Text.Length > 0)
            //    lblcompra.Text = Math.Round((Convert.ToDecimal(lblcompra.Text) + produto.preco), 2).ToString();

            //else
            //    lblcompra.Text = Math.Round(produto.preco, 2).ToString();
        }

        private void AtualizaValor()
        {
            if (txtdesconto.Text.Length > 0)
                lbltotal.Text = Math.Round((Convert.ToDecimal(lblcompra.Text) * (1 - (Convert.ToDecimal(txtdesconto.Text)) / 100)), 2).ToString("N");

            else
                lbltotal.Text = lblcompra.Text;

            //atualiza o valor do ticket
            ticket.Valor = Convert.ToDecimal(lbltotal.Text);

            if (txtentregue.Text.Length > 0 && listforma.Text == "Dinheiro")
            {
                var valor = Convert.ToDecimal(txtentregue.Text) - Convert.ToDecimal(lbltotal.Text);

                lbltroco.Text = Math.Round(valor, 2).ToString("N");
            }

        }

        private bool validaTicket()
        {

            // Verfica o valor da compra
            if (String.IsNullOrEmpty(lblcompra.Text) || Information.IsNumeric(lblcompra.Text) == false || Convert.ToDecimal(lblcompra.Text) == 0)
            {
                MsgBox.Show("Valor da Compra é Inválido!", "Erro ao efetuar a Compra", MsgBox.Buttons.OK);
                return false;
            }
            else if (dgCaixa.Rows.Count == 0)
            {
                MsgBox.Show("Não existem itens na lista!", "Erro ao efetuar a Compra", MsgBox.Buttons.OK);
                return false;
            }
            else if (Convert.ToDecimal(lbltotal.Text) < 0)
            {
                MsgBox.Show("Total não pode ser negativo !", "Erro ao efetuar a Compra", MsgBox.Buttons.OK);
                return false;
            }
            else if (listforma.SelectedIndex==-1)
            {
                MsgBox.Show("Escolher o meio de pagamento !", "Erro ao efetuar a Compra", MsgBox.Buttons.OK);
                listforma.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtdesconto.Text))
            {
                MsgBox.Show("Desconto Não pode ser nulo!", "Erro ao efetuar a Compra", MsgBox.Buttons.OK);
                txtdesconto.Focus();
                return false;
            }
            else if (Information.IsNumeric(txtdesconto.Text)==false)
            {
                MsgBox.Show("Desconto Tem que ser um número!", "Erro ao efetuar a Compra", MsgBox.Buttons.OK);
                txtdesconto.Focus();
                return false;
            }
            else if (!String.IsNullOrEmpty(lbltroco.Text) && Convert.ToDecimal(lbltroco.Text)<0)
            {
                MsgBox.Show("Necessário informar o valor entregue corretamente!", "Erro ao efetuar a Compra", MsgBox.Buttons.OK);
                lbltroco.Focus();
                return false;
            }

            // Se o campo de cpf cnpj não for nulo validar
            if (!String.IsNullOrEmpty(txtCpf.Text))
            {
                var cpf_cnpj = txtCpf.Text.Replace(".", "").Replace("-", "").Replace("/", "");
                if (Information.IsNumeric(cpf_cnpj))
                {
                    if (cpf_cnpj.Length == 11)
                    {
                        var validaCpf = ValidarCpf_Cnpj.checkCpf(cpf_cnpj);
                        if (!validaCpf)
                        {
                            MsgBox.Show(" Cpf digitado é inválido! !", "Erro ao efetuar a Compra", MsgBox.Buttons.OK);
                            return false;
                        }
                    }
                    else if (cpf_cnpj.Length == 14)
                    {
                        var validaCnpj = ValidarCpf_Cnpj.checkCnpj(cpf_cnpj);
                        if (!validaCnpj)
                        {
                            MsgBox.Show(" Cnpj digitado é inválido! !", "Erro ao efetuar a Compra", MsgBox.Buttons.OK);
                            return false;
                        }
                    }
                    else
                    {
                        MsgBox.Show(" Cpf ou cnpj digitado é inválido! !", "Erro ao efetuar a Compra", MsgBox.Buttons.OK);
                        return false;
                    }
                }
                else
                {
                    MsgBox.Show("Dados do campo Cpf/Cnpj são inválidos !", "Erro ao efetuar a Compra", MsgBox.Buttons.OK);
                    return false;
                }

            }

            return true;
        }

        private TicketDTO CapturaTicket()
        {
            var ticketVenda = new TicketDTO();

            try
            {
                var nrTicket = _ticket.NumeroProximoTicket().Split('|');
                ticketVenda.Cpf_cnpj = txtCpf.Text;
                ticketVenda.Valor = Convert.ToDecimal(lbltotal.Text);
                ticketVenda.Id = Convert.ToInt32(nrTicket[0]);
                ticketVenda.Nr_ticket = Convert.ToInt32(nrTicket[1]);
                ticketVenda.Serie = Convert.ToInt32(nrTicket[2]);
                ticketVenda.Dt_ticket = dataOperacao;
            }
            catch (Exception ex)
            {
                LogEvento.EscreverEvento($"Erro ao Capturar Ticket: {ex.Message}", MessageType.Error);
            }
            return ticketVenda;
        }


        private MovCaixaDTO CapturaDadosMovimento(Int32 id_caixa,Int32 id_ticket)
        {
            var mov = new MovCaixaDTO();
            try
            {
                mov.Id_caixa = id_caixa;
                mov.Id_meio_pagto = Convert.ToInt32(listforma.SelectedValue);
                mov.Id_operador = VarGlobal.Id_usr;
                mov.Id_ticket = id_ticket;
                mov.Desconto = Convert.ToDecimal(txtdesconto.Text);
                mov.Valor = Convert.ToDecimal(lblcompra.Text);
                mov.Valor_final = Convert.ToDecimal(lbltotal.Text);
                mov.Dt_operacao = dataOperacao.ToString("yyyy-MM-dd HH:mm:ss");
            }
            catch (Exception ex)
            {

                var e = ex.Message;
            }



            return mov;
        }

        #endregion

        private void txtPEsquisaProduto_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPEsquisaProduto.Text))
            {
                dgprodutos.DataSource = null;
            }
            else
            {
                carregaGridPEsquisa(txtPEsquisaProduto.Text);
            }
          

        }

        public void carregaGridPEsquisa(String desc)
        {

            var produtosPEsquisados = _produto.Produto_Listar(null).Where(x => x.descricao.ToUpper().Contains(desc.ToUpper())).ToList();


            var fonte = produtosPEsquisados.Select(e => new
            {
                e.id,
                e.descricao,
                e.preco

            }).ToList();

            dgprodutos.DataSource = fonte;

            dgprodutos.Columns[0].HeaderText = "Cod";
            dgprodutos.Columns[1].HeaderText = "Desc";
            dgprodutos.Columns[2].HeaderText = "Valor R$";
            dgprodutos.Columns[0].Width = 40;
            dgprodutos.AutoResizeColumn(1);
            dgprodutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

  

        private void dgprodutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                     //captura o dado da linha
         

                var idsSelect = Convert.ToInt32(dgprodutos.CurrentRow.Cells[0].Value);

                var prod = _produto.Produto_Listar(null).Where(x => x.id == idsSelect).FirstOrDefault();
                AddProduto(prod);
                dgprodutos.DataSource = null;
                txtPEsquisaProduto.Text = null;
            mtxtCodProduto.Focus();
           
        }

    }
}
