using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class AssessmentFactorCollectionPresenter : Presenter
    {
        #region Constructors

        public AssessmentFactorCollectionPresenter(IView view)
            : base(view, AssessmentFactorPresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public IAssessmentFactorView AssessmentFactorViewDetail
        {
            get { return ViewDetail as IAssessmentFactorView; }
        }

        public AssessmentFactorPresentationEntityCollection AssessmentFactorPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as AssessmentFactorPresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
