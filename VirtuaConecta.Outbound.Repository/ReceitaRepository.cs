using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Outbound.Utility;
using VirtuaConecta.Outbound.Parametros;

namespace VirtuaConecta.Outbound.Repository
{
    public class ReceitaRepository: BaseRepo.IwsReceitaDAL
    {
        public RetornoReceitaWs BuscarInfoReceita(String CNPJ)
        {
                    var dados = new RetornoReceitaWs();

            try
            {
                var client = new RestClient("https://www.receitaws.com.br/v1/cnpj/" + CNPJ);
                var request = new RestRequest(Method.GET);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("Connection", "keep-alive");
                request.AddHeader("Cookie", "JSESSIONID=ed179333b826d9026424e4b7dd183e4d36c2892d");
                request.AddHeader("Accept-Encoding", "gzip, deflate");
                request.AddHeader("Host", "www.receitaws.com.br");
                request.AddHeader("Cache-Control", "no-cache");
                request.AddHeader("Accept", "*/*");
                IRestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var dadosJson = response.Content;
                    if (dadosJson != null)
                    {
                        dados = JsonConvert.DeserializeObject<RetornoReceitaWs>(dadosJson);
                    }



                }
            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro GetInfoReceita repository: " + ex.Message.ToString(), MessageType.Error);
            }

            return dados;
        }
    }
}
