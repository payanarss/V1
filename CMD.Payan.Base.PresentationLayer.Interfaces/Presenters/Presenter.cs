using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.PresentationLayer.Interfaces;
using CMD.Payan.Base.BusinessLayer.Interfaces;
using CMD.Payan.Base.Common;

namespace CMD.Payan.Base.PresentationLayer.Interfaces
{
    public class Presenter : Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.Presenter
    {
        #region Constructors

        public Presenter(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView view, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityFactory presentationEntityFactory) :
            base(view, presentationEntityFactory)
        {
        }

        public Presenter(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView view, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityCollectionFactory presentationEntityCollectionFactory)
            : base(view, presentationEntityCollectionFactory)
        {
        }

        public Presenter(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView view, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityCollectionFactory presentationEntityCollectionFactory)
            : base(observer, view, presentationEntityCollectionFactory)
        {
        }

        public Presenter(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView view, IPresentationEntityCollectionFactory presentationEntityCollectionFactory, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(view, presentationEntityCollectionFactory, parent)
        {
        }

        public Presenter(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView view, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityCollectionFactory presentationEntityCollectionFactory, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(observer, view, presentationEntityCollectionFactory, parent)
        {
        }

        public Presenter(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView view, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityFactory presentationEntityFactory, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(view, presentationEntityFactory, parent)
        {
        }

        public Presenter(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView view, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        public Presenter(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView view, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(view, presentationEntity, parent)
        {
        }

        public Presenter(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView view, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(observer, view, presentationEntity)
        {
        }

        public Presenter(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView view, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(observer, view, presentationEntity, parent)
        {
        }

        public Presenter(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView view, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityFactory presentationEntityFactory)
            : base(observer, view, presentationEntityFactory)
        {
        }

        public Presenter(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IView view, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityFactory presentationEntityFactory, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(observer, view, presentationEntityFactory, parent)
        {
        }

        #endregion Constructors
    }
}