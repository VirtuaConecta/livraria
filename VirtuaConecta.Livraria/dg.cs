using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtuaConecta.Outbound.AI
{
    public class dg
    {
        public static DataGridView GetDgStyle(DataGridView dg, int fontHead,int fonteItem)
        {
           
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", fontHead);
            dg.RowsDefaultCellStyle.Font = new Font("Arial", fonteItem);
            dg.BorderStyle = BorderStyle.None;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dg.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dg.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dg.BackgroundColor = Color.White;

            dg.EnableHeadersVisualStyles = false;
            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 96, 100);
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            return dg;
        }
    }
}
