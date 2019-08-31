using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class InterviewFormHeaderCollectionPresenter : Presenter
    {
        #region Constructors

        public InterviewFormHeaderCollectionPresenter(IView view)
            : base(view, InterviewFormHeaderPresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public IInterviewFormHeaderView InterviewFormHeaderViewDetail
        {
            get { return ViewDetail as IInterviewFormHeaderView; }
        }

        public InterviewFormHeaderPresentationEntityCollection InterviewFormHeaderPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as InterviewFormHeaderPresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
