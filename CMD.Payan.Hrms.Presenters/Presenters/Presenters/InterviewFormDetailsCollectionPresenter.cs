using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class InterviewFormDetailsCollectionPresenter : Presenter
    {
        #region Constructors

        public InterviewFormDetailsCollectionPresenter(IView view)
            : base(view, InterviewFormDetailsPresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public IInterviewFormDetailsView InterviewFormDetailsViewDetail
        {
            get { return ViewDetail as IInterviewFormDetailsView; }
        }

        public InterviewFormDetailsPresentationEntityCollection InterviewFormDetailsPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as InterviewFormDetailsPresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
