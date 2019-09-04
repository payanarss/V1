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
    public class EmployeeDetailPresentationEntityCollection : PresentationEntityCollection<EmployeeDetailPresentationEntity>
    {
        public EmployeeDetailPresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, EmployeeDetailPresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public EmployeeDetailPresentationEntityCollection(IPresenter presenter)
            : base(presenter, EmployeeDetailPresentationEntityFactory.Factory, EmployeeDetailCollectionFactory.Factory)
        {
        }

        public EmployeeDetailPresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, EmployeeDetailPresentationEntityFactory.Factory, EmployeeDetailCollectionFactory.Factory, parent)
        {
        }

        public EmployeeDetailPresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, EmployeeDetailPresentationEntityFactory.Factory, EmployeeDetailCollectionFactory.Factory, parent)
        {
        }
    }
}
