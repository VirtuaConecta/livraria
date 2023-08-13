using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Outbound.Repository.WebCorreios;

namespace VirtuaConecta.Outbound.Business.BaseBis
{
   public  interface IcorreioBLL
    {
        EnderecoCepDTO PesquisaCep(String cod);
        EndCepDTO PesquisaCep_(String cod);
        String CalculaPrazoRastreio(String codServico, String cepIn, String cepFim);
        List<EventosCorreiosDTO> ListaEventosCorreio();

        returnObjeto RatreaEncomenda(String codRatreio);
    }
}
