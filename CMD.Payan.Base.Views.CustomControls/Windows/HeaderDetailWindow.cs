using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CMD.Payan.Base.Views.Controls;
using CMD.Payan.Base.PresentationLayer.Interfaces;
using CMD.Payan.Base.Common;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Base.Views.CustomControls
{
    public partial class HeaderDetailWindow : Payanar.SS.Net.Libraries.Views.CustomControls.HeaderDetailWindow
    {
        #region Constructors

        public HeaderDetailWindow()
            : base()
        {
            InitializeComponent();
        }

        public HeaderDetailWindow(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(presenterFactory)
        {
            InitializeComponent();
        }

        public HeaderDetailWindow(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, IParent parent)
            : base(presenterFactory, parent)
        {
            InitializeComponent();
        }

        public HeaderDetailWindow(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(presenterFactory, presentationEntity)
        {
            InitializeComponent();
        }

        public HeaderDetailWindow(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity, IParent parent)
            : base(presenterFactory, presentationEntity, parent)
        {
            InitializeComponent();
        }

        public HeaderDetailWindow(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView view, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(view, presenterFactory, presentationEntity)
        {
            InitializeComponent();
        }

        public HeaderDetailWindow(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(observer, presenterFactory)
        {
            InitializeComponent();
        }

        public HeaderDetailWindow(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, IParent parent)
            : base(observer, presenterFactory, parent)
        {
            InitializeComponent();
        }

        public HeaderDetailWindow(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(observer, presenterFactory, presentationEntity)
        {
            InitializeComponent();
        }

        public HeaderDetailWindow(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity, IParent parent)
            : base(observer, presenterFactory, presentationEntity, parent)
        {
            InitializeComponent();
        }

        #endregion
    }
}