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
    public class TableSequanceNumberPresentationEntityCollectionFactory : PresentationEntityCollectionFactory
    {
        private static IPresentationEntityCollectionFactory _factory;

        public static IPresentationEntityCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new TableSequanceNumberPresentationEntityCollectionFactory();
                }

                return _factory;
            }
        }

        protected override IPresentationEntityCollection Create(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
        {
            return new TableSequanceNumberPresentationEntityCollection(presenter, businessObjectCollection);
        }

        protected override IPresentationEntityCollection Create(IPresenter presenter)
        {
            return new TableSequanceNumberPresentationEntityCollection(presenter);
        }

        protected override IPresentationEntityCollection Create(IPresenter presenter, IParent parent)
        {
            return new TableSequanceNumberPresentationEntityCollection(presenter, parent);
        }

        protected override IPresentationEntityCollection Create(IObserver observer, IPresenter presenter, IParent parent)
        {
            return new TableSequanceNumberPresentationEntityCollection(observer, presenter, parent);
        }
    }
}
