using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class AssessmentFactorPresenter : Presenter
    {
        #region Constructors

        public AssessmentFactorPresenter(IView view)
            : base(view, AssessmentFactorPresentationEntityFactory.Factory)
        {
        }

        public AssessmentFactorPresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public IAssessmentFactorView AssessmentFactorViewDetail
        {
            get { return ViewDetail as IAssessmentFactorView; }
        }

        public AssessmentFactorPresentationEntity AssessmentFactorPresentationEntityDetail
        {
            get { return PresentationEntityDetail as AssessmentFactorPresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
