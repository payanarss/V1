using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class InterviewFactorCollectionPresenter : Presenter
    {
        #region Constructors

        public InterviewFactorCollectionPresenter(IView view)
            : base(view, InterviewFactorPresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public IInterviewFactorView InterviewFactorViewDetail
        {
            get { return ViewDetail as IInterviewFactorView; }
        }

        public InterviewFactorPresentationEntityCollection InterviewFactorPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as InterviewFactorPresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
