using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlNfe.Model
{
    [XmlRoot(ElementName = "CFe")]
    public class CFe
    {
        [XmlElement("infCFe")]
        public infCFe CupmFiscalEletronico { get; set; }

    }
}
