using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CMD.Payan.Base.Views.Controls
{
    public class TextBox : Payanar.SS.Net.Libraries.Views.Controls.TextBox
    {
        public TextBox() { }

        private bool ControlInFocus { get; set; }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            ControlInFocus = true;
            Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            ControlInFocus = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawBorder(e.Graphics);
        }

        private void DrawBorder(Graphics g)
        {
            Color color = this.BackColor;

            if (ControlInFocus)
            {
                color = Color.Red;
            }

            g.DrawRectangle(new Pen(color), this.ClientRectangle.X, this.ClientRectangle.Y, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);
        }
    }
}