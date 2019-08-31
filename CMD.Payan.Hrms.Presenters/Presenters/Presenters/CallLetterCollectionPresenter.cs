using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class CallLetterCollectionPresenter : Presenter
    {
        #region Constructors

        public CallLetterCollectionPresenter(IView view)
            : base(view, CallLetterPresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public ICallLetterView CallLetterViewDetail
        {
            get { return ViewDetail as ICallLetterView; }
        }

        public CallLetterPresentationEntityCollection CallLetterPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as CallLetterPresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
