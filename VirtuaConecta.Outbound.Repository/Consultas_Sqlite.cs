using Dapper;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Parametros;
using VirtuaConecta.Outbound.Utility;

namespace VirtuaConecta.Outbound.Repository
{

    public class LastId
    {
        public String name { get; set; }
        public String seq { get; set; }
    }
    public class Consultas_Sqlite : BaseRepo.IdataConections
    {
        String conn_str;
        public Consultas_Sqlite()
        {
            conn_str = $"Data Source= {Parametros.Parametros.LocalDbSqlite()}\\vc_livraria.db;Version=3;";
        }

        #region Estoque
        public String InserirNfEntrada(EntradaProdutoDTO doc)
        {
            var head = doc.Head;
            var itens = doc.Itens;

            String ret = "Erro";

            String str = "Insert Into tab_entrada_head ";
            str += "(nr_doc,";
            str += "nr_nf,";
            str += "serie,";
            str += "data_emissao,";
            str += "data_entrada,";
            str += "chave,";
            str += "id_fornecedor) ";
            str += "Values ";
            str += "(@nr_doc,";
            str += "@nr_nf,";
            str += "@serie,";
            str += "@data_emissao,";
            str += "@data_entrada,";
            str += "@chave,";
            str += "@id_fornecedor) ";



            try
            {
                
                var p = new DynamicParameters();

                p.Add("@nr_doc", head.Nr_doc);
                p.Add("@nr_nf", head.Nf_nfe);
                p.Add("@serie", head.Serie);
                p.Add("@data_emissao", head.Data_emissao);
                p.Add("@data_entrada",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                p.Add("@chave", head.Chave);
                p.Add("@id_fornecedor", head.Id_fornecedor);


                String str1 = "Insert into tab_entrada_item ";
                str1 += "(nr_doc, ";
                str1 += "id_produto,";
                str1 += "qtd,";
                str1 += "id_head)";
                str1 += " VALUES ";


                String str4 = "UPDATE  tab_produto ";
                str4 += "SET saldo =  CASE id "; 


                var cont = 0;
                String ids = "";
                foreach (var iteml in itens)
                {
                    if (cont > 0) { str1 += ","; ids += ","; }


                    str1 += $"('{iteml.Nr_doc}',";
                    str1 += $"{iteml.Id_produto},";
                    str1 += $"{iteml.Qtd},";
                    str1 += "(Select Seq from sqlite_sequence where name ='tab_entrada_head'))";
             
                    str4 += $" WHEN {iteml.Id_produto} THEN saldo + {iteml.Qtd}";
                    ids += $"{iteml.Id_produto}";

                    cont++;
                }
                str4 += " END ";
                str4 += $" WHERE id IN ({ids} ) ";

                String str2 = $"{str};{str1};{str4}";


                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Open();
                    using (var trans = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(str2, p, transaction: trans);
                            trans.Commit();
                            ret = "OK";
                        }
                        catch (Exception ex)
                        {
                            LogEvento.EscreverEvento("Erro listar Nf Entrada head rollback repository: " + ex.Message.ToString(), MessageType.Error);
                            trans.Rollback();
                            //throw;
                        }
                        

                    }   

                    
                }



            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro listar Nf Entrada head repository: " + ex.Message.ToString(), MessageType.Error);
            }


            return ret;

        }

        //Cabeçalhos de Nf de Entrada
        public List<HeadEntradaProd> ListarNfEntrada(String nr_doc)
        {
            var lista_nf = new List<HeadEntradaProd>();

            String str = "Select id,";
            str += "nr_doc,";
            str += "nr_nf,";
            str += "serie,";
            str += "data_emissao,";
            str += "data_entrada,";
            str += "chave,";
            str += "id_fornecedor ";
            str += " From tab_entrada_head";
            try
            {
                if (!String.IsNullOrEmpty(nr_doc))
                {
                    str += " where nr_doc = @NrDoc ";
                }

                var p = new DynamicParameters();

                p.Add("@NrDoc", nr_doc);


                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    var retorno = connection.Query<HeadEntradaProd>(str, p).ToList();

                    lista_nf = retorno;
                }



            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro listar Nf Entrada head repository: " + ex.Message.ToString(), MessageType.Error);
            }



            return lista_nf;

        }

        public List<MovEstoqueDTO> ListMovEstoque(String dtIni,String DtFim)
        {
            var lista = new List<MovEstoqueDTO>();
            try
            {
                if (!String.IsNullOrEmpty(dtIni) && !String.IsNullOrEmpty(DtFim))
                {
                    String str = "Select ";
                    str += "nr_documento as Nr_documento,";
                    str += "tipo as Tipo,";
                    str += "serie as Serie,";
                    str += "data_emissao as Dt_emissao,";
                    str += "sku as Sku,";
                    str += "descricao as Descricao,";
                    str += "qtd_entrada as Qtd_in,";
                    str += "qtd_saida as Qtd_out ";
                    str += " From mov_estoque ";
                    str += " where data_emissao >= @dtIni ";
                    str += "and data_emissao <= @dtFim ";
                    str += " order by data_emissao asc ";
                    var p = new DynamicParameters();

                    p.Add("@dtIni", dtIni);
                    p.Add("@dtFim", $"{DtFim} 23:59:59");

                    using (IDbConnection connection = new SQLiteConnection(conn_str))
                    {
                        var retorno = connection.Query<MovEstoqueDTO>(str, p).ToList();

                        lista = retorno;
                    }


                }

            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro listar Movimento de estoque repository: " + ex.Message.ToString(), MessageType.Error);

            }


            return lista;
        }

        #endregion

        #region Usuarios


        public List<UsuariosDTO> ListarUsuarios()
        {
            var lista = new List<UsuariosDTO>();
            String str = "SELECT ";
            str += "id as Id ,";
            str += "nome as NomeUsuario,";
            str += "login as LoginUsuario,";
            str += "id_perfil as IdPerfil,";
            str += "email as Email,";
            str += "telefone as Telefone,";
            str += "senha as SenhaUsuario,";
            str += "obs as Obs,";
            str += "bloqueado as Bloqueado";
            str += " FROM tab_pw4 ";


            using (IDbConnection connection = new SQLiteConnection(conn_str))
            {
                lista = connection.Query<UsuariosDTO>(str).ToList();
            }


            return lista;
        }

        public String InserirUsuarios(UsuariosDTO item)
        {
            String retorno = "Erro";
            try
            {


                String sql = "INSERT INTO tab_pw4  ";
                sql += "(nome,";
                sql += "login,";

                sql += "id_perfil,";
                sql += "email,";
                sql += "telefone,";

                sql += "senha,";
                sql += "obs,";
                sql += "bloqueado)";
                sql += " VALUES ";
                sql += " (";
                sql += " @nome,";
                sql += " @login,";
                sql += " @id_perfil,";
                sql += " @email,";
                sql += " @telefone,";
                sql += " @senha,";
                sql += " @obs,";
                sql += " @bloqueado)";


                var p = new DynamicParameters();

                p.Add("@nome", item.NomeUsuario);
                p.Add("@login", item.LoginUsuario);

                p.Add("@bloqueado", item.Bloqueado);
                p.Add("@senha", item.SenhaUsuario);

                p.Add("@email", item.Email);
                p.Add("@telefone", item.Telefone);

                p.Add("@id_perfil", item.IdPerfil);
                p.Add("@obs", item.Obs);

                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(sql, p);
                    retorno = "OK";
                }

            }
            catch (Exception ex)
            {
                retorno = ex.Message.ToString();
                LogEvento.EscreverEvento("Erro Inserir Usuarios repository: " + ex.Message.ToString(), MessageType.Error);

            }



            return retorno;
        }

        public String AtualizarUsuarios(UsuariosDTO item)
        {
            String retorno = "Erro";
            try
            {


                String str = "UPDATE  tab_pw4 SET ";

                str += " nome=@nome,";
                str += " login=@login,";
                str += " id_perfil=@id_perfil,";
                str += " email=@email,";
                str += " telefone=@telefone,";
                str += " email=@email, ";
                str += " telefone=@telefone,";
                if (!String.IsNullOrEmpty(item.SenhaUsuario))
                {
                    str += " senha=@senha,";
                }



                str += " bloqueado=@bloqueado ";
                str += " WHERE id=@id";

                var p = new DynamicParameters();

                p.Add("@nome", item.NomeUsuario);
                p.Add("@login", item.LoginUsuario);

                p.Add("@bloqueado", item.Bloqueado);


                if (!String.IsNullOrEmpty(item.SenhaUsuario))
                {
                    var senhaCrip = Conversoes.MD5Hash(item.SenhaUsuario);
                    p.Add("@senha", senhaCrip);
                }

                p.Add("@email", item.Email);
                p.Add("@telefone", item.Telefone);

                p.Add("@id_perfil", item.IdPerfil);
                p.Add("@obs", item.Obs);
                p.Add("@id", item.NomeUsuario);

                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(str, p);
                    retorno = "OK";

                }


            }
            catch (Exception ex)
            {
                retorno = ex.Message.ToString();
                LogEvento.EscreverEvento("Erro AtualizarUsuarios repository: " + ex.Message.ToString(), MessageType.Error);

            }



            return retorno;

        }




        #endregion

        #region Produtos
        public List<ProdutoDTO> ProdutoListar(String cod_barra)
        {
            var lista_produto = new List<ProdutoDTO>();

            String str = "SELECT ";
            str += "id as Id ,";
            str += "descricao ,";
            str += "preco,";
            str += "cod_barra,";
            str += "fornecedor,";
            str += "sku as Sku,";
            str += "local,"; 
             str += "saldo,";
            str += "ncm,";
            str += "id_familia,";
            str += "obs";
            str += " FROM tab_produto ";

            try
            {
                if (!String.IsNullOrEmpty(cod_barra))
                {
                    str += " where cod_barra = @cb ";
                }

                var p = new DynamicParameters();

                p.Add("@cb", cod_barra);


                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    var retorno = connection.Query<ProdutoDTO>(str, p).ToList();

                    lista_produto = retorno;
                }



            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro listar produtos repository: " + ex.Message.ToString(), MessageType.Error);
            }



            return lista_produto;
        }
        public String ProdutoInserir(ProdutoDTO produto)
        {
            String retorno = "Erro|0";
            try
            {


                String sql = "INSERT INTO `tab_produto`   ";
                sql += "(`descricao`,";
                sql += "`cod_barra`,";
                sql += "`sku`,";
                sql += "`preco`,";
                sql += "`fornecedor`,";
                sql += "`local`,";
                sql += "`saldo`,";
                sql += "`ncm`,";
                sql += "`id_familia`,";
                sql += "`obs`)";


                sql += " VALUES ";
                sql += " (";
                sql += " @descricao,";
                sql += " @cod_barra,";
                sql += " @sku,";
                sql += " @preco,";
                sql += " @fornecedor,";
                sql += " @local,";
                sql += " @saldo,";
                sql += " @ncm,";
                sql += " @id_familia,";
                sql += " @obs)";



                var p = new DynamicParameters();

                p.Add("@descricao", produto.descricao);
                p.Add("@cod_barra", produto.cod_barra);
                p.Add("@sku", produto.Sku);
                p.Add("@preco", produto.preco);
                p.Add("@fornecedor", produto.fornecedor);
                p.Add("@local", produto.local);
                p.Add("@saldo", produto.saldo); 
                p.Add("@ncm", produto.ncm);
                p.Add("@id_familia", produto.id_familia);
                p.Add("@obs", produto.obs);


                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(sql, p);
                    var resp = connection.Query<LastId>("select seq from Sqlite_sequence where name=\"tab_produto\"").FirstOrDefault();

                    retorno = $"OK|{resp.seq}";
                }

            }
            catch (Exception ex)
            {
                retorno = $"{ex.Message.ToString()}|0";
                LogEvento.EscreverEvento("Erro inserir produto repository: " + ex.Message.ToString(), MessageType.Error);

            }

            return retorno;
        }

        public String ProdutoEditar(ProdutoDTO produto)
        {
            String retorno = "Erro";
            try
            {
                String sql = "UPDATE  tab_produto ";
                sql += "SET ";
                sql += "descricao = @descricao,";
                sql += "cod_barra = @cod_barra,";
                sql += "sku = @sku,";
                sql += "preco = @preco,";
                sql += "fornecedor = @fornecedor,";
                sql += "local = @local,";
                sql += "saldo = @saldo,";
                sql += "ncm = @ncm,";
                sql += "id_familia = @id_familia,";
                sql += "obs = @obs";

                sql += " WHERE  id = @id;";

                var p = new DynamicParameters();

                p.Add("@id", produto.id);
                p.Add("@descricao", produto.descricao);
                p.Add("@cod_barra", produto.cod_barra);

                p.Add("@preco", produto.preco);
                p.Add("@fornecedor", produto.fornecedor);
                p.Add("@sku", produto.Sku);
                p.Add("@local", produto.local);
                p.Add("@saldo", produto.saldo); 
                p.Add("@ncm", produto.ncm);
                p.Add("@id_familia", produto.id_familia);
                p.Add("@obs", produto.obs);


                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(sql, p);
                    retorno = "OK";
                }

            }
            catch (Exception ex)
            {
                retorno = ex.Message.ToString();
                LogEvento.EscreverEvento("Erro editar produto repository: " + ex.Message.ToString(), MessageType.Error);

            }

            return retorno;
        }

        public List<TipoProdutoDTO> ListarTipoProduto()
        {
            var lista = new List<TipoProdutoDTO>();
            try
            {
                
                String str = "SELECT ";
                str += "id as Id ,";
                str += "tipo_produto as tipo_produto";

                str += " FROM tab_tipo_produto";


                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    lista = connection.Query<TipoProdutoDTO>(str).ToList();
                }
                
            }
            catch (Exception ex)
            {

        
                LogEvento.EscreverEvento("Erro ao carregar a lista  repository: " + ex.Message.ToString(), MessageType.Error);
            }

            return lista;
        }

        public String TipoProdutoEditar(TipoProdutoDTO tipo)
        {
            String retorno = "Erro";
            try
            {
                String sql = "UPDATE  tab_tipo_produto ";
                sql += "SET ";           
                sql += "tipo_produto = @tipo_produto";
                sql += " WHERE  id = @id;";
                var p = new DynamicParameters();
                p.Add("@id", tipo.Id);              
                p.Add("@tipo_produto", tipo.tipo_produto);


                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(sql, p);
                    retorno = "OK";
                }

            }
            catch (Exception ex)
            {
                retorno = ex.Message.ToString();
                LogEvento.EscreverEvento("Erro editar tipo do produto repository: " + ex.Message.ToString(), MessageType.Error);

            }

            return retorno;
        }

        public String TipoProdutoInserir(TipoProdutoDTO tipo)
        {
            String retorno = "Erro";
            try
            {
                String sql = "INSERT INTO `tab_tipo_produto`   ";
                sql += "(`tipo_produto`)";         
                sql += " VALUES ";
                sql += " (";           
                sql += " @tipo_produto)";
                var p = new DynamicParameters();

                p.Add("@tipo_produto", tipo.tipo_produto);
              
                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(sql, p);                 
                    retorno = "OK";
                }

            }
            catch (Exception ex)
            {           
                LogEvento.EscreverEvento("Erro inserir tipo de produto repository: " + ex.Message.ToString(), MessageType.Error);
            }

            return retorno;
        }
        

        #endregion

        #region Fornecedores
        public List<FornecedorDTO> FornecedorListar()
        {
            var lista = new List<FornecedorDTO>();
            try
            {
                String str = "SELECT ";
                str += "id as id ,";
                str += "nome as Nome,";
                str += "cnpj_cpf as Cpf_cnpj,";
                str += "ie as Ie,";
                str += "fis_jur as Fis_jur,";
                str += "endereco as Endereco,";
                str += "bairro as Bairro,";
                str += "cidade as Cidade,";
                str += "estado as Estado,";
                str += "telefone as Telefone,";
                str += "email as Email ,";
                str += "contato as Contato,";
                str += "cod_mun as Cod_mun, ";
                str += "cep as Cep, ";
                str += "data_cadastro as Data_cad ";
                str += " FROM `tab_fornecedor` ";


                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    lista = connection.Query<FornecedorDTO>(str).ToList();
                }

            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro Listar Fornecedores repository: " + ex.Message.ToString(), MessageType.Error);
            }

            return lista;
        }
        public String FornecedorInserir(FornecedorDTO forn)
        {
            String retorno = "Erro";
            try
            {


                String sql = "INSERT INTO `tab_fornecedor`   ";
                sql += "(";
                sql += "nome ,";
                sql += "cnpj_cpf ,";
                sql += "ie ,";
                sql += "fis_jur ,";
                sql += "endereco ,";
                sql += "bairro ,";
                sql += "cidade ,";
                sql += "estado ,";
                sql += "telefone ,";
                sql += "email  ,";
                sql += "contato ,";
                sql += "cod_mun , ";
                sql += "cep , ";
                sql += "data_cadastro )";

                sql += " VALUES ";
                sql += " (";
                sql += " @nome,";
                sql += " @cnpj_cpf,";
                sql += " @ie,";
                sql += " @fis_jur,";
                sql += " @endereco,";
                sql += " @bairro,";
                sql += " @cidade,";
                sql += " @estado,";
                sql += " @telefone,";
                sql += " @email,";
                sql += " @contato,";
                sql += " @cod_mun,";
                sql += " @cep,";
                sql += " @data_cadastro)";


                var p = new DynamicParameters();

                p.Add("@nome", forn.Nome);
                p.Add("@cnpj_cpf", forn.Cpf_cnpj);
                p.Add("@ie", forn.Ie);
                p.Add("@fis_jur", forn.Fis_jur);
                p.Add("@endereco", forn.Endereco);
                p.Add("@bairro", forn.Bairro);
                p.Add("@cidade", forn.Cidade);
                p.Add("@estado", forn.Estado);
                p.Add("@telefone", forn.Telefone);
                p.Add("@email", forn.Email);
                p.Add("@contato", forn.Contato);
                p.Add("@cod_mun", forn.Cod_mun);
                p.Add("@cep", forn.Cep);
                p.Add("@data_cadastro", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(sql, p);
                    retorno = "OK";
                }

            }
            catch (Exception ex)
            {
                retorno = ex.Message.ToString();
                LogEvento.EscreverEvento("Erro inserir fornecedor repository: " + ex.Message.ToString(), MessageType.Error);

            }

            return retorno;
        }
        public String FornecedorEditar(FornecedorDTO forn)
        {
            String retorno = "Erro";
            try
            {
                String sql = "UPDATE  tab_fornecedor ";
                sql += "SET ";
                
                sql += "nome = @nome,";
                sql += "cnpj_cpf = @cnpj_cpf,";
                sql += "ie=@ie ,";
                sql += "fis_jur= @fis_jur,";
                sql += "endereco =@endereco,";
                sql += "bairro =@bairro,";
                sql += "cidade =@cidade,";
                sql += "estado =@estado,";
                sql += "telefone =@telefone,";
                sql += "email= @email ,";
                sql += "contato= @contato,";
                sql += "cep= @cep,";
                sql += "cod_mun= @cod_mun";

                sql += " WHERE  id = @id;";

                var p = new DynamicParameters();
                p.Add("@id", forn.id);
                p.Add("@nome", forn.Nome);
                p.Add("@cnpj_cpf", forn.Cpf_cnpj);
                p.Add("@ie", forn.Ie);
                p.Add("@fis_jur", forn.Fis_jur);
                p.Add("@endereco", forn.Endereco);
                p.Add("@bairro", forn.Bairro);
                p.Add("@cidade", forn.Cidade);
                p.Add("@estado", forn.Estado);
                p.Add("@telefone", forn.Telefone);
                p.Add("@email", forn.Email);
                p.Add("@contato", forn.Contato);
                p.Add("@cod_mun", forn.Cod_mun);
                p.Add("@cep", forn.Cep);

                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(sql, p);
                    retorno = "OK";
                }

            }
            catch (Exception ex)
            {
                retorno = ex.Message.ToString();
                LogEvento.EscreverEvento("Erro editar fornecedor repository: " + ex.Message.ToString(), MessageType.Error);

            }

            return retorno;
        }

        #endregion

        #region Caixa

        public List<CaixaDTO> ListarCaixa()
        {
            var lista = new List<CaixaDTO>();
            try
            {
                String str = "SELECT ";
                str += "tab_caixa.id as Id ,";
                str += "tab_caixa.nr_caixa as Nr_caixa,";
                str += "tab_caixa.id_operador as Id_usr,";
                str += "tab_caixa.dt_abertura as Dt_Hr_operacao,";
                str += "tab_caixa.tipo_operacao as Cod_Operacao,";
                str += "tab_caixa.valor as Valor,";
                str += "tab_tipo_operacao.descricao as Nome_operacao,";
                str += "tab_pw4.nome as Nome_Usr,";
                str += "tab_caixa.terminal as Terminal";
                str += " FROM `tab_caixa` join  `tab_tipo_operacao` ";
                str += " on tab_caixa.tipo_operacao=tab_tipo_operacao.id ";
                str += " join  `tab_pw4` ";
                str += " on tab_caixa.id_operador=tab_pw4.id ";


                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    lista = connection.Query<CaixaDTO>(str).ToList();
                }

            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro Listar Caixa repository: " + ex.Message.ToString(), MessageType.Error);
            }

            return lista;
        }

        public String InsereCaixa(CaixaDTO caixa)
        {
            String retorno = "Erro";
            try
            {


                String sql = "INSERT INTO `tab_caixa`   ";
                sql += "(`terminal`,";
                sql += "`nr_caixa`,";

                sql += "`id_operador`,";
                sql += "`dt_abertura`,";
                sql += "`tipo_operacao`,";

                sql += "`valor`,";

                sql += "`cnpj`)";
                sql += " VALUES ";
                sql += " (";
                sql += " @terminal,";
                sql += " @nr_caixa,";
                sql += " @id_operador,";
                sql += " @dt_abertura,";
                sql += " @tipo_operacao,";
                sql += " @valor,";

                sql += " @cnpj)";


                var p = new DynamicParameters();

                p.Add("@terminal", caixa.Terminal);
                p.Add("@nr_caixa", caixa.Nr_caixa);

                p.Add("@id_operador", caixa.Id_usr);
                p.Add("@dt_abertura", caixa.Dt_Hr_operacao);

                p.Add("@tipo_operacao", caixa.Cod_Operacao);
                p.Add("@valor", caixa.Valor);


                p.Add("@cnpj", caixa.Cnpj_loja);

                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(sql, p);
                    retorno = "OK";
                }

            }
            catch (Exception ex)
            {
                retorno = ex.Message.ToString();
                LogEvento.EscreverEvento("Erro Inserir Caixa repository: " + ex.Message.ToString(), MessageType.Error);

            }

            return retorno;
        }

        public List<MovCaixaDTO> ListarMovCaixa()
        {
            var lista = new List<MovCaixaDTO>();
            try
            {
                String str = "SELECT ";
                str += "tab_mov_caixa.id as Id ,";
                str += "tab_mov_caixa.id_caixa as Id_caixa ,";
                str += "tab_mov_caixa.id_ticket as Id_ticket ,";
                str += "tab_mov_caixa.dt_operacao as Dt_operacao,";
                str += "round(tab_mov_caixa.valor,2) as Valor,";
                str += "tab_mov_caixa.desconto as Desconto,";
                str += "round(tab_mov_caixa.valor_final,2) as Valor_final,";
                str += "tab_ticket.nr_ticket as Nr_ticket,";
                str += "tab_ticket.serie as SerieTicket,";
                str += "tab_meio_pagto.meio_pagto as Meio_pagto,";
                str += "tab_mov_caixa.id_operador as Id_operador,";
                str += "tab_pw4.nome as Nome_operador,";
                str += "tab_ticket.cpf_cnpj as Cpf_cnpj";

                str += " FROM `tab_mov_caixa`  join  `tab_ticket` ";
                str += " on tab_mov_caixa.id_ticket=tab_ticket.id ";
                str += " join  `tab_meio_pagto` ";
                str += " on tab_mov_caixa.id_meio_pagto=tab_meio_pagto.id ";
                str += " join  `tab_pw4` ";
                str += " on tab_mov_caixa.id_operador=tab_pw4.id ";

                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    lista = connection.Query<MovCaixaDTO>(str).ToList();
                }

            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro Listar Mov Caixa repository: " + ex.Message.ToString(), MessageType.Error);
            }

            return lista;
        }

        public String InsereVenda(List<PedidoDTO> Pedido, TicketDTO ticket, MovCaixaDTO Movimento)
        {
            String resp = "Erro";

            try
            {


                if (Pedido.Count() > 0 && !String.IsNullOrEmpty(conn_str))
                {
                    // Entra com ticket Totalizado.


                    String Str = "  INSERT INTO `tab_ticket`";
                    Str += "(";
                    Str += "`id`,";
                    Str += "`nr_ticket`,";
                    Str += "`serie`,";
                    Str += "`valor`,";
                    Str += "`data`,";
                    Str += "`cpf_cnpj`";
                    Str += ")";
                    Str += " VALUES (";
                    Str += "@id_ticket,";
                    Str += "@nr_ticket,";
                    Str += "@serie, ";
                    Str += "@valor,";
                    Str += "@data,";
                    Str += "@cpf_cnpj";

                    Str += ")";

                    var agora = DateTime.Now;
                    var p = new DynamicParameters();
                    p.Add("@id_ticket", ticket.Id);
                    p.Add("@nr_ticket", ticket.Nr_ticket);
                    p.Add("@serie", ticket.Serie);
                    p.Add("@valor", ticket.Valor);
                    p.Add("@data", ticket.Dt_ticket.ToString("yyyy-MM-dd HH:mm:ss"));
                    p.Add("@cpf_cnpj", ticket.Cpf_cnpj);



                    //produtos ===================================================================================================

                    String Str1 = "INSERT INTO tab_pedido ";
                    Str1 += " ( id_ticket, ";
                    Str1 += " id_produto, ";
                    Str1 += " quantidade, ";
                    Str1 += " valor, ";
                    Str1 += " valor_total, ";
                    Str1 += " data";
                    Str1 += " ) ";

                    Str1 += "VALUES ";

                    var cont = 0;

                    String str4 = "UPDATE  tab_produto ";
                    str4 += "SET saldo =  CASE id ";
                    String ids = "";

                    foreach (var iteml in Pedido)
                    {
                        if (cont > 0) { Str1 += ","; ids += ","; }

                        Str1 += "(";
                        Str1 += $"{iteml.Id_ticket},";
                        Str1 += $"{iteml.Id_produto},";
                        Str1 += $"{iteml.Qtd},";
                        Str1 += $"{iteml.Valor.ToString().Replace(",", ".")},";
                        Str1 += $"{iteml.ValorTotal.ToString().Replace(",", ".")},";
                        Str1 += $"'{iteml.Data.ToString("yyyy-MM-dd HH:mm:ss")}')";

                        str4 += $" WHEN {iteml.Id_produto} THEN saldo - {iteml.Qtd}";
                        ids += $"{iteml.Id_produto}";

                        cont++;
                    }

                    str4 += " END ";
                    str4 += $" WHERE id IN ({ids} ) ";


                    //========= Movimentacao de caixa

                    String Str2 = "  INSERT INTO `tab_mov_caixa`";
                    Str2 += "(";

                    Str2 += "`id_caixa`,";
                    Str2 += "`dt_operacao`,";
                    Str2 += "`valor`,";
                    Str2 += "`id_meio_pagto`,";
                    Str2 += "`desconto`,";
                    Str2 += "`valor_final`,";
                    Str2 += "`id_ticket`,";
                    Str2 += "`id_operador`";
                    Str2 += ")";
                    Str2 += " VALUES (";

                    Str2 += "@id_caixa,";
                    Str2 += "@dt_operacao, ";
                    Str2 += "@valorTotal,";
                    Str2 += "@id_meio_pagto,";
                    Str2 += "@desconto,";
                    Str2 += "@valor_final,";
                    Str2 += "@id_ticket1,";
                    Str2 += "@id_operador";
                    Str2 += ")";


                    p.Add("@id_caixa", Movimento.Id_caixa);
                    p.Add("@dt_operacao", Movimento.Dt_operacao);
                    p.Add("@valorTotal", Movimento.Valor);
                    p.Add("@id_meio_pagto", Movimento.Id_meio_pagto);
                    p.Add("@desconto", Movimento.Desconto);

                    p.Add("@valor_final", Movimento.Valor_final);
                    p.Add("@id_ticket1", Movimento.Id_ticket);
                    p.Add("@id_operador", Movimento.Id_operador);



                    //================================


                    String Str3 = $"{Str};{Str1};{Str2};{str4}";



                    using (IDbConnection connection = new SQLiteConnection(conn_str))
                    {

                        connection.Open();
                        using (var trans = connection.BeginTransaction())
                        {
                            try
                            {
                                connection.Execute(Str3, p, transaction: trans);
                                trans.Commit();

                                resp = "OK";

                            }
                            catch (Exception ex)
                            {
                                LogEvento.EscreverEvento($"Erro ao criar venda rollback {ex.Message}", MessageType.Error);
                                trans.Rollback();
                            }

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                resp = "Erro";
                LogEvento.EscreverEvento($"Erro ao criar venda {ex.Message}", MessageType.Error);
            }



            return resp;

        }



        #endregion

        #region Ticket

        public List<TicketDTO> ListarTicket()
        {
            var lista = new List<TicketDTO>();
            try
            {
                String str = "SELECT ";
                str += "id as Id ,";
                str += "nr_ticket as Nr_ticket,";
                str += "serie as Serie,";
                str += "valor as Valor,";
                str += "data as Dt_ticket,";
                str += "cpf_cnpj as Cpf_cnpj ";
                str += " FROM `tab_ticket` ";


                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    lista = connection.Query<TicketDTO>(str).ToList();
                }

            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro Listar ticket repository: " + ex.Message.ToString(), MessageType.Error);
            }

            return lista;
        }

        public String InsereTicket(TicketDTO ticket)
        {
            String retorno = "Erro";
            try
            {


                String sql = "INSERT INTO `tab_ticket`   ";
                sql += "(";
                sql += "nr_ticket ,";
                sql += "serie,";
                sql += "valor,";
                sql += "data,";
                sql += "cpf_cnpj  ";
                sql += ")";

                sql += " VALUES ";
                sql += " (";
                sql += " @nr_ticket,";
                sql += " @serie,";
                sql += " @valor,";
                sql += " @data,";
                sql += " @cnpj ";
                sql += ")";


                var p = new DynamicParameters();

                p.Add("@nr_ticket", ticket.Nr_ticket);
                p.Add("@serie", ticket.Serie);
                p.Add("@data", ticket.Dt_ticket);
                p.Add("@valor", ticket.Valor);
                p.Add("@cnpj", ticket.Cpf_cnpj);

                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(sql, p);
                    retorno = "OK";
                }

            }
            catch (Exception ex)
            {
                retorno = ex.Message.ToString();
                LogEvento.EscreverEvento("Erro Inserir Caixa repository: " + ex.Message.ToString(), MessageType.Error);

            }

            return retorno;
        }

        #endregion

        #region Pedido
        public List<PedidoDTO> ListarPedido()
        {
            var lista = new List<PedidoDTO>();
            try
            {
                String str = "SELECT ";
                str += "tab_pedido.id as Id ,";
                str += "tab_pedido.id_ticket as Id_ticket,";
                str += "tab_pedido.id_produto as Id_produto,";
                str += "tab_produto.descricao as DescGrid,";
                str += "tab_pedido.quantidade as Qtd,";
                str += "tab_pedido.valor as Valor,";
                str += "tab_pedido.valor_total as ValorTotal,";
                str += "tab_pedido.data as Data ";

                str += " FROM `tab_pedido` join `tab_produto`";
                str += " on tab_pedido.id_produto= tab_produto.id";

                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    lista = connection.Query<PedidoDTO>(str).ToList();
                }

            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro Listar pedido repository: " + ex.Message.ToString(), MessageType.Error);
            }

            return lista;
        }


        public String InserePedido(PedidoDTO pedido)
        {
            String retorno = "Erro";
            try
            {


                String sql = "INSERT INTO `tab_ticket`   ";
                sql += "(";
                sql += "id_ticket ,";
                sql += "id_produto,";
                sql += "quantidade,";
                sql += "valor,";
                sql += "data  ";
                sql += ")";

                sql += " VALUES ";
                sql += " (";
                sql += " @id_ticket,";
                sql += " @id_produto,";
                sql += " @quantidade,";
                sql += " @valor,";
                sql += " @data ";
                sql += ")";


                var p = new DynamicParameters();

                p.Add("@id_ticket", pedido.Id_ticket);
                p.Add("@id_produto", pedido.Id_produto);
                p.Add("@quantidade", pedido.Qtd);
                p.Add("@valor", pedido.Valor);
                p.Add("@data", pedido.Data);

                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(sql, p);
                    retorno = "OK";
                }

            }
            catch (Exception ex)
            {
                retorno = ex.Message.ToString();
                LogEvento.EscreverEvento("Erro Inserir pedido repository: " + ex.Message.ToString(), MessageType.Error);

            }

            return retorno;
        }
        #endregion

        #region Cliente
        public List<ClienteDTO> ClienteListar()
        {
            var lista = new List<ClienteDTO>();
            try
            {
                String str = "SELECT ";
                str += "id as id ,";
                str += "nome as Nome,";
                str += "cpf_cnpj as Cpf_cnpj,";
                str += "end as End,";
                str += "numero_end as Num,";
                str += "bairro as Bairro,";
                str += "cidade as Cidade,";
                str += "telefone as Telefone,";
                str += "email as Email ,";
                str += "contri_mensal as Contri,";
                str += "data_contri as Data, ";
                str += "`nr_cep` as Cep,";
                str += "uf as Uf, ";
                str += " fis_jur as Fis_jur";
                str += " FROM `tab_cliente` ";


                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    lista = connection.Query<ClienteDTO>(str).ToList();
                }

            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro Listar cliente repository: " + ex.Message.ToString(), MessageType.Error);
            }

            return lista;
        }
        public List<ClienteHistoricoDTO> ClienteHistoricoListar()
        {
            var lista = new List<ClienteHistoricoDTO>();

            try
            {
                String str = "SELECT ";
                str += "id as id ,";
                str += "data as data,";
                str += "Valor as valor,";
                str += "id_cliente as id_cliente,";
                str += "referencia as referencia";
            
                str += " FROM `tab_historico_cliente` ";


                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    lista = connection.Query<ClienteHistoricoDTO>(str).ToList();
                }

            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro Listar cliente repository: " + ex.Message.ToString(), MessageType.Error);
            }

            return lista;
        }

        public String ClienteInserir(ClienteDTO cliente)
        {
            String retorno = "Erro";
            try
            {


                String sql = "INSERT INTO `tab_cliente`   ";
                sql += "(`nome`,";
                sql += "`cpf_cnpj`,";
                sql += "`end`,";
                sql += "`numero_end`,";
                sql += "`bairro`,";
                sql += "`cidade`,";
                sql += "`telefone`,";
                sql += "`email`,";
                sql += "`contri_mensal`,";
                sql += "`data_contri`,";
                sql += "`uf`,";
                sql += "`nr_cep`,";
                sql += "`fis_jur`, ";
                sql += "`data_cadastro` )";

                sql += " VALUES ";
                sql += " (";
                sql += " @nome,";
                sql += " @cpf,";
                sql += " @end,";
                sql += " @numero_end,";
                sql += " @bairro,";
                sql += " @cidade,";
                sql += " @telefone,";
                sql += " @email,";
                sql += " @contri_mensal,";
                sql += " @data_contri,";
                sql += " @uf,";
                sql += " @cep,";
                sql += " @fisjur,";
                sql += "@datareg )";

                var p = new DynamicParameters();

                p.Add("@nome", cliente.Nome);
                p.Add("@cpf", cliente.Cpf_cnpj);
                p.Add("@end", cliente.End);
                p.Add("@numero_end", cliente.Num);
                p.Add("@bairro", cliente.Bairro);
                p.Add("@cidade", cliente.Cidade);
                p.Add("@telefone", cliente.Telefone);
                p.Add("@email", cliente.Email);
                p.Add("@contri_mensal", cliente.Contri);
                p.Add("@data_contri", cliente.Data);
                p.Add("@uf", cliente.Uf);
                p.Add("@cep", cliente.Cep);
                p.Add("@fisjur", cliente.Fis_jur);
                p.Add("@datareg", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(sql, p);
                    retorno = "OK";
                }

            }
            catch (Exception ex)
            {
                retorno = ex.Message.ToString();
                LogEvento.EscreverEvento("Erro inserir cliente repository: " + ex.Message.ToString(), MessageType.Error);

            }

            return retorno;
        }
        public String ClienteEditar(ClienteDTO cliente)
        {
            String retorno = "Erro";
            try
            {
                String sql = "UPDATE  tab_cliente ";
                sql += "SET ";
               
                sql += "nome = @nome,";
                sql += "cpf_cnpj = @cpf,";
                sql += "end = @end,";
                sql += "numero_end = @numero_end,";
                sql += "bairro = @bairro,";
                sql += "cidade = @cidade,";
                sql += "telefone = @telefone,";
                sql += "email = @email,";
                sql += "contri_mensal = @contri_mensal,";
                sql += "data_contri = @data_contri,";
                sql += "uf = @uf,";
                sql += "nr_cep = @cep,";
                sql += "fis_jur = @fis_jur";

                sql += " WHERE  id = @id;";

                var p = new DynamicParameters();
                p.Add("@id", cliente.id);
                p.Add("@nome", cliente.Nome);
                p.Add("@cpf", cliente.Cpf_cnpj);
                p.Add("@end", cliente.End);
                p.Add("@numero_end", cliente.Num);
                p.Add("@bairro", cliente.Bairro);
                p.Add("@cidade", cliente.Cidade);
                p.Add("@telefone", cliente.Telefone);
                p.Add("@email", cliente.Email);
                p.Add("@contri_mensal", cliente.Contri);
                p.Add("@data_contri", cliente.Data);
                p.Add("@uf", cliente.Uf);
                p.Add("@cep", cliente.Cep);
                p.Add("@fis_jur", cliente.Fis_jur);


                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(sql, p);
                    retorno = "OK";
                }

            }
            catch (Exception ex)
            {
                retorno = ex.Message.ToString();
                LogEvento.EscreverEvento("Erro editar cliente repository: " + ex.Message.ToString(), MessageType.Error);

            }

            return retorno;
        }

        #endregion

        #region Forma pagto

        public List<FormaPagtoDTO> ListarFormaPagto()
        {
            var lista = new List<FormaPagtoDTO>();
            String str = "SELECT ";
            str += "id as Id ,";
            str += "meio_pagto as Meio_pagto,";
            str += "grupo as Grupo";
            str += " FROM tab_meio_pagto";


            using (IDbConnection connection = new SQLiteConnection(conn_str))
            {
                lista = connection.Query<FormaPagtoDTO>(str).ToList();
            }


            return lista;
        }
        public String FormaPagtoInserir(FormaPagtoDTO forma)
        {
            String retorno = "Erro";
            try
            {
                String sql = "INSERT INTO `tab_meio_pagto`   ";
                sql += "(`meio_pagto`,";
                sql += "`grupo`)";
                 sql += " VALUES ";
                sql += " (";
                sql += " @meio_pagto,";
                sql += " @grupo)";
                var p = new DynamicParameters();
                p.Add("@meio_pagto", forma.Meio_pagto);
                p.Add("@grupo", forma.Grupo);
                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(sql, p);
                    retorno = "OK";
                }
            }
            catch (Exception ex)
            {
                LogEvento.EscreverEvento("Erro inserir forma de pagamento repository: " + ex.Message.ToString(), MessageType.Error);
            }
            return retorno;
        }
        public String FormaPagtoEditar(FormaPagtoDTO forma)
        {
            String retorno = "Erro";
            try
            {
                String sql = "UPDATE  tab_meio_pagto ";
                sql += "SET ";
                sql += "meio_pagto = @meio_pagto,";
                sql += "grupo = @grupo";
                sql += " WHERE  id = @id;";
                var p = new DynamicParameters();
                p.Add("@id", forma.Id);
                p.Add("@meio_pagto", forma.Meio_pagto);
                p.Add("@grupo", forma.Grupo);

                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    connection.Execute(sql, p);
                    retorno = "OK";
                }

            }
            catch (Exception ex)
            {
                retorno = ex.Message.ToString();
                LogEvento.EscreverEvento("Erro editar forma de pagamento  repository: " + ex.Message.ToString(), MessageType.Error);

            }

            return retorno;
        }

        #endregion

        #region fechamento

        public List<ResumoFechamentoDTO> ListarMovFecha(String dtIni, String dtFim)
        {
            var lista_caixa = new List<ResumoFechamentoDTO>();

            String str = "Select meio_pagto as Meio_pagto,";
            str += " tipo_produto as Grupo_produto,";
            str += " sum(total_meio) as  Valor_final";
            str += " From(";
            str += " select ";
            str += " tab_pedido.id_ticket, tab_meio_pagto.grupo as meio_pagto,";
            str += "   tab_tipo_produto.tipo_produto as tipo_produto,";
            str += " sum(tab_pedido.quantidade * tab_pedido.valor) * round(100 - tab_mov_caixa.desconto, 2) / 100 as total_meio ";
            str += " From tab_mov_caixa Join ";
            str += " tab_pedido on tab_mov_caixa.id_ticket = tab_pedido.id_ticket ";
            str += " Join tab_produto on tab_pedido.id_produto = tab_produto.id ";
            str += " Join tab_tipo_produto on tab_produto.id_familia = tab_tipo_produto.id ";
            str += " Join tab_meio_pagto on tab_mov_caixa.id_meio_pagto = tab_meio_pagto.id ";
            str += " where  tab_mov_caixa.dt_operacao >= @dtIni  and ";
            str += " tab_mov_caixa.dt_operacao <=  @dtFim  ";
            str += " group by  tab_meio_pagto.grupo, tab_tipo_produto.id, tab_pedido.id_ticket) ";
            str += " group by meio_pagto,tipo_produto order by meio_pagto ";








            try
            {
               

                var p = new DynamicParameters();

                p.Add("@dtIni", $"{dtIni} 00:00:00");
                p.Add("@dtFim", $"{dtFim} 23:59:59");

                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    var retorno = connection.Query<ResumoFechamentoDTO>(str, p).ToList();

                    lista_caixa = retorno;
                }



            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro listar Relatorio de fechamento: " + ex.Message.ToString(), MessageType.Error);
            }



            return lista_caixa;
        }

        #endregion

        #region Estados

        public List<EstadosDTO> ListarEstados(String cod)
        {
            var lista_estado = new List<EstadosDTO>();

            String str = "Select ";
            str += "cod,";
            str += "estado,";
            str += "sigla as Uf";

            str += " From tab_estados";
            try
            {
                if (!String.IsNullOrEmpty(cod))
                {
                    str += " where cod = @Ncod ";
                }

                var p = new DynamicParameters();

                p.Add("@Ncod", cod);


                using (IDbConnection connection = new SQLiteConnection(conn_str))
                {
                    var retorno = connection.Query<EstadosDTO>(str, p).ToList();

                    lista_estado = retorno;
                }



            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro listar estados repository: " + ex.Message.ToString(), MessageType.Error);
            }



            return lista_estado;

        }


        #endregion


        #region Dash board

        public List<DashDTO> Db_venda_produto(String dt_in, String dt_fim, String ordem)
        {
            List<DashDTO> j = null;
            if (Information.IsDate(dt_in) && Information.IsDate(dt_fim))
            {


                try
                {
                    String Str = "Select ";
                    Str += "tab_produto.Descricao as Item,";
                    Str += "Sum(tab_pedido.quantidade) as Valor1,";
                    Str += "Cast(sum(tab_pedido.valor) AS REAL) as Valor2 ";
                    Str += " from tab_pedido";
                    Str += " join tab_produto on (tab_pedido.id_produto = tab_produto.id)";
                    Str += " where date(tab_pedido.data)>= date(@dt_in) and date(tab_pedido.data)<= date(@dt_fim)";
                    Str += " group by tab_produto.Descricao";
                    if(ordem=="V")
                    Str += " order by sum(tab_pedido.valor) desc LIMIT 10";
                    if (ordem == "Q")
                        Str += " order by sum(tab_pedido.quantidade) desc LIMIT 10";
                    var p = new DynamicParameters();

                    p.Add("@dt_in", dt_in);
                    p.Add("@dt_fim", dt_fim);


                    using (IDbConnection connection = new SQLiteConnection(conn_str))
                    {
                        j = connection.Query<DashDTO>(Str,p).ToList();
                    }

                }
                catch (Exception ex)
                {
                    LogEvento.EscreverEvento("Erro em HistoricoClientesVendas repository: " + ex.Message.ToString(), MessageType.Error);
                }

            }
            return j;

        }

        public List<DashDTO> Db_venda_familiaValor(String dt_in, String dt_fim)
        {
            List<DashDTO> j = null;
            if (Information.IsDate(dt_in) && Information.IsDate(dt_fim))
            {


                try
                {
                    String Str = "Select ";
                    Str += " tab_tipo_produto.tipo_produto as Item,";
                    Str += "Sum(tab_pedido.quantidade) as Valor1,";
                    Str += "Cast(Sum(tab_pedido.valor_total) AS REAL) as Valor2 ";
                    Str += " from tab_pedido";
                    Str += " join tab_produto on tab_pedido.id_produto = tab_produto.id";
                    Str += " join tab_tipo_produto on tab_produto.id_familia = tab_tipo_produto.id";
                    Str += " where date(tab_pedido.data)>= date(@dt_in) and date(tab_pedido.data)<= date(@dt_fim)";
                    Str += " group by tab_produto.id_familia";
                    Str += " order by sum(tab_pedido.valor) desc LIMIT 10";

                    var p = new DynamicParameters();

                    p.Add("@dt_in", dt_in);
                    p.Add("@dt_fim", dt_fim);


                    using (IDbConnection connection = new SQLiteConnection(conn_str))
                    {
                        j = connection.Query<DashDTO>(Str, p).ToList();
                    }

                }
                catch (Exception ex)
                {
                    LogEvento.EscreverEvento("Erro em vendas_familia repository: " + ex.Message.ToString(), MessageType.Error);
                }

            }
            return j;

        }



        public List<DashDTO> Db_venda_MeioValor(String dt_in, String dt_fim)
        {
            List<DashDTO> j = null;
            if (Information.IsDate(dt_in) && Information.IsDate(dt_fim))
            {


                try
                {
                    String Str = "Select ";
                    Str += " tab_meio_pagto.grupo as Item,";
                    Str += "Count(id_meio_pagto) as Valor1,";
                    Str += "Cast(sum(tab_mov_caixa.valor_final) AS REAL) as Valor2 ";
                    Str += " from tab_mov_caixa ";
                    Str += " join tab_meio_pagto on tab_mov_caixa.id_meio_pagto =tab_meio_pagto.id";
                 
                    Str += " where date(tab_mov_caixa.dt_operacao)>= date(@dt_in) and date(tab_mov_caixa.dt_operacao)<= date(@dt_fim)";
                    Str += " group by  tab_meio_pagto.grupo";
                     

                    var p = new DynamicParameters();

                    p.Add("@dt_in", dt_in);
                    p.Add("@dt_fim", dt_fim);


                    using (IDbConnection connection = new SQLiteConnection(conn_str))
                    {
                        j = connection.Query<DashDTO>(Str, p).ToList();
                    }

                }
                catch (Exception ex)
                {
                    LogEvento.EscreverEvento("Erro em vendas_familia repository: " + ex.Message.ToString(), MessageType.Error);
                }

            }
            return j;

        }
        #endregion
    }
}
