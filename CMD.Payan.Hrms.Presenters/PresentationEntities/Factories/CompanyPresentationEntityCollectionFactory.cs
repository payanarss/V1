using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;
using CMD.Payan.Hrms.BusinessLayers;

namespace CMD.Payan.Hrms.Presenters
{
    public class CompanyPresentationEntityCollectionFactory : PresentationEntityCollectionFactory
    {
        private static IPresentationEntityCollectionFactory _factory;

        public static IPresentationEntityCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new CompanyPresentationEntityCollectionFactory();
                }

                return _factory;
            }
        }

        protected override IPresentationEntityCollection Create(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
        {
            return new CompanyPresentationEntityCollection(presenter, businessObjectCollection);
        }

        protected override IPresentationEntityCollection Create(IPresenter presenter)
        {
            return new CompanyPresentationEntityCollection(presenter);
        }

        protected override IPresentationEntityCollection Create(IPresenter presenter, IParent parent)
        {
            return new CompanyPresentationEntityCollection(presenter, parent);
        }

        protected override IPresentationEntityCollection Create(IObserver observer, IPresenter presenter, IParent parent)
        {
            return new CompanyPresentationEntityCollection(observer, presenter, parent);
        }
    }
}
