using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Outbound.Repository.WebCorreios;

namespace VirtuaConecta.Outbound.Repository.BaseRepo
{
    public interface IcorreioDAL
    {
        EnderecoCepDTO PesquisarCep(String cod);
        EndCepDTO PesquisarCep_(String cod);
        String CalcularPrazoRastreio(String codServico, String cepIn, String cepFim);
        List<EventosCorreiosDTO> ListarEventosCorreio();

        returnObjeto RatrearEncomenda(String codRatreio);

    }
}
