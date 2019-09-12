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
    public class PayanarApplicationPresentationEntityCollection : PresentationEntityCollection<PayanarApplicationPresentationEntity>
    {
        public PayanarApplicationPresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, PayanarApplicationPresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public PayanarApplicationPresentationEntityCollection(IPresenter presenter)
            : base(presenter, PayanarApplicationPresentationEntityFactory.Factory, PayanarApplicationCollectionFactory.Factory)
        {
        }

        public PayanarApplicationPresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, PayanarApplicationPresentationEntityFactory.Factory, PayanarApplicationCollectionFactory.Factory, parent)
        {
        }

        public PayanarApplicationPresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, PayanarApplicationPresentationEntityFactory.Factory, PayanarApplicationCollectionFactory.Factory, parent)
        {
        }
    }
}
