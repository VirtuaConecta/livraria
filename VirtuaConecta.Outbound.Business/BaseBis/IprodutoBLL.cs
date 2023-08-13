using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
    public interface IprodutoBLL
    {
        List<ProdutoDTO> Produto_Listar(String cod_barra);
        String ProdutoEditar(ProdutoDTO produto);
        String ProdutoInserir(ProdutoDTO produto);
        List<TipoProdutoDTO> ListarTipoProduto();
        String TipoProdutoEditar(TipoProdutoDTO tipo);
        String TipoProdutoInserir(TipoProdutoDTO tipo);
    }
}
