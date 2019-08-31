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
    public class InterviewFormDetailsPresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public InterviewFormDetailsPresentationEntity(IPresenter presenter)
            : base(presenter, InterviewFormDetailsFactory.Factory)
        {
        }

        public InterviewFormDetailsPresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public InterviewFormDetailsPresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public InterviewFormDetailsPresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, InterviewFormDetailsFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties
	
        public System.String Des
        {
            get { return InterviewFormDetailsDetail.Des; }
            set { InterviewFormDetailsDetail.Des = value; }
        }

        public System.String Grade
        {
            get { return InterviewFormDetailsDetail.Grade; }
            set { InterviewFormDetailsDetail.Grade = value; }
        }

        public System.Decimal IntNo
        {
            get { return InterviewFormDetailsDetail.IntNo; }
            set { InterviewFormDetailsDetail.IntNo = value; }
        }

        public System.String Remarks
        {
            get { return InterviewFormDetailsDetail.Remarks; }
            set { InterviewFormDetailsDetail.Remarks = value; }
        }

        public System.Int64 Slno
        {
            get { return InterviewFormDetailsDetail.Slno; }
            set { InterviewFormDetailsDetail.Slno = value; }
        }

        public InterviewFormDetails InterviewFormDetailsDetail
        {
            get { return BusinessObjectDetail as InterviewFormDetails; }
        }

        private InterviewFormDetailsPresenter InterviewFormDetailsPresenterDetail
        {
            get { return PresenterDetail as InterviewFormDetailsPresenter; }
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
