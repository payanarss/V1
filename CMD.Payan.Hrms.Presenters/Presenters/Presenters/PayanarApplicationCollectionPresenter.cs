using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class PayanarApplicationCollectionPresenter : Presenter
    {
        #region Constructors

        public PayanarApplicationCollectionPresenter(IView view)
            : base(view, PayanarApplicationPresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public IPayanarApplicationView PayanarApplicationViewDetail
        {
            get { return ViewDetail as IPayanarApplicationView; }
        }

        public PayanarApplicationPresentationEntityCollection PayanarApplicationPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as PayanarApplicationPresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
