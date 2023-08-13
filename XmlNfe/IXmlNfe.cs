using System;
using System.Collections.Generic;
using System.Text;
using XmlNfe.Model;

namespace XmlNfe
{
   public interface IXmlNfe
    {
        NFeProc GetXmlNfe(string arquivo);
        CFe GetXmlCFe(string arquivo);
    }
}
