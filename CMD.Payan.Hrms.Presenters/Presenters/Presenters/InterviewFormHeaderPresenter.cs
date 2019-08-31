using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class InterviewFormHeaderPresenter : Presenter
    {
        #region Constructors

        public InterviewFormHeaderPresenter(IView view)
            : base(view, InterviewFormHeaderPresentationEntityFactory.Factory)
        {
        }

        public InterviewFormHeaderPresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public IInterviewFormHeaderView InterviewFormHeaderViewDetail
        {
            get { return ViewDetail as IInterviewFormHeaderView; }
        }

        public InterviewFormHeaderPresentationEntity InterviewFormHeaderPresentationEntityDetail
        {
            get { return PresentationEntityDetail as InterviewFormHeaderPresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
