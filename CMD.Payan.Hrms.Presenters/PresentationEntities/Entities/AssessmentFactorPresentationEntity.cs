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
    public class AssessmentFactorPresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public AssessmentFactorPresentationEntity(IPresenter presenter)
            : base(presenter, AssessmentFactorFactory.Factory)
        {
        }

        public AssessmentFactorPresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public AssessmentFactorPresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public AssessmentFactorPresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, AssessmentFactorFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties
	$PropertiesDeclarationCode$
        public AssessmentFactor AssessmentFactorDetail
        {
            get { return BusinessObjectDetail as AssessmentFactor; }
        }

        private AssessmentFactorPresenter AssessmentFactorPresenterDetail
        {
            get { return PresenterDetail as AssessmentFactorPresenter; }
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
