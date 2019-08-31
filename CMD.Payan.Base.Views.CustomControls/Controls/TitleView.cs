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
    public partial class TitleView : Payanar.SS.Net.Libraries.Views.CustomControls.TitleView
    {
        #region Constructors

        public TitleView()
            : base()
        {
            InitializeComponent();
        }

        public TitleView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(presenterFactory)
        {
            InitializeComponent();
        }

        public TitleView(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(observer, presenterFactory)
        {
            InitializeComponent();
        }

        public TitleView(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(observer, presenterFactory, presentationEntity)
        {
            InitializeComponent();
        }

        #endregion Constructors
    }
}