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
    public class EmployeeDetailPresentationEntityCollectionFactory : PresentationEntityCollectionFactory
    {
        private static IPresentationEntityCollectionFactory _factory;

        public static IPresentationEntityCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new EmployeeDetailPresentationEntityCollectionFactory();
                }

                return _factory;
            }
        }

        protected override IPresentationEntityCollection Create(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
        {
            return new EmployeeDetailPresentationEntityCollection(presenter, businessObjectCollection);
        }

        protected override IPresentationEntityCollection Create(IPresenter presenter)
        {
            return new EmployeeDetailPresentationEntityCollection(presenter);
        }

        protected override IPresentationEntityCollection Create(IPresenter presenter, IParent parent)
        {
            return new EmployeeDetailPresentationEntityCollection(presenter, parent);
        }

        protected override IPresentationEntityCollection Create(IObserver observer, IPresenter presenter, IParent parent)
        {
            return new EmployeeDetailPresentationEntityCollection(observer, presenter, parent);
        }
    }
}
