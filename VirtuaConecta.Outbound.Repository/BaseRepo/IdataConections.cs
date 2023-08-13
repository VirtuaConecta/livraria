using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;

namespace VirtuaConecta.Outbound.Repository.BaseRepo
{
    public interface IdataConections
    {

        #region Estoque
        String InserirNfEntrada(EntradaProdutoDTO doc);

        List<HeadEntradaProd> ListarNfEntrada(String nr_doc);
        List<MovEstoqueDTO> ListMovEstoque(String dtIni, String DtFim);
        #endregion

        #region Usuarios

        List<UsuariosDTO> ListarUsuarios();
        String InserirUsuarios(UsuariosDTO item);
        String AtualizarUsuarios(UsuariosDTO item);

        #endregion

        #region Produto
        List<ProdutoDTO> ProdutoListar(String cod_barra);
        List<TipoProdutoDTO> ListarTipoProduto();
        String ProdutoInserir(ProdutoDTO produto);
        String ProdutoEditar(ProdutoDTO produto);
        String TipoProdutoInserir(TipoProdutoDTO tipo);
        String TipoProdutoEditar(TipoProdutoDTO tipo);
        #endregion

        #region Caixa
        List<CaixaDTO> ListarCaixa();

        String InsereCaixa(CaixaDTO caixa);
        String InsereVenda(List<PedidoDTO> Pedido, TicketDTO ticket, MovCaixaDTO Movimento);

        List<MovCaixaDTO> ListarMovCaixa();

        #endregion

        #region Ticket
        List<TicketDTO> ListarTicket();
        String InsereTicket(TicketDTO ticket);
        #endregion

        #region Pedidos
        List<PedidoDTO> ListarPedido();
        String InserePedido(PedidoDTO pedido);
        #endregion

        #region Cliente
        List<ClienteDTO> ClienteListar();
        String ClienteInserir(ClienteDTO cliente);
        String ClienteEditar(ClienteDTO cliente);

        List<ClienteHistoricoDTO> ClienteHistoricoListar();
        #endregion

        #region Fornecedor
        String FornecedorInserir(FornecedorDTO forn);
        List<FornecedorDTO> FornecedorListar();
        String FornecedorEditar(FornecedorDTO forn);

        #endregion

        #region Meio Pagto
        List<FormaPagtoDTO> ListarFormaPagto();
        String FormaPagtoInserir(FormaPagtoDTO forma);
        String FormaPagtoEditar(FormaPagtoDTO forma);
        #endregion

        #region fechamento
        List<ResumoFechamentoDTO> ListarMovFecha(String dtIni, String dtFim);
        #endregion

        #region Estado
        List<EstadosDTO> ListarEstados(String cod);
        #endregion

        #region Dash board
        List<DashDTO> Db_venda_produto(String dt_in, String dt_fim, String ordem);
        List<DashDTO> Db_venda_familiaValor(String dt_in, String dt_fim);
        List<DashDTO> Db_venda_MeioValor(String dt_in, String dt_fim);

        #endregion
    }
}
