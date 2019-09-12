using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class InterviewFactorPresenter : Presenter
    {
        #region Constructors

        public InterviewFactorPresenter(IView view)
            : base(view, InterviewFactorPresentationEntityFactory.Factory)
        {
        }

        public InterviewFactorPresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public IInterviewFactorView InterviewFactorViewDetail
        {
            get { return ViewDetail as IInterviewFactorView; }
        }

        public InterviewFactorPresentationEntity InterviewFactorPresentationEntityDetail
        {
            get { return PresentationEntityDetail as InterviewFactorPresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
