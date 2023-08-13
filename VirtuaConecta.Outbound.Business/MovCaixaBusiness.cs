using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Repository.BaseRepo;
using VirtuaConecta.Outbound.Parametros;
using VirtuaConecta.Outbound.Utility;

namespace VirtuaConecta.Outbound.Business
{
    public class MovCaixaBusiness: BaseBis.ImovCaixa
    {
        IdataConections _repositoryMovCaixa;
        public MovCaixaBusiness()
        {
            _repositoryMovCaixa = Factory.CriaConexao();
        }


        public List<CaixaDTO> ListarCaixa()
        {
            return _repositoryMovCaixa.ListarCaixa();
        }

        public List<MovCaixaDTO> ListarMovCaixa()
        {
            return _repositoryMovCaixa.ListarMovCaixa();
        }


        public MovCaixaDTO PesquisaTicket(Int32 id_ticket)
        {
            return _repositoryMovCaixa.ListarMovCaixa().Where(x=>x.Id_ticket==id_ticket).FirstOrDefault();
        }

        public string ExecutarVendaCaixa(List<PedidoDTO> pedido,TicketDTO ticket, MovCaixaDTO movimento)
        {
            return _repositoryMovCaixa.InsereVenda(pedido, ticket, movimento);
        }

        public List<Rep_mov_caixa> GetReport(String dtIni, String dtFim)
        {
            var rep = _repositoryMovCaixa.ListarMovFecha(dtIni,dtFim).OrderBy(x=>x.Meio_pagto).ToList();

            var lista = new List<Rep_mov_caixa>();
            int cont = 0;
            String meio_anterior="";
            var itemLista = new Rep_mov_caixa();
            foreach (var item in rep)
            {
                if (cont != 0 && meio_anterior != item.Meio_pagto)
                {
                    itemLista.meio_pagto = meio_anterior;
                    lista.Add(itemLista);

                     itemLista = new Rep_mov_caixa();
                     itemLista.total_meio = 0;
                }
               
                    meio_anterior = item.Meio_pagto;
                   itemLista.total_meio += item.Valor_final;
                switch (item.Grupo_produto)
                    {
                        case "Livro":
                            itemLista.livros += item.Valor_final;
                            break;
                        case "Bazar":
                            itemLista.bazar += item.Valor_final;
                            break;
                        case "Aromas":
                            itemLista.aromas += item.Valor_final;
                            break;
                        case "Mesalidade":
                            itemLista.mensalidade += item.Valor_final;
                            break;
                        case "Farmacia":
                            itemLista.farmacia += item.Valor_final;
                            break;
                        case "Lanchonete":
                            itemLista.lanchonte += item.Valor_final;
                            break;
                        case "Doacoes":
                            itemLista.doacoes += item.Valor_final;
                            break;
                        case "Cursos":
                            itemLista.cursos += item.Valor_final;
                            break;
                        case "Eventos":
                            itemLista.eventos += item.Valor_final;
                            break;
                        case "Outros":
                            itemLista.outros += item.Valor_final;
                            break;

                       
                }
                               cont++;
            }
            // ultimo registro
            itemLista.meio_pagto = meio_anterior;
            lista.Add(itemLista);



            return lista;
        }

        public String TotaisFechamento(String dtIni, String dtFim)
        {


            var listamov = _repositoryMovCaixa.ListarMovCaixa().Where(x => Convert.ToDateTime(x.Dt_operacao) >= Convert.ToDateTime(dtIni)
            && Convert.ToDateTime(x.Dt_operacao) <= Convert.ToDateTime($"{dtFim} 23:59:59")).ToList();


            //agrupa por meio e soma
            var query = (from t in listamov
                         group t by new { t.Meio_pagto }
                        into grp
                         select new
                         {
                             Id = grp.Key.Meio_pagto,
                             Valor = grp.Sum(x => x.Valor_final)

                         }).ToList();

            String retorno = "";
            Int32 contar = 0;
            //Monta uma string
            foreach (var item in query)
            {
                if (contar > 0)
                    retorno += "|";

                retorno += $"{item.Id}:{item.Valor}";


                contar++;
            }



            return retorno;
        }
        /// <summary>
        ///  Verifica se existe um usuario logado
        /// </summary>
        /// <returns>Devolve o o usuario ou status de caixa Fechado</returns>
            public Int32 StatusMovCaixa()
        {//
            
            // Verifica se existem registros na tabela
            var listaMovCaixa = _repositoryMovCaixa.ListarCaixa().Where(x => x.Terminal == Parametros.Parametros.NrTerminal()).ToList();
            var usuario = new CaixaDTO();
            if (listaMovCaixa.Count > 0)
            {
                usuario = listaMovCaixa.Last();
            }
            else
            {
                //Se não houver movimentação considero caixa fechado
                usuario.Cod_Operacao = 3;
            }

            if (usuario.Cod_Operacao == 3)
            {
                VarGlobal.UsuarioLogado = "";
            }
            else
            {
                VarGlobal.UsuarioLogado = usuario.Id_usr.ToString() + "-" + usuario.Nome_Usr + " #" + usuario.Nr_caixa;
            }
            return usuario.Cod_Operacao;
        }
        public void AlteraStatusCaixa(Int32 ItemIndex, String ItemDescricao, String Valor)
        {
            var UltimoCaixa = new CaixaDTO();

            if (_repositoryMovCaixa.ListarCaixa().Count > 0)
            {
                UltimoCaixa = _repositoryMovCaixa.ListarCaixa().Last();
            }
            else
            {
                UltimoCaixa.Nr_caixa = 0;
                UltimoCaixa.Saldo = 0;

            }


            var Caixa = new CaixaDTO();

            Caixa.Id_usr = VarGlobal.Id_usr;
            Caixa.Cod_Operacao = ItemIndex;

            Caixa.Terminal = Parametros.Parametros.NrTerminal();
            Caixa.Dt_Hr_operacao = DateTime.Now.ToString();
            Caixa.Nome_operacao = ItemDescricao;
            Caixa.Nome_Usr = VarGlobal.LoginName;
          
            Caixa.Nr_caixa = UltimoCaixa.Nr_caixa;
            Caixa.Cnpj_loja = Parametros.Parametros.Cnpj();
            //Abertura de caixa 
            if (ItemIndex == 1)
            {
                // Na abertura cria um novo codigo que será usado até o fechamento
                Caixa.Nr_caixa = UltimoCaixa.Nr_caixa + 1;

                Caixa.Saldo = Decimal.Parse(Conversoes.Nz(Valor, "0"));
                Caixa.Valor = Decimal.Parse(Conversoes.Nz(Valor, "0"));

                Caixa.Obs = Caixa.Nome_Usr + " : " + DateTime.Now.ToString() + "|";
                _repositoryMovCaixa.InsereCaixa(Caixa);

            }
            // Sangria
            else if (ItemIndex == 2)
            {
                Caixa.Saldo = UltimoCaixa.Saldo - Decimal.Parse(Conversoes.Nz(Valor, "0"));
                Caixa.Valor = Decimal.Parse(Conversoes.Nz(Valor, "0"));
                _repositoryMovCaixa.InsereCaixa(Caixa);
            }
            //Encerrar
            else if (ItemIndex == 3)
            {
                Caixa.Saldo = UltimoCaixa.Saldo;
                Caixa.Valor = 0;
                _repositoryMovCaixa.InsereCaixa(Caixa);

            }
            //Reforçar
            else if (ItemIndex == 4)
            {
                Caixa.Saldo = UltimoCaixa.Saldo + Decimal.Parse(Conversoes.Nz(Valor, "0"));
                Caixa.Valor = Decimal.Parse(Conversoes.Nz(Valor, "0"));
                _repositoryMovCaixa.InsereCaixa(Caixa);
            }

        }
        public Int32 CapturaUltimoCodigo()
        {
            Int32 retorno = 0;
            if (ListarCaixa().Count > 0)
            {
           
                retorno = ListarCaixa().Where(u => u.Terminal == Parametros.Parametros.NrTerminal()&& u.Cod_Operacao==1).Select(x => x.Nr_caixa).Last();
            }
            return retorno;
        }



    }
}
