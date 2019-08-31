using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class InterviewGradeCollectionPresenter : Presenter
    {
        #region Constructors

        public InterviewGradeCollectionPresenter(IView view)
            : base(view, InterviewGradePresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public IInterviewGradeView InterviewGradeViewDetail
        {
            get { return ViewDetail as IInterviewGradeView; }
        }

        public InterviewGradePresentationEntityCollection InterviewGradePresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as InterviewGradePresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
