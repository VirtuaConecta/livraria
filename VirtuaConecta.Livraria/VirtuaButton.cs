using System;
using System.Drawing;
using System.Windows.Forms;

namespace VirtuaConecta.Outbound.AI
{
    class VirtuaButton : Control
    {
        //variaveis
        private SolidBrush borderBrush, textBrush;
        private Rectangle borderRectangle;
        private bool active = false;
        private StringFormat stringFormat = new StringFormat();

        //Propriedades
        public override Cursor Cursor { get; set; } = Cursors.Arrow;
        public float BorderThickness { get; set; } = 0;


        public VirtuaButton()
        {
            borderBrush = new SolidBrush(Color.FromKnownColor(KnownColor.ButtonHighlight));
            textBrush = new SolidBrush(ColorTranslator.FromHtml("#FFF"));
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            this.Paint += VirtuaButton_Paint;
      
        }

        private void VirtuaButton_Paint(object sender, PaintEventArgs e)
        {
            borderRectangle = new Rectangle(0, 0, Width, Height);
            e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), borderRectangle);
            e.Graphics.DrawString(this.Text, this.Font, (active) ? textBrush : borderBrush, borderRectangle, stringFormat);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            base.BackColor = Color.FromKnownColor(KnownColor.Teal);
            active = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            base.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight);
            active = false;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            base.BackColor = Color.FromKnownColor(KnownColor.Teal);
            active = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            base.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight);
            active = false;
        }
    }
}
