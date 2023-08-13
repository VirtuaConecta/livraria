using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace VirtuaConecta.Outbound.AI
{
    public partial class Form1 : Form
    {
        String Url = Parametros.Parametros.UrlPlugin();
        private readonly ChromiumWebBrowser browser;
        public Form1()
        {
            InitializeComponent();

            browser = new ChromiumWebBrowser(Url)
            {
                Dock = DockStyle.Fill,
                Size = new Size(600, 600),
                Location = new Point(200, 200),

            };

        }


                     

        private void Form1_Load(object sender, EventArgs e)
        {
    
            this.panel1.Controls.Add(browser);
            browser.FrameLoadEnd += (s, arg) =>
            {

                try
                {

                    if (arg.Frame.IsMain)
                    {
                        //  browser.ExecuteScriptAsync("document.getElementById('objetos').value='BR^1234567890");


                        browser.ExecuteScriptAsync("document.getElementById('cod_usuario').value='teste';");

                        browser.ExecuteScriptAsync("document.getElementsByName('senha_usuario')[0].value='teste01';");

                        browser.ExecuteScriptAsync("document.getElementsByName('sub1')[0].click();");

                       //
                        browser.Load(Url + "prog/pedido_web/dados_cliente/pgw0045/pgw0045.php?vazio=0&cliente=000159416000157");
                    }
                }
                catch (Exception ex)
                {

                    var err = ex;
                }
            };
        }

   
        
    }



               
           
}
