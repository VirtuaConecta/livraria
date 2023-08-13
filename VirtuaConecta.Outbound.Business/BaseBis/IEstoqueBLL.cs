using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
    public interface IEstoqueBLL
    {
        NfeEntradaDTO GetNfeEntrada(String Arq);
        String InserirPedidoXml(NfeEntradaDTO xml);
        List<MovEstoqueDTO> ListaMovEstoque(String dtIni, String dtFim);
        String InserirNfEntradaBLL(EntradaProdutoDTO doc);
        List<HeadEntradaProd> ListarNfEntradaBLL(String nr_doc);
    }
}
