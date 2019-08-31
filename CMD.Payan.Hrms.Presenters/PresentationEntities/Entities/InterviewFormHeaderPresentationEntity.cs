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
    public class InterviewFormHeaderPresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public InterviewFormHeaderPresentationEntity(IPresenter presenter)
            : base(presenter, InterviewFormHeaderFactory.Factory)
        {
        }

        public InterviewFormHeaderPresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public InterviewFormHeaderPresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public InterviewFormHeaderPresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, InterviewFormHeaderFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties
	
        public System.DateTime CallDate
        {
            get { return InterviewFormHeaderDetail.CallDate; }
            set { InterviewFormHeaderDetail.CallDate = value; }
        }

        public System.Decimal CallNo
        {
            get { return InterviewFormHeaderDetail.CallNo; }
            set { InterviewFormHeaderDetail.CallNo = value; }
        }

        public System.String CandAdd
        {
            get { return InterviewFormHeaderDetail.CandAdd; }
            set { InterviewFormHeaderDetail.CandAdd = value; }
        }

        public System.String CandName
        {
            get { return InterviewFormHeaderDetail.CandName; }
            set { InterviewFormHeaderDetail.CandName = value; }
        }

        public System.String EmpName
        {
            get { return InterviewFormHeaderDetail.EmpName; }
            set { InterviewFormHeaderDetail.EmpName = value; }
        }

        public System.DateTime IntDate
        {
            get { return InterviewFormHeaderDetail.IntDate; }
            set { InterviewFormHeaderDetail.IntDate = value; }
        }

        public System.Int64 IntNo
        {
            get { return InterviewFormHeaderDetail.IntNo; }
            set { InterviewFormHeaderDetail.IntNo = value; }
        }

        public System.String Post
        {
            get { return InterviewFormHeaderDetail.Post; }
            set { InterviewFormHeaderDetail.Post = value; }
        }

        public System.String Recom
        {
            get { return InterviewFormHeaderDetail.Recom; }
            set { InterviewFormHeaderDetail.Recom = value; }
        }

        public System.Int64 Selected
        {
            get { return InterviewFormHeaderDetail.Selected; }
            set { InterviewFormHeaderDetail.Selected = value; }
        }

        public System.String ToBePost
        {
            get { return InterviewFormHeaderDetail.ToBePost; }
            set { InterviewFormHeaderDetail.ToBePost = value; }
        }

        public InterviewFormDetailsCollection InterviewDtCollectionInstance
        {
            get { return InterviewFormHeaderDetail.InterviewDtCollectionInstance; }
            set { InterviewFormHeaderDetail.InterviewDtCollectionInstance = value; }
        }

        public InterviewFormHeader InterviewFormHeaderDetail
        {
            get { return BusinessObjectDetail as InterviewFormHeader; }
        }

        private InterviewFormHeaderPresenter InterviewFormHeaderPresenterDetail
        {
            get { return PresenterDetail as InterviewFormHeaderPresenter; }
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
