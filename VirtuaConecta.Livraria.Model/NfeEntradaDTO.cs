using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Livraria.Model
{
    public class NfeEntradaDTO
    {
        public HeadEntrada Head { get; set; }
        public List<ItensEntrada> Itens { get; set; }
    }


    public class HeadEntrada
    {
        public DateTime Data_emissao { get; set; }
        public DateTime? Data_entrada { get; set; }
        public String Nr_nf { get; set; }
        public String Serie { get; set; }
        public Decimal Valor_Total { get; set; }
        public String Tipo_pedido { get; set; }
        public String Especie { get; set; }
        public String Telefone_for { get; set; }
        public Decimal Nr_volumes { get; set; }
        public Decimal Peso_brt { get; set; }
        public Decimal Peso_liq { get; set; }
        public String Chave_nfe { get; set; }
        public String InfoAdicional { get; set; }
        public String Nome_for { get; set; }
        public String Cnpj_Cpf_for { get; set; }
        public String Fis_jur_for { get; set; }
        public String  email_for { get; set; }
        public String IE_for { get; set; }
        public String Endereco_for { get; set; }
        public String Cidade_for { get; set; }
        public String Cep_For { get; set; }
        public String Estado_for { get; set; }
        public String Cod_municipio_for { get; set; }
        public String Bairro_for { get; set; }
        public String Nome_destino { get; set; }
        public String Cnpj_Cpf_dest { get; set; }
        public String IE_destino { get; set; }
        public String Cep_destino { get; set; }
        public String Endereco_destino { get; set; }
        public String Bairro_destino { get; set; }
        public String Cidade_destino { get; set; }
        public String Estado_destino { get; set; }
        public String Cod_municipio_destino { get; set; }
        public String Telefone_destino { get; set; }
        public String Fis_jur_destino { get; set; }
    }
    public class ItensEntrada
    {
        public String Sku { get; set; }
        public String Especie { get; set; }
        public String Ean { get; set; }
        public String Ncm { get; set; }
        public Decimal Qtd { get; set; }
        public String Descricao_prod { get; set; }
        public Decimal Valor_unit { get; set; }
    }
}
