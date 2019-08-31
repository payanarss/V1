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
    public class InterviewFormHeader : BusinessObject, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public InterviewFormHeader()
            : base(InterviewFormHeaderEntityFactory.Factory, InterviewFormHeaderDatabaseAgentFactory.Factory)
        { }

        public InterviewFormHeader(IParent parent)
            : base(InterviewFormHeaderEntityFactory.Factory, InterviewFormHeaderDatabaseAgentFactory.Factory, parent)
        { }

        #endregion Constructors

        #region Properties

        public System.DateTime CallDate
        {
            get { return InterviewFormHeaderEntityDetail.CallDate; }
            set { InterviewFormHeaderEntityDetail.CallDate = value; }
        }

        public System.Decimal CallNo
        {
            get { return InterviewFormHeaderEntityDetail.CallNo; }
            set { InterviewFormHeaderEntityDetail.CallNo = value; }
        }

        public System.String CandAdd
        {
            get { return InterviewFormHeaderEntityDetail.CandAdd; }
            set { InterviewFormHeaderEntityDetail.CandAdd = value; }
        }

        public System.String CandName
        {
            get { return InterviewFormHeaderEntityDetail.CandName; }
            set { InterviewFormHeaderEntityDetail.CandName = value; }
        }

        public System.String EmpName
        {
            get { return InterviewFormHeaderEntityDetail.EmpName; }
            set { InterviewFormHeaderEntityDetail.EmpName = value; }
        }

        public System.DateTime IntDate
        {
            get { return InterviewFormHeaderEntityDetail.IntDate; }
            set { InterviewFormHeaderEntityDetail.IntDate = value; }
        }

        public System.Int64 IntNo
        {
            get { return InterviewFormHeaderEntityDetail.IntNo; }
            set { InterviewFormHeaderEntityDetail.IntNo = value; }
        }

        public System.String Post
        {
            get { return InterviewFormHeaderEntityDetail.Post; }
            set { InterviewFormHeaderEntityDetail.Post = value; }
        }

        public System.String Recom
        {
            get { return InterviewFormHeaderEntityDetail.Recom; }
            set { InterviewFormHeaderEntityDetail.Recom = value; }
        }

        public System.Int64 Selected
        {
            get { return InterviewFormHeaderEntityDetail.Selected; }
            set { InterviewFormHeaderEntityDetail.Selected = value; }
        }

        public System.String ToBePost
        {
            get { return InterviewFormHeaderEntityDetail.ToBePost; }
            set { InterviewFormHeaderEntityDetail.ToBePost = value; }
        }

        public InterviewFormDetailsCollection InterviewDtCollectionInstance
        {
            get;
            set;
        }

        private InterviewFormHeaderEntity InterviewFormHeaderEntityDetail
        {
            get { return BusinessEntityObject as InterviewFormHeaderEntity; }
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
