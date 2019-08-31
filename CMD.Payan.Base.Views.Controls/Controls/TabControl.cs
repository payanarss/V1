using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMD.Payan.Base.Views.Controls
{
    public class TabControl : Payanar.SS.Net.Libraries.Views.Controls.TabControl
    {
        public TabControl()
        {
            ////this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque | ControlStyles.ResizeRedraw, true);
            ////this.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
        }

        ////protected override void OnPaintBackground(PaintEventArgs pevent)
        ////{
        ////    base.OnPaintBackground(pevent);
        ////    //ControlPaint.DrawBorder(pevent.Graphics, this.ClientRectangle, Color.DarkGreen, ButtonBorderStyle.Dotted);
        ////}

        ////protected override void OnPaint(PaintEventArgs e)
        ////{
        ////    //	We must always paint the entire area of the tab control
        ////    if (e.ClipRectangle.Equals(this.ClientRectangle))
        ////    {
        ////        //this.PaintTransparentBackground(e.Graphics, e.ClipRectangle);
        ////        this.DrawTabBorder(e.Graphics);
        ////    }
        ////    else
        ////    {
        ////        //	it is less intensive to just reinvoke the paint with the whole surface available to draw on.
        ////        this.Invalidate();
        ////    }
        ////}

        ////protected void PaintTransparentBackground(Graphics graphics, Rectangle clipRect)
        ////{

        ////    if ((this.Parent != null))
        ////    {

        ////        //	Set the cliprect to be relative to the parent
        ////        clipRect.Offset(this.Location);

        ////        //	Save the current state before we do anything.
        ////        GraphicsState state = graphics.Save();

        ////        //	Set the graphicsobject to be relative to the parent
        ////        graphics.TranslateTransform((float)-this.Location.X, (float)-this.Location.Y);
        ////        graphics.SmoothingMode = SmoothingMode.HighSpeed;

        ////        //	Paint the parent
        ////        PaintEventArgs e = new PaintEventArgs(graphics, clipRect);
        ////        try
        ////        {
        ////            this.InvokePaintBackground(this.Parent, e);
        ////            this.InvokePaint(this.Parent, e);
        ////        }
        ////        finally
        ////        {
        ////            //	Restore the graphics state and the clipRect to their original locations
        ////            graphics.Restore(state);
        ////            clipRect.Offset(-this.Location.X, -this.Location.Y);
        ////        }
        ////    }
        ////}

        ////private void DrawTabBorder(Graphics graphics)
        ////{
        ////    graphics.SmoothingMode = SmoothingMode.HighQuality;
        ////    Color borderColor;

        ////    borderColor = Color.DarkGreen;
        ////    using (Pen borderPen = new Pen(borderColor))
        ////    {
        ////        graphics.DrawRectangles(borderPen, new Rectangle[]{new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height)});
        ////    }
        ////}
    }
}