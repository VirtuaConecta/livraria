
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtuaConecta.Outbound.Model;
using VirtuaConecta.Outbound.Parametros;
using VirtuaConecta.Outbound.Utility;

namespace VirtuaConecta.Outbound.AI
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
         static void Main()
        {
            try
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Run();
            }
            catch (Exception ex)
            {

                LogEvento.EscreverEvento("Erro ao iniciar programa " + ex.Message.ToString(), MessageType.Error);

            }

        }

        public static void Run()
        {
            try
            {

                var path = ConfigurationManager.AppSettings["servidor"];
                Global.LocalDb = "server=" + path + ";port=3306;user id=root;password=123456;persistsecurityinfo=True;database=virtua_tlmk; convert zero datetime=True";
                Form_login from_login = new Form_login();

                if (from_login.ShowDialog() == DialogResult.OK)
                {
                  //  CefSharpSettings.SubprocessExitIfParentProcessClosed = true;

                    //For Windows 7 and above, best to include relevant app.manifest entries as well
                   // Cef.EnableHighDPISupport();

                    //var settings = new CefSettings()
                    //{
                    //    //By default CefSharp will use an in-memory cache, you need to specify a Cache Folder to persist data
                    //    CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CefSharp\\Cache"),
                    //    BrowserSubprocessPath = @"x86\CefSharp.BrowserSubprocess.exe"
                    //};

                    //settings.CefCommandLineArgs.Add("enable-media-stream", "1");
                    //Cef.Initialize(settings, performDependencyCheck: false, browserProcessHandler: null);
                    Application.Run(new MainForm());
                }
                else
                {
                    Application.Exit();
                }


            }
            catch (Exception ex)
            {


                LogEvento.EscreverEvento("Erro ao iniciar programa Run" + ex.Message.ToString(), MessageType.Error);

            }


        }
       
    }
}
