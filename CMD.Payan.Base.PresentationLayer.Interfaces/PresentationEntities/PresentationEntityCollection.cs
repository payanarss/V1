using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.BusinessLayer.Interfaces;
using System.Collections.ObjectModel;
using CMD.Payan.Base.Common;
using System.Collections;

namespace CMD.Payan.Base.PresentationLayer.Interfaces
{
    public class PresentationEntityCollection<T> : Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.PresentationEntityCollection<T> where T : Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity
    {
        #region Constructors

        public PresentationEntityCollection(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityFactory presentationEntityFactory, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectCollectionFactory businessObjectCollectionFactory) :
            base(presenter, presentationEntityFactory, businessObjectCollectionFactory)
        {
        }

        public PresentationEntityCollection(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityFactory presentationEntityFactory, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectCollectionFactory businessObjectCollectionFactory, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(presenter, presentationEntityFactory, businessObjectCollectionFactory, parent)
        {
        }

        public PresentationEntityCollection(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityFactory presentationEntityFactory, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectCollectionFactory businessObjectCollectionFactory, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(observer, presenter, presentationEntityFactory, businessObjectCollectionFactory, parent)
        {
        }

        public PresentationEntityCollection(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityFactory presentationEntityFactory, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectCollection businessObjectCollection) :
            base(presenter, presentationEntityFactory, businessObjectCollection)
        {
        }

        public PresentationEntityCollection(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityFactory presentationEntityFactory, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectCollection businessObjectCollection, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(presenter, presentationEntityFactory, businessObjectCollection, parent)
        {
        }

        public PresentationEntityCollection(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityFactory presentationEntityFactory, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectCollection businessObjectCollection)
            : base(observer, presenter, presentationEntityFactory, businessObjectCollection)
        {
        }

        public PresentationEntityCollection(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityFactory presentationEntityFactory, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectCollection businessObjectCollection, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(observer, presenter, presentationEntityFactory, businessObjectCollection, parent)
        {
        }

        #endregion Constructors
    }
}