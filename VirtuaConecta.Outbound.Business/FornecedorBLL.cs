using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using VirtuaConecta.Livraria.Model;
using VirtuaConecta.Outbound.Repository.BaseRepo;
using VirtuaConecta.Outbound.Utility;

namespace VirtuaConecta.Outbound.Business
{
    public class FornecedorBLL:BaseBis.Ifornecedor
    {
        IdataConections _db;
        public FornecedorBLL()
        {
            _db = Factory.CriaConexao();
        }

        public bool ExisteFornecedor(String cpf_cnpj)
        {
            bool valida = false;

            var fornecedor = _db.FornecedorListar().Where(x => x.Cpf_cnpj == cpf_cnpj).FirstOrDefault();

            if (fornecedor != null && !String.IsNullOrEmpty(fornecedor.Cpf_cnpj))
            {
                valida = true;
            }

            return valida;
        }
        public List<FornecedorDTO> ListarFornecedor()
        {
            return _db.FornecedorListar();
        }
        public String InserirFornecedor(FornecedorDTO forn)
        {// tirar ponto e virgulas, barras etc



            return _db.FornecedorInserir(forn);
        }

        public String EditarFornecedor(FornecedorDTO forn)
        {
            return _db.FornecedorEditar(forn);
        }

        public String ValidaFornecedor(FornecedorDTO forn)
        {
            String validado = "OK";

            if (String.IsNullOrEmpty(forn.Nome))
            {
                validado = "Nome do fornecedor é nulo";
            }
            else if (String.IsNullOrEmpty(forn.Cpf_cnpj))
            {
                validado = "Cnpj/Cpf do fornecedor é nulo";
            }
            else if (String.IsNullOrEmpty(forn.Endereco))
            {
                validado = "Endereço do fornecedor é nulo";
            }
            else if (String.IsNullOrEmpty(forn.Bairro))
            {
                validado = "Bairro do fornecedor é nulo";
            }
            else if (String.IsNullOrEmpty(forn.Cep))
            {
                validado = "Cep do fornecedor é nulo";
            }
            else if (String.IsNullOrEmpty(forn.Cidade))
            {
                validado = "Cidade do fornecedor é nulo";
            }
            else if (String.IsNullOrEmpty(forn.Estado))
            {
                validado = "Estado do fornecedor é nulo";
            }

            else if (!Information.IsNumeric(forn.Cep))
            {
                validado = "Cep deve ser somente numeros";
            }
            else if (!String.IsNullOrEmpty(forn.Telefone) && !Information.IsNumeric(forn.Telefone))
            {
                validado = "Telefone deve ser somente numeros";
            }

            if (forn.Fis_jur=="F")
            {
             var retCpf=   ValidarCpf_Cnpj.checkCpf(forn.Cpf_cnpj);
                if(!retCpf)
                    validado = "Cpf é inválido";
            }
            else if (forn.Fis_jur == "J")
            {
                var retCnpj = ValidarCpf_Cnpj.checkCnpj(forn.Cpf_cnpj);
                if (!retCnpj)
                    validado = "Cnpj é inválido";
            }
            else
            {
                validado = "Cnpj/Cpf não identificado";
            }





            return validado;
        }
    }
}
