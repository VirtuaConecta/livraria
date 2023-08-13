using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Outbound.Repository;
using VirtuaConecta.Outbound.Repository.WebCorreios;
using VirtuaConecta.Outbound.Utility;

namespace VirtuaConecta.Outbound.Business
{
    public class CorreiosBusiness : BaseBis.IcorreioBLL
    {
        private Repository.BaseRepo.IcorreioDAL _icorreio;
        public CorreiosBusiness()
        {
            _icorreio = Factory.CriarCorreioDAL();
        }

        public string CalculaPrazoRastreio(string codServico, string cepIn, string cepFim)
        {
            return _icorreio.CalcularPrazoRastreio(codServico, cepIn, cepFim);
        }

        public List<EventosCorreiosDTO> ListaEventosCorreio()
        {
            return _icorreio.ListarEventosCorreio();
        }

        /// <summary>
        /// Usa o viacep
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public EnderecoCepDTO PesquisaCep(string cep)
        {
            var ret = new EnderecoCepDTO();
            var cep1 = Conversoes.LimpaFormato(cep);
            if (Information.IsNumeric(cep1) && cep1.Length==8)
            {
                ret = _icorreio.PesquisarCep(cep1);
            }



            return ret;
        }


        /// <summary>
        /// Usa a pesquisa de cep do correio
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public EndCepDTO PesquisaCep_(string cep)
        {
            return _icorreio.PesquisarCep_(cep);
        }

        public returnObjeto RatreaEncomenda(string codRatreio)
        {
            return _icorreio.RatrearEncomenda(codRatreio);
        }
    }
}
