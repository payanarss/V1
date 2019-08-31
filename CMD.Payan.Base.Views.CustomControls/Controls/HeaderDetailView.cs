using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMD.Payan.Base.Common;
using CMD.Payan.Base.PresentationLayer.Interfaces;

namespace CMD.Payan.Base.Views.CustomControls
{
    public partial class HeaderDetailView : Payanar.SS.Net.Libraries.Views.CustomControls.HeaderDetailView
    {
        #region Constructors

        public HeaderDetailView()
            : base()
        {
            InitializeComponent();
        }

        public HeaderDetailView(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(observer, presenterFactory)
        {
            InitializeComponent();
        }

        #endregion Constructors
    }
}