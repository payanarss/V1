using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMD.Payan.Base.PresentationLayer.Interfaces;

namespace CMD.Payan.Base.Views.CustomControls
{
    public partial class HeaderDetailDataGridView : Payanar.SS.Net.Libraries.Views.CustomControls.HeaderDetailDataGridView
    {
        #region Constructors

        public HeaderDetailDataGridView()
            : base()
        {
        }

        public HeaderDetailDataGridView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(presenterFactory)
        {
        }

        public HeaderDetailDataGridView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IViewContext viewContext)
            : base(viewContext)
        {
        }

        public HeaderDetailDataGridView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IViewContext viewContext, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(viewContext, presenterFactory)
        {
        }

        #endregion Constructors
    }
}