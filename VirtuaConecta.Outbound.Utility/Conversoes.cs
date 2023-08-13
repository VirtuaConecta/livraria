using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtuaConecta.Outbound.Utility
{
    public class Conversoes
    {


        public Conversoes()
        {

        }
        public static DateTime? StringToDate(String data, String formato)
        {
            DateTime? dataRet = null;
            try
            {
                String dia = null; ;
                String mes = null;
                String ano = null;

                if (formato == "dd/mm/yyyy")
                {
                    dia = data.Substring(0, 2);
                    mes = data.Substring(3, 2);
                    ano = data.Substring(6, 4);


                }
                else if (formato == "mm/dd/yyyy")
                {
                    mes = data.Substring(0, 2);
                    dia = data.Substring(3, 2);
                    ano = data.Substring(6, 4);
                }
                var dataCompleta = String.Format("{0}-{1}-{2}", ano, mes, dia);
                dataRet = Convert.ToDateTime(dataCompleta);

            }
            catch (Exception ex)
            {


            }

            return dataRet;
        }

        public static String LimpaFormato(String texto)
        {
            return texto.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "").Replace(@"\", "").Replace("|", "");

        }

        public static String Nz(String Valor, String str)
        {
            String retorno;
            if (String.IsNullOrEmpty(Valor))
            {
                retorno = str;
            }
            else
            {
                retorno = Valor;
            }
            return retorno;
        }

        public static object GetValObjBy(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }

        public static DataTable ToDataTable<T>(List<T> iList)
        {
            List<Type> types = null;
            types = new List<Type>();
            DataTable dataTable = new DataTable();

            try
            {

                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (PropertyInfo prop in Props)
                {
                    dataTable.Columns.Add(prop.Name, prop.PropertyType);
                }

                foreach (T item in iList)
                {
                    if (item != null)
                    {
                        DataRow dr = dataTable.NewRow();

                        foreach (PropertyInfo p in Props)
                        {
                            //If struct type
                            if (types.IndexOf(p.PropertyType) >= 0)
                            {
                                dr[p.Name] = p.GetValue(item);
                            }
                            else
                            {
                                dr[p.Name] = p.GetValue(item) ?? null;
                            }
                        }

                        dataTable.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {

                var t = ex;
            }
            return dataTable;
        }


        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }



    }
}
