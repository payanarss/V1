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
    public class CompanyPresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public CompanyPresentationEntity(IPresenter presenter)
            : base(presenter, CompanyFactory.Factory)
        {
        }

        public CompanyPresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public CompanyPresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public CompanyPresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, CompanyFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties
	
        public System.String CompanyAddress1
        {
            get { return CompanyDetail.CompanyAddress1; }
            set { CompanyDetail.CompanyAddress1 = value; }
        }

        public System.String CompanyAddress2
        {
            get { return CompanyDetail.CompanyAddress2; }
            set { CompanyDetail.CompanyAddress2 = value; }
        }

        public System.String CompanyAddress3
        {
            get { return CompanyDetail.CompanyAddress3; }
            set { CompanyDetail.CompanyAddress3 = value; }
        }

        public System.String CompanyAddress4
        {
            get { return CompanyDetail.CompanyAddress4; }
            set { CompanyDetail.CompanyAddress4 = value; }
        }

        public System.String CompanyName
        {
            get { return CompanyDetail.CompanyName; }
            set { CompanyDetail.CompanyName = value; }
        }

        public System.String CompanyName1
        {
            get { return CompanyDetail.CompanyName1; }
            set { CompanyDetail.CompanyName1 = value; }
        }

        public System.String CompanyCode
        {
            get { return CompanyDetail.CompanyCode; }
            set { CompanyDetail.CompanyCode = value; }
        }

        public CMD.Payan.Hrms.BusinessLayers.Company CompanyDetail
        {
            get { return BusinessObjectDetail as CMD.Payan.Hrms.BusinessLayers.Company; }
        }

        private CompanyPresenter CompanyPresenterDetail
        {
            get { return PresenterDetail as CompanyPresenter; }
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
