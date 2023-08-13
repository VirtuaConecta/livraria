using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Repository.BaseRepo;
using VirtuaConecta.Outbound.Utility;
using XmlNfe;
using XmlNfe.Model;

namespace VirtuaConecta.Outbound.Business
{

    public class EstoqueBll : BaseBis.IEstoqueBLL
    {
        private IXmlNfe xmlnf;
        IdataConections _db;
        public EstoqueBll()
        {
            xmlnf = new XmlNfe.XmNfe();
            _db = Factory.CriaConexao();
        }

        public String InserirNfEntradaBLL(EntradaProdutoDTO doc)
        {

            return _db.InserirNfEntrada(doc);
        }

        public List<HeadEntradaProd> ListarNfEntradaBLL(String nr_doc)
        {

            return _db.ListarNfEntrada(nr_doc);
        }

        public NfeEntradaDTO GetNfeEntrada(String Arq)
        {
            var arquivoLido = Arquivos.LeArquivo(Arq);
            var arquivoTransformado = new NfeEntradaDTO();
            //var pos = arquivoLido.IndexOf("CFe");

            if (arquivoLido.IndexOf("nfeProc") > -1)
            {
                var arquivoCapturado = xmlnf.GetXmlNfe(Arq);
                arquivoTransformado = ConverteXmlNfePedido(arquivoCapturado);
            }
            else if (arquivoLido.IndexOf("CFe") > -1)
            {
                var arquivoCapturado = xmlnf.GetXmlCFe(Arq);
                arquivoTransformado = ConverteXmlCFePedido(arquivoCapturado);

            }

            return arquivoTransformado;
        }
        private NfeEntradaDTO ConverteXmlNfePedido(NFeProc nota)
        {
            var nf = new NfeEntradaDTO();
            if (nota != null)
            {

                try
                {

                    nf.Head = new HeadEntrada();
                    nf.Itens = new List<ItensEntrada>();

                    nf.Head.Chave_nfe = nota.Protocolo.InformacoesProto.chNFe;
                    nf.Head.Nr_nf = nota.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF;
                    nf.Head.Serie = nota.NotaFiscalEletronica.InformacoesNFe.Identificacao.serie.ToString();
                    nf.Head.Data_emissao = nota.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi;


                    if (nota.NotaFiscalEletronica.InformacoesNFe.DadosTransporte.Volumes != null)
                    {
                        nf.Head.Peso_brt = nota.NotaFiscalEletronica.InformacoesNFe.DadosTransporte.Volumes.pesoB;
                        nf.Head.Peso_liq = nota.NotaFiscalEletronica.InformacoesNFe.DadosTransporte.Volumes.pesoL;
                        nf.Head.Nr_volumes = nota.NotaFiscalEletronica.InformacoesNFe.DadosTransporte.Volumes.qVol;
                        nf.Head.Especie = nota.NotaFiscalEletronica.InformacoesNFe.DadosTransporte.Volumes.esp;
                    }
                    nf.Head.Valor_Total = nota.NotaFiscalEletronica.InformacoesNFe.Valor.ICMSTot.vNF;


                    nf.Head.Nome_for = nota.NotaFiscalEletronica.InformacoesNFe.Emitente.xNome;
                    nf.Head.Endereco_for = $"{nota.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.xLgr},{nota.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.nro}";
                    nf.Head.Bairro_for = nota.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.xBairro;
                    nf.Head.Cep_For = nota.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.CEP;
                    nf.Head.Cidade_for = nota.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.xMun;
                    nf.Head.Cod_municipio_for = nota.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.cMun;
                    nf.Head.Estado_for = nota.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.UF;
                    nf.Head.Telefone_for = nota.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.fone;
                    if (nota.NotaFiscalEletronica.InformacoesNFe.Emitente.CNPJ.Length == 14)
                    {
                        nf.Head.Fis_jur_for = "J";
                        nf.Head.Cnpj_Cpf_for = nota.NotaFiscalEletronica.InformacoesNFe.Emitente.CNPJ;
                    }
                    else if (nota.NotaFiscalEletronica.InformacoesNFe.Emitente.CPF.Length == 11)
                    {
                        nf.Head.Fis_jur_for = "F";
                        nf.Head.Cnpj_Cpf_for = nota.NotaFiscalEletronica.InformacoesNFe.Emitente.CPF;
                    }
                    nf.Head.IE_for = nota.NotaFiscalEletronica.InformacoesNFe.Emitente.IE;


                    if (nota.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ != null)
                    {
                        nf.Head.Fis_jur_destino = "J";
                        nf.Head.Cnpj_Cpf_dest = nota.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ;
                    }
                    else if (nota.NotaFiscalEletronica.InformacoesNFe.Destinatario.CPF != null)
                    {
                        nf.Head.Fis_jur_destino = "F";
                        nf.Head.Cnpj_Cpf_dest = nota.NotaFiscalEletronica.InformacoesNFe.Destinatario.CPF;
                    }

                    foreach (var item in nota.NotaFiscalEletronica.InformacoesNFe.Detalhe)
                    {
                        var itemLista = new ItensEntrada();

                        itemLista.Descricao_prod = item.Produto.xProd;
                        itemLista.Sku = item.Produto.cProd;
                        itemLista.Ean = item.Produto.cEAN;
                        itemLista.Ncm = item.Produto.NCM;
                        itemLista.Especie = item.Produto.uCom;
                        itemLista.Qtd = Convert.ToDecimal(item.Produto.qCom);
                        itemLista.Valor_unit = Convert.ToDecimal(item.Produto.vUnCom);
                        nf.Itens.Add(itemLista);
                    }


                }
                catch (Exception ex)
                {

                    //throw;
                }

            }

            return nf;
        }
        private NfeEntradaDTO ConverteXmlCFePedido(CFe nota)
        {
            var nf = new NfeEntradaDTO();
            if (nota != null)
            {

                try
                {
                    var codUf = nota.CupmFiscalEletronico.Identificacao.cUF.ToString();
                    var estado = _db.ListarEstados(codUf).FirstOrDefault();


                    nf.Head = new HeadEntrada();
                    nf.Itens = new List<ItensEntrada>();

                    nf.Head.Chave_nfe = nota.CupmFiscalEletronico.ChaveCFe.Replace("CFe", "");
                    nf.Head.Nr_nf = nota.CupmFiscalEletronico.Identificacao.nCFe;
                    nf.Head.Serie = "0";

                    var dt = nota.CupmFiscalEletronico.Identificacao.dEmi;
                    var hr = nota.CupmFiscalEletronico.Identificacao.hEmi;

                    var dthr = $"{dt.Substring(0, 4)}-{dt.Substring(4, 2)}-{dt.Substring(6, 2)} {hr.Substring(0, 2)}:{hr.Substring(2, 2)}:{hr.Substring(4, 2)}";

                    nf.Head.Data_emissao = Convert.ToDateTime(dthr);

                    var nrItens = nota.CupmFiscalEletronico.Detalhe;
                    var volumes = nrItens.Select(c => c.Produto).Count();

                    nf.Head.Peso_brt = 0;
                    nf.Head.Peso_liq = 0;
                    nf.Head.Nr_volumes = volumes;
                    nf.Head.Especie = "UN";

                    nf.Head.Valor_Total = nota.CupmFiscalEletronico.Valor.ICMSTot.vCFe;


                    nf.Head.Nome_for = nota.CupmFiscalEletronico.Emitente.xNome;
                    nf.Head.Endereco_for = $"{nota.CupmFiscalEletronico.Emitente.Endereco.xLgr},{nota.CupmFiscalEletronico.Emitente.Endereco.nro}";
                    nf.Head.Bairro_for = nota.CupmFiscalEletronico.Emitente.Endereco.xBairro;
                    nf.Head.Cep_For = nota.CupmFiscalEletronico.Emitente.Endereco.CEP;
                    nf.Head.Cidade_for = estado.Estado;
                    nf.Head.Cod_municipio_for = nota.CupmFiscalEletronico.Emitente.Endereco.cMun;
                    nf.Head.Estado_for = estado.Uf;
                    nf.Head.Telefone_for = nota.CupmFiscalEletronico.Emitente.Endereco.fone;
                    if (nota.CupmFiscalEletronico.Emitente.CNPJ.Length == 14)
                    {
                        nf.Head.Fis_jur_for = "J";
                        nf.Head.Cnpj_Cpf_for = nota.CupmFiscalEletronico.Emitente.CNPJ;
                    }
                    else if (nota.CupmFiscalEletronico.Emitente.CPF.Length == 11)
                    {
                        nf.Head.Fis_jur_for = "F";
                        nf.Head.Cnpj_Cpf_for = nota.CupmFiscalEletronico.Emitente.CPF;
                    }
                    nf.Head.IE_for = nota.CupmFiscalEletronico.Emitente.IE;


                    if (nota.CupmFiscalEletronico.Destinatario.CNPJ != null)
                    {
                        nf.Head.Fis_jur_destino = "J";
                        nf.Head.Cnpj_Cpf_dest = nota.CupmFiscalEletronico.Destinatario.CNPJ;
                    }
                    else if (nota.CupmFiscalEletronico.Destinatario.CPF != null)
                    {
                        nf.Head.Fis_jur_destino = "F";
                        nf.Head.Cnpj_Cpf_dest = nota.CupmFiscalEletronico.Destinatario.CPF;
                    }

                    foreach (var item in nota.CupmFiscalEletronico.Detalhe)
                    {
                        var itemLista = new ItensEntrada();

                        itemLista.Descricao_prod = item.Produto.xProd;
                        itemLista.Sku = item.Produto.cProd;
                        itemLista.Ean = item.Produto.cEAN;
                        itemLista.Ncm = item.Produto.NCM;
                        itemLista.Especie = item.Produto.uCom;
                        itemLista.Qtd = Convert.ToDecimal(item.Produto.qCom);
                        itemLista.Valor_unit = Convert.ToDecimal(item.Produto.vUnCom);
                        nf.Itens.Add(itemLista);
                    }


                }
                catch (Exception ex)
                {

                    //throw;
                }

            }

            return nf;
        }
        public String InserirPedidoXml(NfeEntradaDTO xml)
        {
            String ret = "Erro";

            var CapturaFornecedorCadastrado = _db.FornecedorListar()
                .Where(x => x.Cpf_cnpj == xml.Head.Cnpj_Cpf_for).FirstOrDefault();

            if (CapturaFornecedorCadastrado != null && !String.IsNullOrEmpty(CapturaFornecedorCadastrado.Cpf_cnpj))
            {
                var entrada = new EntradaProdutoDTO();
                var head = new HeadEntradaProd();
                var items = new ItemEntradaProd();
                head.Id_fornecedor = CapturaFornecedorCadastrado.id;
                head.Nf_nfe = xml.Head.Nr_nf;
                head.Serie = xml.Head.Serie;
                head.Data_emissao = xml.Head.Data_emissao;
                head.Chave = xml.Head.Chave_nfe;
                head.Nr_doc = $"{head.Nf_nfe}-{head.Serie}-{head.Id_fornecedor }";

                var nfLocalizada = _db.ListarNfEntrada(head.Nr_doc).FirstOrDefault();

                if (nfLocalizada == null || String.IsNullOrEmpty(nfLocalizada.Nr_doc))
                {


                    //xml.Itens
                    var itensValidados = ValidaItens(xml.Itens, xml.Head.Nome_for, head.Nr_doc);
                    // se encontrar pelo menos 1 produto sem cadastro não entrar com a nota
                    var itemIdZero = itensValidados.Where(x => x.Id_produto == 0).FirstOrDefault();

                    if (itemIdZero != null && !String.IsNullOrEmpty(itemIdZero.Nr_doc))
                    {
                        ret = "Existe Item não cadastrado";
                    }
                    else
                    {
                        entrada.Head = head;
                        entrada.Itens = itensValidados;
                        //inserir o pedido
                        ret = _db.InserirNfEntrada(entrada);


                    }

                }
                else
                {
                    ret = "Xml já está cadastrado!";
                }

            }


            return ret;
        }
        private List<ItemEntradaProd> ValidaItens(List<ItensEntrada> itens, String fornecedor, String nrDoc)
        {
            var lista = new List<ItemEntradaProd>();

            foreach (var item in itens)
            {
                var prod = new ItemEntradaProd();
                var itemCadatrado = _db.ProdutoListar(null).Where(x => x.Sku == item.Sku).Select(y => y.id).FirstOrDefault();
                var id = 0;
                if (itemCadatrado > 0)
                {
                    id = itemCadatrado;
                }
                else
                {
                    //insere o produto e captura o id
                    var dadoProduto = new ProdutoDTO();
                    dadoProduto.Sku = item.Sku;
                    dadoProduto.fornecedor = fornecedor;
                    dadoProduto.cod_barra = item.Ean;
                    dadoProduto.ncm = item.Ncm;
                    dadoProduto.descricao = item.Descricao_prod;
                    var produtoInserido = _db.ProdutoInserir(dadoProduto).Split('|');

                    id = Convert.ToInt32(produtoInserido[1]);

                }

                prod.Id_produto = id;
                prod.Nr_doc = nrDoc;
                prod.Qtd = item.Qtd;

                lista.Add(prod);

            }

            return lista;
        }

        public List<MovEstoqueDTO> ListaMovEstoque(String dtIni, String dtFim)
        {
            return _db.ListMovEstoque(dtIni, dtFim);
        }
    }
}
