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
    public class AccessDetails : BusinessObject, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public AccessDetails()
            : base(AccessDetailsEntityFactory.Factory, AccessDetailsDatabaseAgentFactory.Factory)
        { }

 	public AccessDetails(IParent parent)
            : base(AccessDetailsEntityFactory.Factory, AccessDetailsDatabaseAgentFactory.Factory, parent)
        { }

        #endregion Constructors

        #region Properties
	
        public System.String AccDate
        {
            get { return AccessDetailsEntityDetail.AccDate; }
            set { AccessDetailsEntityDetail.AccDate = value; }
        }

        public System.Decimal AccTime
        {
            get { return AccessDetailsEntityDetail.AccTime; }
            set { AccessDetailsEntityDetail.AccTime = value; }
        }

        public System.String DoorNo
        {
            get { return AccessDetailsEntityDetail.DoorNo; }
            set { AccessDetailsEntityDetail.DoorNo = value; }
        }

        public System.String EmpCode
        {
            get { return AccessDetailsEntityDetail.EmpCode; }
            set { AccessDetailsEntityDetail.EmpCode = value; }
        }

        public System.String EmpName
        {
            get { return AccessDetailsEntityDetail.EmpName; }
            set { AccessDetailsEntityDetail.EmpName = value; }
        }

        public System.String Empno
        {
            get { return AccessDetailsEntityDetail.Empno; }
            set { AccessDetailsEntityDetail.Empno = value; }
        }

        public System.String Flg
        {
            get { return AccessDetailsEntityDetail.Flg; }
            set { AccessDetailsEntityDetail.Flg = value; }
        }

        public System.Int64 RNo
        {
            get { return AccessDetailsEntityDetail.RNo; }
            set { AccessDetailsEntityDetail.RNo = value; }
        }

        public System.String Status
        {
            get { return AccessDetailsEntityDetail.Status; }
            set { AccessDetailsEntityDetail.Status = value; }
        }

        private AccessDetailsEntity AccessDetailsEntityDetail
        {
            get { return BusinessEntityObject as AccessDetailsEntity; }
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
