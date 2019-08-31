using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class CallLetterPresenter : Presenter
    {
        #region Constructors

        public CallLetterPresenter(IView view)
            : base(view, CallLetterPresentationEntityFactory.Factory)
        {
        }

        public CallLetterPresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public ICallLetterView CallLetterViewDetail
        {
            get { return ViewDetail as ICallLetterView; }
        }

        public CallLetterPresentationEntity CallLetterPresentationEntityDetail
        {
            get { return PresentationEntityDetail as CallLetterPresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
