using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Base.Views.CustomControls
{
    class DialogResultConverter
    {
        public static CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult Convert(System.Windows.Forms.DialogResult dialogResult)
        {
            CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult result = CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult.OK;

            switch (dialogResult)
            {
                case System.Windows.Forms.DialogResult.Abort:
                    result = CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult.Abort; break;
                case System.Windows.Forms.DialogResult.Cancel:
                    result = CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult.Cancel; break;
                case System.Windows.Forms.DialogResult.Ignore:
                    result = CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult.Ignore; break;
                case System.Windows.Forms.DialogResult.No:
                    result = CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult.No; break;
                case System.Windows.Forms.DialogResult.None:
                    result = CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult.None; break;
                case System.Windows.Forms.DialogResult.OK:
                    result = CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult.OK; break;
                case System.Windows.Forms.DialogResult.Retry:
                    result = CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult.Retry; break;
                case System.Windows.Forms.DialogResult.Yes:
                    result = CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult.Yes; break;
            }

            return result;
        }
    }
}