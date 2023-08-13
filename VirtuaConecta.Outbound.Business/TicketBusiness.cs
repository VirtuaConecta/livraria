using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Business.BaseBis;
using VirtuaConecta.Outbound.Parametros;
using VirtuaConecta.Outbound.Repository.BaseRepo;
using VirtuaConecta.Outbound.Utility;

namespace VirtuaConecta.Outbound.Business
{
    public class TicketBusiness: BaseBis.IticketBLL
    {
        private IdataConections _iconn;
        private ImovCaixa _move;
        private IpedidoBLL _pedido;
        public static int validaPrint { get; set; }
        public TicketBusiness()
        {
            _iconn = Factory.CriaConexao();
            _move = Factory.CriaMovCaixa();
            _pedido = Factory.CriaPedidoBLL();
        }

        public List<TicketDTO> ListaTickets()
        {
            return _iconn.ListarTicket();
        }

        public String InserirTicket(TicketDTO ticket)
        {
            return _iconn.InsereTicket(ticket);
               
        }

        public String NumeroProximoTicket()
        {
            Int32 proxId=0;
            String retorno = null;

            Int32 proxNrTicket = 0;
            try
            {
                if (ListaTickets().Count > 0)
                {
                     proxId = ListaTickets().Select(x => x.Id).Last()+1;

                     proxNrTicket = ListaTickets().Where(y=>y.Serie==Parametros.Parametros.Serie_rps()).Select(x => x.Nr_ticket).Last()+1;


                    retorno = $"{proxId}|{proxNrTicket}|{Parametros.Parametros.Serie_rps()}";

                }
                else
                {
                    retorno = $"1|1|{Parametros.Parametros.Serie_rps()}";
                }
            }
            catch (Exception ex)
            {

               
            }
            return retorno;



        }

       



        public String ImprimirTicket(Int32 id_tickect)
        {


            String ret = "OK";
            try

            {

                string dados = Parametros.Parametros.Impressora();
                var dadosImprimir = JsonConvert.DeserializeObject<DadosImprimirDTO>(dados);


                //  string printerName = printer.PrinterSettings.PrinterName;
                string printerName = dadosImprimir.Nome_Impressora;
                String vNomeLoja = dadosImprimir.Nome_Loja;
                String [] vEndLoja = dadosImprimir.Local_Loja.Split('|'); ;
                String vVnpj = dadosImprimir.Cnpj_Loja; ;
                string texto = string.Empty;

                var headTicket = _move.PesquisaTicket(id_tickect);
                var itensTicket = _pedido.PesquisaPedido(id_tickect);

                //string Condensed =  Convert.ToChar(15).ToString();
                //PrintManager.SendStringToPrinter(printerName, Condensed) ; //Inicio Condensado 
                string Normal = Convert.ToChar(18).ToString();
                PrintManager.SendStringToPrinter(printerName, Normal); //Inicio Normal
                //Cabecalho ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                //   Imprimir.PrintManager.SendStringToPrinter(printerName, ((char)27).ToString() + "G"); //Inicio Negrito
                String textoh;
           
                textoh = "============== R E C I B O ==============" + Environment.NewLine;
                PrintManager.SendStringToPrinter(printerName, textoh);
 
                //Conteudo -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                texto += Environment.NewLine;
           
               // texto += " ========================================" + Environment.NewLine;
                texto += $" Data: {DateTime.Now}" + Environment.NewLine;
                texto += " Nr:" + headTicket.Nr_ticket.ToString().PadLeft(8, '0') + " Serie:" + headTicket.SerieTicket + Environment.NewLine;
                texto += " ========================================" + Environment.NewLine;
                texto += Environment.NewLine;
                vNomeLoja = vNomeLoja + "                                       ";
                texto += " Empresa: " + vNomeLoja.Substring(0, 31) + Environment.NewLine; ;
                texto += " End: " + (vEndLoja[0] + new string(' ', 36)).Substring(0, 36) + Environment.NewLine;
                texto += "      " + (vEndLoja[1] + new string(' ', 36)).Substring(0, 36) + Environment.NewLine;
                texto += " CNPJ   : " + vVnpj + Environment.NewLine;
                texto += " Cpf/Cnpj Cliente : " + headTicket.Cpf_cnpj + Environment.NewLine;
                texto += Environment.NewLine;
                texto += " ================ Itens =================" + Environment.NewLine;
                texto += " Item                 Qtd     Valor       " + Environment.NewLine;
                texto += " ========================================" + Environment.NewLine;

                foreach (var item in itensTicket)
                {

                    var desc = (item.DescGrid + new string(' ', 20)).Substring(0, 20);

                    var Qtd = new string(' ', 6) + item.Qtd.ToString();
                    var QtdCut = Qtd.Substring(Qtd.Length - 6, 6);
                    var val = new string(' ', 12) + item.Valor.ToString("#,##0.00");
                    var valCut = val.Substring(val.Length - 11, 11);
                    texto += $" {desc} {QtdCut} {valCut}" + Environment.NewLine;
                }




                texto += " =========================================" + Environment.NewLine;
                texto += " Valor Bruto      : R$ " + headTicket.Valor.ToString("#,##0.00") + Environment.NewLine;
                texto += " Desconto         : % " + headTicket.Desconto.ToString("#,##0.00") + Environment.NewLine;
                texto += " Forma Pagto      : " + headTicket.Meio_pagto + Environment.NewLine;
                texto += " Valor Total      : R$ " + headTicket.Valor_final.ToString("#,##0.00") + Environment.NewLine;
                texto += Environment.NewLine;
        
                PrintManager.SendStringToPrinter(printerName, texto); //Imprime o contrúdo da string "texto"

                //Rodapé ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
     
                PrintManager.SendStringToPrinter(printerName, "==========================================" + Environment.NewLine);
          
                String textoF;
                textoF = Environment.NewLine;
                textoF += Environment.NewLine;
                textoF += Environment.NewLine;
                textoF += Environment.NewLine;
                textoF += Environment.NewLine;
                textoF += Environment.NewLine;
                textoF += Environment.NewLine;
                textoF += Environment.NewLine;



                //corte
                textoF += "\x0A\x1Bm" + Environment.NewLine;
                PrintManager.SendStringToPrinter(printerName, textoF);
                // PrintManager.SendStringToPrinter(printerName, "\x0A\x1Bm//corte parcial" + Environment.NewLine);


            }
            catch (Exception ex)
            {
                ret = "Erro";

                throw;
            }


            return ret;
        }

        public String ImprimirTicketMP4200(Int32 id_tickect)
        {
            String ret = "Erro";

            try
            {
                var conf = MP2032.ConfiguraModeloImpressora(7);
                var portaok = MP2032.IniciaPorta("USB");

                if (conf == 0 || portaok == 0)
                {

                    ret = "Porta ou tipo de impressora não foi reconhecido";

                    return ret;
                }

                validaPrint = 1;
                //Pula linha
                string s_cmdTX = "\r\n";

                string dados = Parametros.Parametros.Impressora();
                var dadosImprimir = JsonConvert.DeserializeObject<DadosImprimirDTO>(dados);


                //  string printerName = printer.PrinterSettings.PrinterName;
                string printerName = dadosImprimir.Nome_Impressora;
                String vNomeLoja = dadosImprimir.Nome_Loja;
                String[] vEndLoja = dadosImprimir.Local_Loja.Split('|'); ;
                String vVnpj = dadosImprimir.Cnpj_Loja; ;
                string texto = string.Empty;

                var headTicket = _move.PesquisaTicket(id_tickect);
                var itensTicket = _pedido.PesquisaPedido(id_tickect);

             

                //Cabecalho ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
               
            

                texto = "============== R E C I B O ==============" + s_cmdTX;
             

                //Conteudo -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                texto += s_cmdTX;

                // texto += " ========================================" + Environment.NewLine;
                texto += $" Data: {DateTime.Now}" + s_cmdTX;
                texto += " Nr:" + headTicket.Nr_ticket.ToString().PadLeft(8, '0') + " Serie:" + headTicket.SerieTicket + s_cmdTX;
                texto += " ========================================" + s_cmdTX;
                texto += s_cmdTX;
                vNomeLoja = vNomeLoja + "                                       ";
                texto += " Empresa: " + vNomeLoja.Substring(0, 31) + s_cmdTX; ;
                texto += " End: " + (vEndLoja[0] + new string(' ', 36)).Substring(0, 36) + s_cmdTX;
                texto += "      " + (vEndLoja[1] + new string(' ', 36)).Substring(0, 36) + s_cmdTX;
                texto += " CNPJ   : " + vVnpj + s_cmdTX;
                texto += " Cpf/Cnpj Cliente : " + headTicket.Cpf_cnpj + s_cmdTX; 
                texto += s_cmdTX;
                texto += " ================ Itens =========================" + s_cmdTX;
                texto += " Item                Qtd     Valor      Total    " + s_cmdTX;
                texto += " ================================================" + s_cmdTX;

                foreach (var item in itensTicket)
                {

                    var desc = (item.DescGrid + new string(' ', 18)).Substring(0, 18);

                    var Qtd = new string(' ', 6) + item.Qtd.ToString();
                    var QtdCut = Qtd.Substring(Qtd.Length - 5, 5);
                    var val = new string(' ', 12) + item.Valor.ToString("#,##0.00");
                    var valCut = val.Substring(val.Length - 9, 9);
                    var valt = new string(' ', 12) + item.ValorTotal.ToString("#,##0.00");
                    var valCutt = valt.Substring(valt.Length - 12, 12);
                    texto += $" {desc} {QtdCut} {valCut} {valCutt}" + s_cmdTX;
                }


                //Rodapé ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


                texto += " =========================================" + s_cmdTX;
                texto += " Valor Bruto      : R$ " + headTicket.Valor.ToString("#,##0.00") + s_cmdTX;
                texto += " Desconto         : % " + headTicket.Desconto.ToString("#,##0.00") + s_cmdTX;
                texto += " Forma Pagto      : " + headTicket.Meio_pagto + s_cmdTX;
                texto += " Valor Total      : R$ " + headTicket.Valor_final.ToString("#,##0.00") + s_cmdTX;
                texto += s_cmdTX;
                texto += " =========================================" + s_cmdTX;



                validaLinha(MP2032.FormataTX(texto, 2, 0, 0, 0, 0)); //pula linha

                String textopula = " \r\n\r\n";
                textopula += " \r\n\r\n";
                textopula += " \r\n\r\n";

                validaLinha(MP2032.FormataTX(textopula, 2, 0, 0, 0, 0));

            
                //corte
                MP2032.AcionaGuilhotina(1);//chama a função da DLL(Corte Total -parcial =0)

                //================= Segunda via ===================================

                validaLinha(MP2032.FormataTX(texto, 2, 0, 0, 0, 0)); //pula linha


                validaLinha(MP2032.FormataTX(textopula, 2, 0, 0, 0, 0));


                //corte
                MP2032.AcionaGuilhotina(1);//chama a função da DLL(Corte Total -parcial =0)

                ret = "OK";

            }
            catch (Exception ex)
            {
                LogEvento.EscreverEvento($"Erro ao imprimir em ImprimirTicketMP4200: {ex.Message}", MessageType.Error);

            }      


            return ret;
        }
        private void validaLinha(int retonoComando)
        {
            if (retonoComando == 0)
            {
                validaPrint = 0;
            }
        }

    }
}
