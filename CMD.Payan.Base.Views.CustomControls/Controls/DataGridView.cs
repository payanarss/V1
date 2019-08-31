using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMD.Payan.Base.PresentationLayer.Interfaces;
using CMD.Payan.Base.Common;
using System.IO;

namespace CMD.Payan.Base.Views.CustomControls
{
    public partial class DataGridView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView
    {
        #region Constructors

        public DataGridView()
            : base()
        {
        }

        public DataGridView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(presenterFactory)
        {
        }

        public DataGridView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(presenterFactory, presentationEntity)
        {
        }

        public DataGridView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IViewContext viewContext)
            : base(viewContext)
        {
        }

        public DataGridView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IViewContext viewContext, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(viewContext, presenterFactory)
        {
        }

        public DataGridView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IViewContext viewContext, CMD.Payan.Base.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(viewContext, observer, presenterFactory)
        {
        }

        #endregion Constructors
    }
}