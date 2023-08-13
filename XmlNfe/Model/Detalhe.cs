using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlNfe.Model
{
    public class Detalhe
    {
        [XmlAttribute("nItem")]
        public int nItem { get; set; }

        [XmlElement("prod")]
        public Produto Produto { get; set; }
    }
}
