using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class ExitInterviewFactorPresenter : Presenter
    {
        #region Constructors

        public ExitInterviewFactorPresenter(IView view)
            : base(view, ExitInterviewFactorPresentationEntityFactory.Factory)
        {
        }

        public ExitInterviewFactorPresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public IExitInterviewFactorView ExitInterviewFactorViewDetail
        {
            get { return ViewDetail as IExitInterviewFactorView; }
        }

        public ExitInterviewFactorPresentationEntity ExitInterviewFactorPresentationEntityDetail
        {
            get { return PresentationEntityDetail as ExitInterviewFactorPresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
