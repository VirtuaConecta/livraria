using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Repository.BaseRepo
{
    public interface IwsReceitaDAL
    {
        RetornoReceitaWs BuscarInfoReceita(String CNPJ);
    }
}
