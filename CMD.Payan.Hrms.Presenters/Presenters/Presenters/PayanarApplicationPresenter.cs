using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class PayanarApplicationPresenter : Presenter
    {
        #region Constructors

        public PayanarApplicationPresenter(IView view)
            : base(view, PayanarApplicationPresentationEntityFactory.Factory)
        {
        }

        public PayanarApplicationPresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public IPayanarApplicationView PayanarApplicationViewDetail
        {
            get { return ViewDetail as IPayanarApplicationView; }
        }

        public PayanarApplicationPresentationEntity PayanarApplicationPresentationEntityDetail
        {
            get { return PresentationEntityDetail as PayanarApplicationPresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
