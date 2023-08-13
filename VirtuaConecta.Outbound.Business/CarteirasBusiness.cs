using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Outbound.Parametros;
using VirtuaConecta.Outbound.Utility;

namespace VirtuaConecta.Outbound.Business
{
    public class CarteirasBusiness : BaseBis.IcarteiraBLL
    {
        Repository.BaseRepo.IcarteiraDAL _icarteira;
        BaseBis.IcontatoBLL _contatos;
        public CarteirasBusiness()
        {
            _icarteira = Factory.CriaCarteiraDAL();

            _contatos = Factory.CriarContatosBLL();
        }

        public string ApagaCarteiraPorUsuario(string Usuario)
        {
            return _icarteira.ApagarCarteiraPorUsuario(Usuario);
        }

        public string EditaCarteira(CarteirasDTO item)
        {
            return _icarteira.EditarCarteira(item);
        }

        public string InsereCarteira(CarteirasDTO item)
        {
            return _icarteira.InserirCarteira(item);
        }

        public List<CarteirasDTO> ListaCarteira()
        {
            return _icarteira.ListarCarteira();
        }



        public List<CarteirasDTO> ListaCarteiraDiponivel()
        {
            var ListaDisponivel = new List<CarteirasDTO>();

            try
            {
                // Captura carteiras existentes na lista de contatos
                var cart = (from t in _contatos.ListaContatos(null)
                            group t by new { t.Canal_venda }
                     into grp
                            select new
                            {
                                grp.Key.Canal_venda,

                            }).ToList().OrderBy(x => x.Canal_venda);


                foreach (var itemObj in cart)
                {

                    var item = Conversoes.GetValObjBy(itemObj, "Canal_venda").ToString().Trim();

                    var itemExistente = _icarteira.ListarCarteira().Where(x => x.Carteira == item).FirstOrDefault();

                    if (itemExistente == null && item !="")
                    {
                        var carteira = new CarteirasDTO() { Carteira = item, Reservado = 0 };

                        _icarteira.InserirCarteira(carteira);
                    }



                }

                ListaDisponivel = _icarteira.ListarCarteira().Where(x => x.Reservado == 0).ToList();


            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro em Lista carteiras diponiveis business: " + ex.Message.ToString(), MessageType.Error);
            }


            return ListaDisponivel;
        }



    }
}
