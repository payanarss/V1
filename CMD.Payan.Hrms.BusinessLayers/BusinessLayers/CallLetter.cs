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
        {
            InitializeProtected();
        }

        public CallLetter(IParent parent)
            : base(CallLetterEntityFactory.Factory, CallLetterDatabaseAgentFactory.Factory, parent)
        {
            InitializeProtected();
        }

        #endregion Constructors

        #region Properties

        private Company _companyInstance = null;
        public Company CompanyInstance
        {
            get
            {
                if (_companyInstance == null)
                    _companyInstance = CMD.Payan.Hrms.BusinessLayers.CompanyFactory.Factory.Instance() as Company;

                return _companyInstance;
            }
        }

        private Employee _employeeInstance = null;
        public Employee EmployeeInstance
        {
            get
            {
                if (_employeeInstance == null)
                    _employeeInstance = EmployeeCollectionFactry.Instance.SingletonInstance.GetEmployeeBy(Regards);

                return _employeeInstance;
            }
            set
            {
                _employeeInstance = value;
                Regards = _employeeInstance.Name;
            }
        }

        public System.DateTime CallLetterDate
        {
            get { return CallLetterEntityDetail.CallLetterDate; }
            set { CallLetterEntityDetail.CallLetterDate = value; }
        }

        public System.Int64 CallLetterNumber
        {
            get { return CallLetterEntityDetail.CallLetterNumber; }
            set { CallLetterEntityDetail.CallLetterNumber = value; }
        }

        public System.String CandidateAddress
        {
            get { return CallLetterEntityDetail.CandidateAddress; }
            set { CallLetterEntityDetail.CandidateAddress = value; }
        }

        public System.String CandidateName
        {
            get { return CallLetterEntityDetail.CandidateName; }
            set { CallLetterEntityDetail.CandidateName = value; }
        }

        public System.String CompanyCode
        {
            get { return CallLetterEntityDetail.CompanyCode; }
            set { CallLetterEntityDetail.CompanyCode = value; }
        }

        public System.String CompanyName
        {
            get { return CompanyInstance.CompanyName; }
            set { CompanyInstance.CompanyName = value; }
        }

        public System.String ContactNumber
        {
            get { return CallLetterEntityDetail.ContactNumber; }
            set { CallLetterEntityDetail.ContactNumber = value; }
        }

        public System.DateTime InterviewDate
        {
            get { return CallLetterEntityDetail.InterviewDate; }
            set { CallLetterEntityDetail.InterviewDate = value; }
        }

        public System.String InterviewTime
        {
            get { return CallLetterEntityDetail.InterviewTime; }
            set { CallLetterEntityDetail.InterviewTime = value; }
        }

        public System.String Position
        {
            get { return CallLetterEntityDetail.Position; }
            set { CallLetterEntityDetail.Position = value; }
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

        protected void InitializeProtected()
        {
            CompanyCode = CompanyInstance.CompanyCode;
        }

        #endregion Protected

        #endregion Methods
    }
}
