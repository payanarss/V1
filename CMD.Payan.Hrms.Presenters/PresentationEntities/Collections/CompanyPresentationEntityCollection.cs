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
    public class CompanyPresentationEntityCollection : PresentationEntityCollection<CompanyPresentationEntity>
    {
        public CompanyPresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, CompanyPresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public CompanyPresentationEntityCollection(IPresenter presenter)
            : base(presenter, CompanyPresentationEntityFactory.Factory, CompanyCollectionFactory.Factory)
        {
        }

        public CompanyPresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, CompanyPresentationEntityFactory.Factory, CompanyCollectionFactory.Factory, parent)
        {
        }

        public CompanyPresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, CompanyPresentationEntityFactory.Factory, CompanyCollectionFactory.Factory, parent)
        {
        }
    }
}
