using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Outbound.Parametros;
using VirtuaConecta.Outbound.Utility;
using System.Data;
using Newtonsoft.Json;

namespace VirtuaConecta.Outbound.Business
{
    public class ContatosBLL : BaseBis.IcontatoBLL
    {
        private Repository.BaseRepo.IcontatoDAL _icontato;
        private Business.BaseBis.IferiadosBLL _iferiado;
        private Repository.BaseRepo.IcontatoInformix _iInformix;

        public ContatosBLL()
        {
            _icontato = Factory.CriarContatosDAL();
            _iferiado = Factory.CriaFeriadoBLL();
            _iInformix = Factory.CriarConatoInfomixDAL();
        }

        public string AtualizaContato(ContatosDTO item)
        {
            var filtro = " Where id_cliente ='" + item.Id_cliente + "'";
            var itemExistente = ListaContatos(filtro);

            if (itemExistente.Count > 0)
            {
                return _icontato.AtualizarContato(item);
            }
            else
            {
                var itemBulk = new List<ContatosDTO>();
                item.Data_contato = DateTime.Now;
                return InsereContatosUnit(item);
            }


        }

        public string InsereHistorico(HistoricoDTO item)
        {
            return _icontato.InserirHistorico(item);
        }

        public List<ContatosDTO> ListaContatos(String filtro)
        {
            return _icontato.ListarContatos(filtro);
        }

        public List<StatusContatoDTO> ListaStatusContatos()
        {
            return _icontato.ListarStatusContatos();
        }

        public DataRetorno DataProxContato(DateTime DtEntrega, String CodMun)
        {
            var dt = DtEntrega.Date;
            var DataRetorno = new DataRetorno();

            try
            {
                //Valida se houve feriado
                if (Information.IsNumeric(CodMun))
                {
                    var ibge = Convert.ToInt32(CodMun);
                    var data_feriado = _iferiado.PesquisaFeriados(dt.Year, null, null, ibge)
                        .Where(x => Conversoes.StringToDate(x.date, "dd/mm/yyyy") == dt).FirstOrDefault();
                    //Verifica se é feriado
                    if (data_feriado != null)
                    {
                        if (data_feriado.type_code.Trim() != "9")
                        {
                            DtEntrega = DtEntrega.AddDays(1);
                        }
                        String msg = String.Format(@"Dia {0} é " + data_feriado.name + " Comemora {1} " + " Tipo: {2}",
                            data_feriado.date, data_feriado.description, data_feriado.type);
                        DataRetorno.Obs = msg;
                    }
                }
                //sabado dia útil?
                String sabado = "N";
                //verifica por fim de semana

                var diaDaSemana = DtEntrega.DayOfWeek;
                if (sabado == "S")
                {
                    if (diaDaSemana == DayOfWeek.Sunday)
                    {
                        DtEntrega = DtEntrega.AddDays(1);
                    }
                }
                else
                {
                    if (diaDaSemana == DayOfWeek.Saturday)
                    {
                        DtEntrega = DtEntrega.AddDays(2);
                    }
                    else if (diaDaSemana == DayOfWeek.Sunday)
                    {
                        DtEntrega = DtEntrega.AddDays(1);
                    }
                }
                DataRetorno.Data_retorno = DtEntrega;


            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro em DataProxContato BLL: " + ex.Message.ToString(), MessageType.Error);
            }


            return DataRetorno;
        }

        public List<HistoricoDTO> ListaHistoricoContato(Int32? id)
        {
            return _icontato.ListarHistoricoContato(id);
        }

        public String Id_ClienteMy { get; set; }
        public String AtualizaListaContato(String days)
        {

            String resp = "OK";

            //Captura a diferaç não existente no local e cria a lista para inserir
            var ListaInformix = _iInformix.ListarStatusContatos(days, null);

            var contagem = 0;

            foreach (var item in ListaInformix)
            {
                if (item.Id_cliente == "036476008000176")
                {
                    var  t = "OK";
                }

            }


            //   LogEvento.EscreverEvento("Registros Filtrados no logix: "+ ListaInformix, MessageType.Error);

        //    var ListaContatoMy = ListaIdClienteLocal();

            try
            {
                resp = InsereContatosBulk(ListaInformix);
            }
            catch (Exception ex)
            {
                resp = "Erro";
                LogEvento.EscreverEvento("Erro em AtualizaListaContato BLL: " + ex.Message.ToString(), MessageType.Error);
            }



            return resp + "|" + contagem.ToString();

        }


        public List<ContatoMyDTO> ListaIdClienteLocal()
        {
            var ListaContatoMy = ListaContatos(null);
            var lista = new List<ContatoMyDTO>();

            foreach (var item in ListaContatoMy)
            {
                var _item = new ContatoMyDTO();
                _item.Id_clienteMy = item.Id_cliente;

                lista.Add(_item);


            }
            return lista;
        }

        public string InsereContatosBulk(List<ContatosDTO> lista)
        {
            return _icontato.InserirContatosBulk(lista);
        }

        public string AtualizaDadoFAturamento(ContatosDTO item)
        {
            return _icontato.AtualizarDadoFAturamento(item);
        }




        public void AtualizaInfoFinanceira(String id_cliente)
        {

            try
            {  // captura dados no logix
                var logix = _iInformix.ListarStatusContatos(null, id_cliente).FirstOrDefault();

                if (logix != null)
                {
                    var dados = new ContatosDTO();
                    dados.Id_cliente = id_cliente;
                    dados.Dias_sem_compra = logix.Dias_sem_compra;
                    dados.Mes_Maior_compra = logix.Mes_Maior_compra;
                    dados.Dia_ult_compra = logix.Dia_ult_compra;

                    dados.valorMaiorCompra = logix.valorMaiorCompra;
                    AtualizaDadoFAturamento(dados);

                }

            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro em AtualizaInfoFinanceira BLL para id_cliente=" + id_cliente + " Erro: " + ex, "Erro");

            }



        }
        //se o operador não for null atualiza para o operador
        public string BloqueiaContato(int Id, int stat, String operador)
        {
            return _icontato.BloqueiarContato(Id, stat, operador);
        }

        public string InsereContatosUnit(ContatosDTO item)
        {
            return _icontato.InserirContatosUnit(item);
        }

        public List<HistoricoDTO> HistoricoAgrupadoBll(string dt_in, string dt_fim, String opera)
        {
            return _icontato.HistoricoAgrupado(dt_in, dt_fim, opera);
        }

        public List<ContatosDTO> ListaEnvioCorreio()
        {
            return _icontato.ListarEnvioCorreio();
        }
    }
}
