using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class ExitInterviewFactorCollectionPresenter : Presenter
    {
        #region Constructors

        public ExitInterviewFactorCollectionPresenter(IView view)
            : base(view, ExitInterviewFactorPresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public IExitInterviewFactorView ExitInterviewFactorViewDetail
        {
            get { return ViewDetail as IExitInterviewFactorView; }
        }

        public ExitInterviewFactorPresentationEntityCollection ExitInterviewFactorPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as ExitInterviewFactorPresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
