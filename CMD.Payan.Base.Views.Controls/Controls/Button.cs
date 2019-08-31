using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CMD.Payan.Base.Views.Controls
{
    public class Button : Payanar.SS.Net.Libraries.Views.Controls.Button
    {
        public Button() { }

        private bool ControlInFocus { get; set; }
        private Cursor CurrentCursor { get; set; }

        protected override void OnMouseEnter(EventArgs e)
        {
            CurrentCursor = this.Cursor;

            base.OnMouseEnter(e);
            ControlInFocus = true;
            this.Cursor = Cursors.Hand;
            Invalidate(this.ClientRectangle);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            ControlInFocus = false;
            this.Cursor = CurrentCursor;
            Invalidate(this.ClientRectangle);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            DrawBorder(pevent.Graphics);
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