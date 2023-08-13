using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlNfe.Model
{
    public class Transporte
    {
        public int modFrete { get; set; }

        [XmlElement("vol")]
        public Volumes Volumes { get; set; }
    }
}
