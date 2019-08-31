using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class InterviewGradePresenter : Presenter
    {
        #region Constructors

        public InterviewGradePresenter(IView view)
            : base(view, InterviewGradePresentationEntityFactory.Factory)
        {
        }

        public InterviewGradePresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public IInterviewGradeView InterviewGradeViewDetail
        {
            get { return ViewDetail as IInterviewGradeView; }
        }

        public InterviewGradePresentationEntity InterviewGradePresentationEntityDetail
        {
            get { return PresentationEntityDetail as InterviewGradePresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
