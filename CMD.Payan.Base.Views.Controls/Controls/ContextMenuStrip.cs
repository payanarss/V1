using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CMD.Payan.Base.Views.Controls
{
    public class ContextMenuStrip : Payanar.SS.Net.Libraries.Views.Controls.ContextMenuStrip
    {
        // Summary:
        //     Initializes a new instance of the System.Windows.Forms.ContextMenuStrip class.
        public ContextMenuStrip()
            : base()
        {
        }

        //
        // Summary:
        //     Initializes a new instance of the System.Windows.Forms.ContextMenuStrip class
        //     and associates it with the specified container.
        //
        // Parameters:
        //   container:
        //     A component that implements System.ComponentModel.IContainer that is the
        //     container of the System.Windows.Forms.ContextMenuStrip.
        public ContextMenuStrip(IContainer container)
            : base(container)
        {
        }
    }
}