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

        public CallLetterPresentationEntity()
        {
        }

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
	
        public System.DateTime CallLetterDate
        {
            get { return CallLetterDetail.CallLetterDate; }
            set { CallLetterDetail.CallLetterDate = value; }
        }

        public System.Int64 CallLetterNumber
        {
            get {  return CallLetterDetail.CallLetterNumber; }
            set { CallLetterDetail.CallLetterNumber = value; }
        }

        public System.String CandidateAddress
        {
            get { return CallLetterDetail.CandidateAddress; }
            set { CallLetterDetail.CandidateAddress = value; }
        }

        public System.String CandidateName
        {
            get { return CallLetterDetail.CandidateName; }
            set { CallLetterDetail.CandidateName = value; }
        }

        public System.String CompanyCode
        {
            get { return CallLetterDetail.CompanyCode; }
            set { CallLetterDetail.CompanyCode = value; }
        }

        public System.String CompanyName
        {
            get { return CallLetterDetail.CompanyCode; }
            set { CallLetterDetail.CompanyName = value; }
        }

        public System.String ContactNumber
        {
            get { return CallLetterDetail.ContactNumber; }
            set { CallLetterDetail.ContactNumber = value; }
        }

        public System.DateTime InterviewDate
        {
            get { return CallLetterDetail.InterviewDate; }
            set { CallLetterDetail.InterviewDate = value; }
        }

        public System.String InterviewTime
        {
            get { return CallLetterDetail.InterviewTime; }
            set { CallLetterDetail.InterviewTime = value; }
        }

        public System.String Position
        {
            get { return CallLetterDetail.Position; }
            set { CallLetterDetail.Position = value; }
        }

        public System.String Regards
        {
            get { return CallLetterDetail.Regards; }
            set { CallLetterDetail.Regards = value; }
        }

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
