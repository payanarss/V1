using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class InterviewFormDetailsPresenter : Presenter
    {
        #region Constructors

        public InterviewFormDetailsPresenter(IView view)
            : base(view, InterviewFormDetailsPresentationEntityFactory.Factory)
        {
        }

        public InterviewFormDetailsPresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public IInterviewFormDetailsView InterviewFormDetailsViewDetail
        {
            get { return ViewDetail as IInterviewFormDetailsView; }
        }

        public InterviewFormDetailsPresentationEntity InterviewFormDetailsPresentationEntityDetail
        {
            get { return PresentationEntityDetail as InterviewFormDetailsPresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
