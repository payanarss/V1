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
    public class AccessDetailsPresentationEntityCollection : PresentationEntityCollection<AccessDetailsPresentationEntity>
    {
        public AccessDetailsPresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, AccessDetailsPresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public AccessDetailsPresentationEntityCollection(IPresenter presenter)
            : base(presenter, AccessDetailsPresentationEntityFactory.Factory, AccessDetailsCollectionFactory.Factory)
        {
        }

        public AccessDetailsPresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, AccessDetailsPresentationEntityFactory.Factory, AccessDetailsCollectionFactory.Factory, parent)
        {
        }

        public AccessDetailsPresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, AccessDetailsPresentationEntityFactory.Factory, AccessDetailsCollectionFactory.Factory, parent)
        {
        }
    }
}
