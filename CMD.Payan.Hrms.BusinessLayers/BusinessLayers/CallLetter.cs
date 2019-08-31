using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.Common;
using CMD.Payan.Hrms.BusinessEntities;
using CMD.Payan.Hrms.DatabaseLayer;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class CallLetter : BusinessObject, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public CallLetter()
            : base(CallLetterEntityFactory.Factory, CallLetterDatabaseAgentFactory.Factory)
        { }

 	public CallLetter(IParent parent)
            : base(CallLetterEntityFactory.Factory, CallLetterDatabaseAgentFactory.Factory, parent)
        { }

        #endregion Constructors

        #region Properties
	
        public System.DateTime CallDate
        {
            get { return CallLetterEntityDetail.CallDate; }
            set { CallLetterEntityDetail.CallDate = value; }
        }

        public System.Int64 CallNo
        {
            get { return CallLetterEntityDetail.CallNo; }
            set { CallLetterEntityDetail.CallNo = value; }
        }

        public System.String CandAdd
        {
            get { return CallLetterEntityDetail.CandAdd; }
            set { CallLetterEntityDetail.CandAdd = value; }
        }

        public System.String CandTo
        {
            get { return CallLetterEntityDetail.CandTo; }
            set { CallLetterEntityDetail.CandTo = value; }
        }

        public System.String CompCode
        {
            get { return CallLetterEntityDetail.CompCode; }
            set { CallLetterEntityDetail.CompCode = value; }
        }

        public System.String ContNo
        {
            get { return CallLetterEntityDetail.ContNo; }
            set { CallLetterEntityDetail.ContNo = value; }
        }

        public System.String IntDate
        {
            get { return CallLetterEntityDetail.IntDate; }
            set { CallLetterEntityDetail.IntDate = value; }
        }

        public System.String IntTime
        {
            get { return CallLetterEntityDetail.IntTime; }
            set { CallLetterEntityDetail.IntTime = value; }
        }

        public System.String Pos
        {
            get { return CallLetterEntityDetail.Pos; }
            set { CallLetterEntityDetail.Pos = value; }
        }

        public System.String Regards
        {
            get { return CallLetterEntityDetail.Regards; }
            set { CallLetterEntityDetail.Regards = value; }
        }

        private CallLetterEntity CallLetterEntityDetail
        {
            get { return BusinessEntityObject as CallLetterEntity; }
        }

        #endregion Properties

        #region Methods

        #region Public

        public override int Load()
        {
            int result = 0;

            result += base.Load();

            return result;
        }

        #endregion Public

        #region Protected

        protected override bool ValidateBeforeSave()
        {
            bool isValid = base.ValidateBeforeSave();

            return isValid;
        }

        protected override bool ValidateBeforeDelete()
        {
            bool isValid = base.ValidateBeforeDelete();

            return isValid;
        }

        #endregion Protected

	#endregion Methods
    }
}
