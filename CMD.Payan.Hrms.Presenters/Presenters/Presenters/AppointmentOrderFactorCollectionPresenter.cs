using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class AppointmentOrderFactorCollectionPresenter : Presenter
    {
        #region Constructors

        public AppointmentOrderFactorCollectionPresenter(IView view)
            : base(view, AppointmentOrderFactorPresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public IAppointmentOrderFactorView AppointmentOrderFactorViewDetail
        {
            get { return ViewDetail as IAppointmentOrderFactorView; }
        }

        public AppointmentOrderFactorPresentationEntityCollection AppointmentOrderFactorPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as AppointmentOrderFactorPresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
