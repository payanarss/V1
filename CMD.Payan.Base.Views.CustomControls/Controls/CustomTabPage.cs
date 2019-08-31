using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.Views.Controls;
using System.Windows.Forms;
using CMD.Payan.Base.PresentationLayer.Interfaces;

namespace CMD.Payan.Base.Views.CustomControls
{
    public class CustomTabPage : Payanar.SS.Net.Libraries.Views.CustomControls.CustomTabPage
    {
        #region Constructors

        public CustomTabPage(BaseView view, int pageNumber)
            : base(view, pageNumber)
        {
        }

        #endregion Constructors
    }
}