using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Outbound.Parametros;
using VirtuaConecta.Outbound.Repository.WebCorreios;
using VirtuaConecta.Outbound.Utility;

namespace VirtuaConecta.Outbound.Repository
{
    public class CorreiosRepository :Conexao_Mysql, BaseRepo.IcorreioDAL
    {



        public EndCepDTO PesquisarCep_(String cod)
        {
            //pesquisa direto no correio
            var endereco = new EndCepDTO();
            try
            {

                var ws = new WsCorreios.AtendeClienteClient();
                var resposta = ws.consultaCEP(cod);

                if (resposta != null)
                {
                    endereco.Endereco = resposta.end;
                    endereco.Bairro = resposta.bairro;
                    endereco.Cidade = resposta.cidade;
                    endereco.Uf = resposta.uf;
                    endereco.Complemento2 = resposta.complemento2;
                    endereco.Und_post = resposta.unidadesPostagem;

                }


            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro em PesquisarCep_: " + ex.Message.ToString(), MessageType.Error);
            }

            return endereco;
        }

        public String CalcularPrazoRastreio(String codServico, String cepIn, String cepFim)
        {
            String retorno = null;
            try
            {

                var ws = new WsCalculaValorPrazoCorreio.CalcPrecoPrazoWSSoapClient();
                var resposta = ws.CalcPrazo(codServico, cepIn, cepFim);

                var dadosRetorno = resposta.Servicos.FirstOrDefault();

                if (dadosRetorno != null)
                {
                    retorno = dadosRetorno.DataMaxEntrega + ";" + dadosRetorno.HoraMaxEntrega + ";" + dadosRetorno.EntregaSabado + ";" + dadosRetorno.PrazoEntrega;
                }



            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro em CalculaPrazoRastreio: " + ex.Message.ToString(), MessageType.Error);
            }

            return retorno;
        }

        private String EnderecoURL = Parametros.Parametros.UrlViaCep();

        public EnderecoCepDTO PesquisarCep(string cep)
        {
            //Pesquisa no viacep

            var end = new EnderecoCepDTO();
            try
            {
                string NovoEnderecoURL = string.Format(EnderecoURL, cep);
                WebClient wc = new WebClient();
                string conteudo = wc.DownloadString(NovoEnderecoURL);
                end = JsonConvert.DeserializeObject<EnderecoCepDTO>(conteudo);

            }
            catch (Exception ex)
            {


                LogEvento.EscreverEvento("Erro em PesquisarCep: " + ex.Message.ToString(), MessageType.Error);
            }
            if (end.cep == null) return null;
            return end;
        }


        public returnObjeto  RatrearEncomenda(String codRatreio)
        {

            var resp = new RetornoCorreioSoapDTO();

            var objetoRastreado = new returnObjeto();

            String Usuario = "4373041500";
            String Senha = "G:EGJCE2=J";
            String Tipo = "L"; //Lista de objetos
            String Resultado = "T"; //Retorna todos eventos
            String Lingua = "101"; //portugues
            String ObjetoNr = codRatreio.ToUpper();
            var cliente = new WebCorreios.ServiceClient();

           // var objReq = new WebCorreios.buscaEventosRequest();

           // var objReq1 = new WebCorreios.buscaEventosListaRequest();
          var requestInterceptor = new InspectorBehavior();
            cliente.Endpoint.Behaviors.Add(requestInterceptor);
            //String[] obj;
            //obj = new string[1];
            //obj[0] = codRatreio;

            var respObj=   cliente.buscaEventos(Usuario, Senha, Tipo, Resultado, Lingua, ObjetoNr);
            try
            {

                var ser = new XmlSerializer(typeof(Envelope));
                var envelope = new Envelope();
                using (TextReader reader = new StringReader(requestInterceptor.LastResponseXML))
                {
                    envelope = (Envelope)ser.Deserialize(reader);
                }

                // Cria objeto para receber as informações
               objetoRastreado = envelope.Body.buscaEventosResponse.@return.objeto;

               // resp.qtd = objetoRastreado.numero




            }
            catch (Exception ex)
            {
                var t = ex.Message;
            }

            return objetoRastreado;
        }


        public List<TipoEventoCorreioDTO> ListarTipoEventoCorreio()
        {
            var lista = new List<TipoEventoCorreioDTO>();

            lista.Add(new TipoEventoCorreioDTO() {tipo = "BDE", significado = "Baixa de distribuição externa" });
            lista.Add(new TipoEventoCorreioDTO() { tipo = "BDI", significado = "Baixa de distribuição interna" });
            lista.Add(new TipoEventoCorreioDTO() { tipo = "BDR", significado = "Baixa de distribuição retroativa" });
            lista.Add(new TipoEventoCorreioDTO() { tipo = "BLQ", significado = "Bloqueio de objetos" });
            lista.Add(new TipoEventoCorreioDTO() { tipo = "PAR", significado = "Conferência Unidade Internacional" });
            lista.Add(new TipoEventoCorreioDTO() { tipo = "EST", significado = "Estorno" });
            lista.Add(new TipoEventoCorreioDTO() { tipo = "RO", significado = "Expedição de Lista de Registro" });
            lista.Add(new TipoEventoCorreioDTO() { tipo = "DO", significado = "Expedição de nota de despacho" });
            lista.Add(new TipoEventoCorreioDTO() { tipo = "FC", significado = "Função complementar" });
            lista.Add(new TipoEventoCorreioDTO() { tipo = "LDE", significado = "Lista de distribuição externa" });
            lista.Add(new TipoEventoCorreioDTO() { tipo = "LDI", significado = "Lista de distribuição interna" });
            lista.Add(new TipoEventoCorreioDTO() { tipo = "OEC", significado = "Lista de Objetos Entregues ao Carteiro" });
            lista.Add(new TipoEventoCorreioDTO() { tipo = "PO", significado = "Postagem" });



            return lista;



        }


        public List<EventosCorreiosDTO> ListarEventosCorreio()
        {
            var lista = new List<EventosCorreiosDTO>();


            try
            {
                AbrirConexao();


                String Str = "SELECT ";
                Str += " `lista_eventos`.`Id`,";
                Str += " `lista_eventos`.`tipo`,";
                Str += " lista_tipo_evento.significado,";
                Str += " `lista_eventos`.`COD`,";
                Str += "  `lista_eventos`.`DESCRICAO`,";
                Str += " `lista_eventos`.`DETALHE` ";
                Str += " FROM `virtua_tlmk`.`lista_eventos` join lista_tipo_evento on lista_eventos.TIPO = lista_tipo_evento.tipo";

                using (Cmd = new MySqlCommand(Str, Con))
                {


                    Dr = Cmd.ExecuteReader();


                    while (Dr.Read())
                    {
                        var item_lista = new EventosCorreiosDTO();

                        item_lista.id = Convert.ToInt32(Dr["id"]);
                        item_lista.tipo = Convert.ToString(Dr["tipo"]);
                        item_lista.significado = Convert.ToString(Dr["significado"]);
                        item_lista.Status = Convert.ToInt32(Dr["COD"]);
                        item_lista.descricao = Convert.ToString(Dr["DESCRICAO"]);
                        item_lista.detalhe = Convert.ToString(Dr["DETALHE"]);


                        //Adiciona na lista
                        lista.Add(item_lista);
                    }
                }
            }
            catch (Exception ex)
            {


                LogEvento.EscreverEvento("Erro em ListarEventosCorreio repository: " + ex.Message.ToString(), MessageType.Error);

            }
            finally
            {
                FecharConexao();
            }

            return lista;






        }
    }
}
