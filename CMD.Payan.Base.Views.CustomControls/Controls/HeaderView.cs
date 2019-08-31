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
    public partial class HeaderView : Payanar.SS.Net.Libraries.Views.CustomControls.HeaderView
    {
        #region Constructors

        public HeaderView()
            : base()
        {
            InitializeComponent();
        }

        public HeaderView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(presenterFactory)
        {
            InitializeComponent();
        }

        public HeaderView(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(observer, presenterFactory)
        {
            InitializeComponent();
        }

        #endregion Constructors
    }
}