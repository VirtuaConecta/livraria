using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;

namespace VirtuaConecta.Outbound.Repository
{
    public class FeriadosRepository : BaseRepo.IferiadoDAL
    {
        //27b7b6b1-0e86-469f-b68d-732cfdc052af
        //https://holidayapi.com/v1/holidays?pretty&key=27b7b6b1-0e86-469f-b68d-732cfdc052af&country=BR&year=2018

        /// <summary>
        /// Captura a lista de feriados de uma dada cidade
        /// </summary>
        /// <param name="ano"></param>
        /// <param name="Estado"></param>
        /// <param name="Cidade"></param>
        /// <param name="codMun"></param>
        /// <returns></returns>
        public List<FeriadoDTO> PesquisarFeriados(Int32 ano, String Estado, String Cidade, Int32? codMun)
        {
            var lista_feriado = new List<FeriadoDTO>();

            var Url = "";
            try
            {
                if (ano>0)
                {
                    if (codMun == null)
                    {
                        Url = String.Format(Parametros.Parametros.UrlFeriado(), ano, Estado, Cidade);
                    }
                    else
                    {
                        Url = String.Format(Parametros.Parametros.UrlFeriadoCodMun(), ano, codMun);
                    }
                    var client = new RestClient(Url);
                    var request = new RestRequest(Method.GET);
                    request.AddHeader("cache-control", "no-cache");
                    request.AddHeader("Connection", "keep-alive");
                    request.AddHeader("Accept-Encoding", "gzip, deflate");
                    request.AddHeader("Host", "api.calendario.com.br");
                    request.AddHeader("Cache-Control", "no-cache");
                    request.AddHeader("Accept", "*/*");
                    IRestResponse response = client.Execute(request);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {

                        lista_feriado = JsonConvert.DeserializeObject<List<FeriadoDTO>>(response.Content);

                    } 
                }
            }
            catch (Exception)
            {

                //  throw;
            }


            return lista_feriado;
        }


    }
}
