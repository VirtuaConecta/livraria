using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Business.BaseBis;
using VirtuaConecta.Livraria.Model;

namespace VirtuaConecta.Outbound.Business
{
    public class ProdutoBusiness: IprodutoBLL
    {
        Repository.BaseRepo.IdataConections _produto;

        public ProdutoBusiness()
        {
            _produto = Factory.CriaConexao();
        }

        public List<ProdutoDTO> Produto_Listar(String cod_barra)
        {
            return _produto.ProdutoListar(cod_barra);
        }
        public String ProdutoEditar(ProdutoDTO produto)
        {
            return _produto.ProdutoEditar(produto);
        }
       
       public String ProdutoInserir(ProdutoDTO produto)
        {
            return _produto.ProdutoInserir(produto);
        }

        public List<TipoProdutoDTO> ListarTipoProduto()
        {

            var ret = _produto.ListarTipoProduto();

            return ret;
        }

        public string TipoProdutoEditar(TipoProdutoDTO tipo)
        {
            return _produto.TipoProdutoEditar(tipo);
        }

        public string TipoProdutoInserir(TipoProdutoDTO tipo)
        {
            return _produto.TipoProdutoInserir(tipo);
        }
    }
}
