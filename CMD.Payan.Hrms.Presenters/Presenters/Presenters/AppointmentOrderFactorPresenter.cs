using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class AppointmentOrderFactorPresenter : Presenter
    {
        #region Constructors

        public AppointmentOrderFactorPresenter(IView view)
            : base(view, AppointmentOrderFactorPresentationEntityFactory.Factory)
        {
        }

        public AppointmentOrderFactorPresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public IAppointmentOrderFactorView AppointmentOrderFactorViewDetail
        {
            get { return ViewDetail as IAppointmentOrderFactorView; }
        }

        public AppointmentOrderFactorPresentationEntity AppointmentOrderFactorPresentationEntityDetail
        {
            get { return PresentationEntityDetail as AppointmentOrderFactorPresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
