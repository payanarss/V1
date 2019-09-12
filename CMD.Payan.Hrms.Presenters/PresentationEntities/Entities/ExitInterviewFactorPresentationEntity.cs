using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;
using CMD.Payan.Hrms.BusinessLayers;

namespace CMD.Payan.Hrms.Presenters
{
    public class ExitInterviewFactorPresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public ExitInterviewFactorPresentationEntity(IPresenter presenter)
            : base(presenter, ExitInterviewFactorFactory.Factory)
        {
        }

        public ExitInterviewFactorPresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public ExitInterviewFactorPresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public ExitInterviewFactorPresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, ExitInterviewFactorFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties
	$PropertiesDeclarationCode$
        public ExitInterviewFactor ExitInterviewFactorDetail
        {
            get { return BusinessObjectDetail as ExitInterviewFactor; }
        }

        private ExitInterviewFactorPresenter ExitInterviewFactorPresenterDetail
        {
            get { return PresenterDetail as ExitInterviewFactorPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void OnViewReady()
        {
            base.OnViewReady();
        }

        #endregion Methods
    }
}
