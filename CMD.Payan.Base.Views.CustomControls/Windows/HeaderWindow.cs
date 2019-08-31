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
    public partial class HeaderWindow : Payanar.SS.Net.Libraries.Views.CustomControls.HeaderWindow, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView, CMD.Payan.Base.Common.IObserver, CMD.Payan.Base.Common.INoticeable
    {
        #region Constructors

        public HeaderWindow()
            : base()
        {
            InitializeComponent();
        }

        public HeaderWindow(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(presenterFactory)
        {
        }

        public HeaderWindow(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(presenterFactory, parent)
        {
        }

        public HeaderWindow(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(presenterFactory, presentationEntity)
        {
        }

        public HeaderWindow(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity, IParent parent)
            : base(presenterFactory, presentationEntity, parent)
        {
        }

        public HeaderWindow(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView view, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(view, presenterFactory, presentationEntity)
        {
        }

        public HeaderWindow(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(observer, presenterFactory)
        {
        }

        public HeaderWindow(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, IParent parent)
            : base(observer, presenterFactory, parent)
        {
        }

        public HeaderWindow(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(observer, presenterFactory, presentationEntity)
        {
        }

        public HeaderWindow(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity, IParent parent)
            : base(observer, presenterFactory, presentationEntity, parent)
        {
        }

        #endregion
    }
}