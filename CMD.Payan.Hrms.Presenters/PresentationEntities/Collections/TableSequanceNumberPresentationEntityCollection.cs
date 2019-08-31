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
    public class TableSequanceNumberPresentationEntityCollection : PresentationEntityCollection<TableSequanceNumberPresentationEntity>
    {
        public TableSequanceNumberPresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, TableSequanceNumberPresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public TableSequanceNumberPresentationEntityCollection(IPresenter presenter)
            : base(presenter, TableSequanceNumberPresentationEntityFactory.Factory, TableSequanceNumberCollectionFactory.Factory)
        {
        }

        public TableSequanceNumberPresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, TableSequanceNumberPresentationEntityFactory.Factory, TableSequanceNumberCollectionFactory.Factory, parent)
        {
        }

        public TableSequanceNumberPresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, TableSequanceNumberPresentationEntityFactory.Factory, TableSequanceNumberCollectionFactory.Factory, parent)
        {
        }
    }
}
