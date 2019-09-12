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
    public class InterviewFactorPresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public InterviewFactorPresentationEntity(IPresenter presenter)
            : base(presenter, InterviewFactorFactory.Factory)
        {
        }

        public InterviewFactorPresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public InterviewFactorPresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public InterviewFactorPresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, InterviewFactorFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties
	$PropertiesDeclarationCode$
        public InterviewFactor InterviewFactorDetail
        {
            get { return BusinessObjectDetail as InterviewFactor; }
        }

        private InterviewFactorPresenter InterviewFactorPresenterDetail
        {
            get { return PresenterDetail as InterviewFactorPresenter; }
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
