using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
   public  interface Ifornecedor
    {
        bool ExisteFornecedor(String cpf_cnpj);
        String InserirFornecedor(FornecedorDTO forn);
        String EditarFornecedor(FornecedorDTO forn);
        String ValidaFornecedor(FornecedorDTO forn);
        List<FornecedorDTO> ListarFornecedor();
    }
}
