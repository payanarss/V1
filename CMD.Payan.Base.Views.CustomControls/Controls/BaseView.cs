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
using System.Collections;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Base.Views.CustomControls
{
    public partial class BaseView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, CMD.Payan.Base.PresentationLayer.Interfaces.IView, CMD.Payan.Base.Common.IObserver, CMD.Payan.Base.Common.INoticeable
    {
        #region Constructors

        public BaseView()
            : base()
        {
        }

        public BaseView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IViewContext viewContext)
            : base(viewContext)
        {
        }

        public BaseView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IViewContext viewContext, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(viewContext, presenterFactory)
        {
        }

        public BaseView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(presenterFactory)
        {
        }

        public BaseView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(presenterFactory, presentationEntity)
        {
        }

        public BaseView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IViewContext viewContext, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(viewContext, presenterFactory, presentationEntity)
        {
        }

        public BaseView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IViewContext viewContext, CMD.Payan.Base.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(viewContext, observer, presenterFactory)
        {
        }

        public BaseView(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(observer, presenterFactory)
        {
        }

        public BaseView(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(observer, presenterFactory, presentationEntity)
        {
        }

        public BaseView(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, IParent parent)
            : base(presenterFactory, parent)
        {
        }

        public BaseView(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, IParent parent)
            : base(observer, presenterFactory, parent)
        {
        }

        #endregion Constructors
    }
}