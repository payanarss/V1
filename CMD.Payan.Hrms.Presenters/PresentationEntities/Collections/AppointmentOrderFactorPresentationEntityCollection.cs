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
    public class AppointmentOrderFactorPresentationEntityCollection : PresentationEntityCollection<AppointmentOrderFactorPresentationEntity>
    {
        public AppointmentOrderFactorPresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, AppointmentOrderFactorPresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public AppointmentOrderFactorPresentationEntityCollection(IPresenter presenter)
            : base(presenter, AppointmentOrderFactorPresentationEntityFactory.Factory, AppointmentOrderFactorCollectionFactory.Factory)
        {
        }

        public AppointmentOrderFactorPresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, AppointmentOrderFactorPresentationEntityFactory.Factory, AppointmentOrderFactorCollectionFactory.Factory, parent)
        {
        }

        public AppointmentOrderFactorPresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, AppointmentOrderFactorPresentationEntityFactory.Factory, AppointmentOrderFactorCollectionFactory.Factory, parent)
        {
        }
    }
}
