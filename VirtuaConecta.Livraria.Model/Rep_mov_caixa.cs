using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaConecta.Livraria.Model
{
    public class Rep_mov_caixa
    {
        public Int32 nr_caixa { get; set; }
        public String operador { get; set; }
        public DateTime data { get; set; }
        public Decimal livros { get; set; }
        public Decimal bazar { get; set; }
        public Decimal aromas { get; set; }
        public Decimal mensalidade { get; set; }
        public Decimal farmacia { get; set; }
        public Decimal lanchonte { get; set; }
        public Decimal doacoes { get; set; }
        public Decimal eventos { get; set; }
        public String  meio_pagto { get; set; }
        public Decimal cursos { get; set; }
        public Decimal outros { get; set; }
        public Decimal total_meio { get; set; }
    }
}
