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
    public class InterviewFormDetails : BusinessObject, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public InterviewFormDetails()
            : base(InterviewFormDetailsEntityFactory.Factory, InterviewFormDetailsDatabaseAgentFactory.Factory)
        { }

 	public InterviewFormDetails(IParent parent)
            : base(InterviewFormDetailsEntityFactory.Factory, InterviewFormDetailsDatabaseAgentFactory.Factory, parent)
        { }

        #endregion Constructors

        #region Properties
	
        public System.String Des
        {
            get { return InterviewFormDetailsEntityDetail.Des; }
            set { InterviewFormDetailsEntityDetail.Des = value; }
        }

        public System.String Grade
        {
            get { return InterviewFormDetailsEntityDetail.Grade; }
            set { InterviewFormDetailsEntityDetail.Grade = value; }
        }

        public System.Decimal IntNo
        {
            get { return InterviewFormDetailsEntityDetail.IntNo; }
            set { InterviewFormDetailsEntityDetail.IntNo = value; }
        }

        public System.String Remarks
        {
            get { return InterviewFormDetailsEntityDetail.Remarks; }
            set { InterviewFormDetailsEntityDetail.Remarks = value; }
        }

        public System.Int64 Slno
        {
            get { return InterviewFormDetailsEntityDetail.Slno; }
            set { InterviewFormDetailsEntityDetail.Slno = value; }
        }

        private InterviewFormDetailsEntity InterviewFormDetailsEntityDetail
        {
            get { return BusinessEntityObject as InterviewFormDetailsEntity; }
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
