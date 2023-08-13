using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Repository.BaseRepo
{
    public interface IcarteiraDAL
    {
        List<CarteirasDTO> ListarCarteira();
        String EditarCarteira(CarteirasDTO item);
        String InserirCarteira(CarteirasDTO item);
        String ApagarCarteiraPorUsuario(String Usuario);
    }
}
