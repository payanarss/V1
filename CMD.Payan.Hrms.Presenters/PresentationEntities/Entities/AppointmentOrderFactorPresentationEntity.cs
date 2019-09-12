using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;
using CMD.Payan.Hrms.BusinessLayers;

namespace CMD.Payan.Hrms.Presenters
{
    public class AppointmentOrderFactorPresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public AppointmentOrderFactorPresentationEntity(IPresenter presenter)
            : base(presenter, AppointmentOrderFactorFactory.Factory)
        {
        }

        public AppointmentOrderFactorPresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public AppointmentOrderFactorPresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public AppointmentOrderFactorPresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, AppointmentOrderFactorFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties
	$PropertiesDeclarationCode$
        public AppointmentOrderFactor AppointmentOrderFactorDetail
        {
            get { return BusinessObjectDetail as AppointmentOrderFactor; }
        }

        private AppointmentOrderFactorPresenter AppointmentOrderFactorPresenterDetail
        {
            get { return PresenterDetail as AppointmentOrderFactorPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void OnViewReady()
        {
            base.OnViewReady();
        }

        #endregion Methods
    }
}
