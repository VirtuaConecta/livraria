using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XmlNfe.Model;

namespace XmlNfe
{
    public class XmNfe: IXmlNfe
    {

        public T GetObjectFromFile<T>(string arquivo) where T : class
        {


            try
            {

                var serialize = new XmlSerializer(typeof(T));
                var xmlArquivo = System.Xml.XmlReader.Create(arquivo);
                xmlArquivo.Read();
                //  var test = (T)serialize.Deserialize(xmlArquivo);

                var resp = (T)serialize.Deserialize(xmlArquivo);

                xmlArquivo.Close();
                return resp;


            }
            catch (Exception ex)
            {
                return null;
            }


        }

        public NFeProc GetXmlNfe(string arquivo)
        {

            return GetObjectFromFile<NFeProc>(arquivo);

        }

        public CFe GetXmlCFe(string arquivo)
        {

            return GetObjectFromFile<CFe>(arquivo);

        }
    }
}
