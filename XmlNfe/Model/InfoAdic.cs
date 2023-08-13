using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlNfe.Model
{ 
    public class InfoAdic
    {
        [XmlElement("infCpl")]
        public String infCpl { get; set; }

    }
}
