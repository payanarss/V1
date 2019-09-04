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
    public class TableDetailPresentationEntityCollection : PresentationEntityCollection<TableDetailPresentationEntity>
    {
        public TableDetailPresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, TableDetailPresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public TableDetailPresentationEntityCollection(IPresenter presenter)
            : base(presenter, TableDetailPresentationEntityFactory.Factory, TableDetailCollectionFactory.Factory)
        {
        }

        public TableDetailPresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, TableDetailPresentationEntityFactory.Factory, TableDetailCollectionFactory.Factory, parent)
        {
        }

        public TableDetailPresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, TableDetailPresentationEntityFactory.Factory, TableDetailCollectionFactory.Factory, parent)
        {
        }
    }
}
