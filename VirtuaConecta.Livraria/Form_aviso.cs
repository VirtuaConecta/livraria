using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtuaConecta.Outbound.AI
{
    public partial class Form_aviso : Form
    {

        /// <summary>
        /// Se o form foi iniciado
        /// </summary>
        public bool Started;

        public Form_aviso()
        {
            InitializeComponent();
        }

        public void ShowDiag()
        {
            try
            {
                Application.DoEvents();
                ShowDialog();
            }
            catch (Exception)
            {
                //
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Shown"/> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.EventArgs"/> that contains the event data. </param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Application.DoEvents();
            BringToFront();
            Started = true;
        }

    }
}
