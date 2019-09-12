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
    public class CallLetterPresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public CallLetterPresentationEntity(IPresenter presenter)
            : base(presenter, CallLetterFactory.Factory)
        {
        }

        public CallLetterPresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public CallLetterPresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public CallLetterPresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, CallLetterFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties
	$PropertiesDeclarationCode$
        public CallLetter CallLetterDetail
        {
            get { return BusinessObjectDetail as CallLetter; }
        }

        private CallLetterPresenter CallLetterPresenterDetail
        {
            get { return PresenterDetail as CallLetterPresenter; }
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
