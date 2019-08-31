using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.Common;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using CMD.Payan.Hrms.BusinessLayers;

namespace CMD.Payan.Hrms.Presenters
{
    public class CallLetterPresentationEntityCollection : PresentationEntityCollection<CallLetterPresentationEntity>
    {
        public CallLetterPresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, CallLetterPresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public CallLetterPresentationEntityCollection(IPresenter presenter)
            : base(presenter, CallLetterPresentationEntityFactory.Factory, CallLetterCollectionFactory.Factory)
        {
        }

        public CallLetterPresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, CallLetterPresentationEntityFactory.Factory, CallLetterCollectionFactory.Factory, parent)
        {
        }

        public CallLetterPresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, CallLetterPresentationEntityFactory.Factory, CallLetterCollectionFactory.Factory, parent)
        {
        }
    }
}
