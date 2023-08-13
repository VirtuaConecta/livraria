using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlNfe.Model
{
    public class infCFe
    {
        [XmlAttribute("Id")]
        public string ChaveCFe { get; set; }

        [XmlElement("ide")]
        public IdentificacaoCFe Identificacao { get; set; }

        [XmlElement("emit")]
        public Emitente Emitente { get; set; }

        [XmlElement("dest")]
        public Destinatario Destinatario { get; set; }

        [XmlElement("det")]
        public List<Detalhe> Detalhe { get; set; }


        [XmlElement("total")]
        public ValorTotal Valor { get; set; }
    }
}
