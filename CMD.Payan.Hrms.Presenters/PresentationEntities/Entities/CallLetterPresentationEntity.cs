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
	
        public System.DateTime CallDate
        {
            get { return CallLetterDetail.CallDate; }
            set { CallLetterDetail.CallDate = value; }
        }

        public System.Int64 CallNo
        {
            get { return CallLetterDetail.CallNo; }
            set { CallLetterDetail.CallNo = value; }
        }

        public System.String CandAdd
        {
            get { return CallLetterDetail.CandAdd; }
            set { CallLetterDetail.CandAdd = value; }
        }

        public System.String CandTo
        {
            get { return CallLetterDetail.CandTo; }
            set { CallLetterDetail.CandTo = value; }
        }

        public System.String CompCode
        {
            get { return CallLetterDetail.CompCode; }
            set { CallLetterDetail.CompCode = value; }
        }

        public System.String ContNo
        {
            get { return CallLetterDetail.ContNo; }
            set { CallLetterDetail.ContNo = value; }
        }

        public System.String IntDate
        {
            get { return CallLetterDetail.IntDate; }
            set { CallLetterDetail.IntDate = value; }
        }

        public System.String IntTime
        {
            get { return CallLetterDetail.IntTime; }
            set { CallLetterDetail.IntTime = value; }
        }

        public System.String Pos
        {
            get { return CallLetterDetail.Pos; }
            set { CallLetterDetail.Pos = value; }
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
