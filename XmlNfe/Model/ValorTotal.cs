using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlNfe.Model
{
    public class ValorTotal
    {

        [XmlElement("ICMSTot")]
        public Icms ICMSTot { get; set; }





    }
}
