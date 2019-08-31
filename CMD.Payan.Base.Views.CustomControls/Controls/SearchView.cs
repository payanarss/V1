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

namespace CMD.Payan.Base.Views.CustomControls
{
    public partial class SearchView : Payanar.SS.Net.Libraries.Views.CustomControls.SearchView
    {
        #region Constructors

        public SearchView()
            : base()
        {
            InitializeComponent();
        }

        public SearchView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(presenterFactory)
        {
            InitializeComponent();
        }

        public SearchView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IViewContext viewContext)
            : base(viewContext)
        {
            InitializeComponent();
        }

        public SearchView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IViewContext viewContext, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(viewContext, presenterFactory)
        {
            InitializeComponent();
        }

        public SearchView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IViewContext viewContext, CMD.Payan.Base.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(viewContext, observer, presenterFactory)
        {
            InitializeComponent();
        }

        #endregion Constructors
    }
}