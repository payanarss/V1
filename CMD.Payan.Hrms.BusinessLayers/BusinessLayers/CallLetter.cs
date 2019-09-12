using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayanarCommon = Payanar.SS.Net.Libraries.Common;
using BaseBusinessLayer = CMD.Payan.Net.Base.BusinessLayer;
using BaseCommon = CMD.Payan.Net.Base.Common;
using CMD.Payan.Net.Hrms.BusinessEntities;
using CMD.Payan.Net.Hrms.DatabaseLayer;

namespace CMD.Payan.Net.Hrms.BusinessLayers
{
    public class CallLetter : BaseBusinessLayer.BusinessObject, BaseCommon.IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public CallLetter()
            : base(CallLetterEntityFactory.Factory, CallLetterDatabaseAgentFactory.Factory)
        { }

 	public CallLetter(PayanarCommon.IParent parent)
            : base(CallLetterEntityFactory.Factory, CallLetterDatabaseAgentFactory.Factory, parent)
        { }

        #endregion Constructors

        #region Properties

        public CallLetterEntity CallLetterEntityDetail
        {
            get { return BusinessEntityObject as CallLetterEntity; }
        }

	
        private TableInformationCollection _tableInformationCollectionDetail = null;
        public TableInformationCollection TableInformationCollectionDetail
        {
            get
            {
                if (_tableInformationCollectionDetail == null)
                {
                    _tableInformationCollectionDetail = TableInformationCollectionFactory.Factory.LoadedInstance() as TableInformationCollection;
                }

                return _tableInformationCollectionDetail;
            }
        }

        private TableInformation _tableInformationDetail = null;
        public TableInformation TableInformationDetail
        {
            get
            {
                if (_tableInformationDetail == null)
                {
                    _tableInformationDetail = TableInformationCollectionDetail.GetBusinessObjectDetailOrDefault(TableInformationID) as TableInformation;
                }

                return _tableInformationDetail;
            }
            set
            {
                if (_tableInformationDetail != value)
                {
                    _tableInformationDetail = value;
                    TableInformationID = _tableInformationDetail != null ? _tableInformationDetail.UniqueIdentifier : 0;
                }
            }
        }
        private CompanyHeaderCollection _companyHeaderCollectionDetail = null;
        public CompanyHeaderCollection CompanyHeaderCollectionDetail
        {
            get
            {
                if (_companyHeaderCollectionDetail == null)
                {
                    _companyHeaderCollectionDetail = CompanyHeaderCollectionFactory.Factory.LoadedInstance() as CompanyHeaderCollection;
                }

                return _companyHeaderCollectionDetail;
            }
        }

        private CompanyHeader _companyHeaderDetail = null;
        public CompanyHeader CompanyHeaderDetail
        {
            get
            {
                if (_companyHeaderDetail == null)
                {
                    _companyHeaderDetail = CompanyHeaderCollectionDetail.GetBusinessObjectDetailOrDefault(CompanyHeaderID) as CompanyHeader;
                }

                return _companyHeaderDetail;
            }
            set
            {
                if (_companyHeaderDetail != value)
                {
                    _companyHeaderDetail = value;
                    CompanyHeaderID = _companyHeaderDetail != null ? _companyHeaderDetail.UniqueIdentifier : 0;
                }
            }
        }
        private DesignationCollection _designationCollectionDetail = null;
        public DesignationCollection DesignationCollectionDetail
        {
            get
            {
                if (_designationCollectionDetail == null)
                {
                    _designationCollectionDetail = DesignationCollectionFactory.Factory.LoadedInstance() as DesignationCollection;
                }

                return _designationCollectionDetail;
            }
        }

        private Designation _designationDetail = null;
        public Designation DesignationDetail
        {
            get
            {
                if (_designationDetail == null)
                {
                    _designationDetail = DesignationCollectionDetail.GetBusinessObjectDetailOrDefault(DesignationID) as Designation;
                }

                return _designationDetail;
            }
            set
            {
                if (_designationDetail != value)
                {
                    _designationDetail = value;
                    DesignationID = _designationDetail != null ? _designationDetail.UniqueIdentifier : 0;
                }
            }
        }
        private EmployeeDetailCollection _employeeDetailCollectionDetail = null;
        public EmployeeDetailCollection EmployeeDetailCollectionDetail
        {
            get
            {
                if (_employeeDetailCollectionDetail == null)
                {
                    _employeeDetailCollectionDetail = EmployeeDetailCollectionFactory.Factory.LoadedInstance() as EmployeeDetailCollection;
                }

                return _employeeDetailCollectionDetail;
            }
        }

        private EmployeeDetail _employeeDetailDetail = null;
        public EmployeeDetail EmployeeDetailDetail
        {
            get
            {
                if (_employeeDetailDetail == null)
                {
                    _employeeDetailDetail = EmployeeDetailCollectionDetail.GetBusinessObjectDetailOrDefault(EmployeeDetailID) as EmployeeDetail;
                }

                return _employeeDetailDetail;
            }
            set
            {
                if (_employeeDetailDetail != value)
                {
                    _employeeDetailDetail = value;
                    EmployeeDetailID = _employeeDetailDetail != null ? _employeeDetailDetail.UniqueIdentifier : 0;
                }
            }
        }

        $BusinessObjectChildInstanceDetailsProperty$

        
        public System.DateTime CallLetterDate
        {
            get { return CallLetterEntityDetail.CallLetterDate; }
            set
            {
                if (CallLetterEntityDetail.CallLetterDate != value)
                {
                    CallLetterEntityDetail.CallLetterDate = value;
                }
            }
        }

        public System.Int64 CallLetterNumber
        {
            get { return CallLetterEntityDetail.CallLetterNumber; }
            set
            {
                if (CallLetterEntityDetail.CallLetterNumber != value)
                {
                    CallLetterEntityDetail.CallLetterNumber = value;
                }
            }
        }

        public System.String CandidateAddress
        {
            get { return CallLetterEntityDetail.CandidateAddress; }
            set
            {
                if (CallLetterEntityDetail.CandidateAddress != value)
                {
                    CallLetterEntityDetail.CandidateAddress = value;
                }
            }
        }

        public System.String CandidateName
        {
            get { return CallLetterEntityDetail.CandidateName; }
            set
            {
                if (CallLetterEntityDetail.CandidateName != value)
                {
                    CallLetterEntityDetail.CandidateName = value;
                }
            }
        }

        public System.String CompanyCode
        {
            get { return CallLetterEntityDetail.CompanyCode; }
            set
            {
                if (CallLetterEntityDetail.CompanyCode != value)
                {
                    CallLetterEntityDetail.CompanyCode = value;
                }
            }
        }

        public System.String ContactNumber
        {
            get { return CallLetterEntityDetail.ContactNumber; }
            set
            {
                if (CallLetterEntityDetail.ContactNumber != value)
                {
                    CallLetterEntityDetail.ContactNumber = value;
                }
            }
        }

        public System.String InterviewDate
        {
            get { return CallLetterEntityDetail.InterviewDate; }
            set
            {
                if (CallLetterEntityDetail.InterviewDate != value)
                {
                    CallLetterEntityDetail.InterviewDate = value;
                }
            }
        }

        public System.String InterviewTime
        {
            get { return CallLetterEntityDetail.InterviewTime; }
            set
            {
                if (CallLetterEntityDetail.InterviewTime != value)
                {
                    CallLetterEntityDetail.InterviewTime = value;
                }
            }
        }

        public System.String DesignationCode
        {
            get { return CallLetterEntityDetail.DesignationCode; }
            set
            {
                if (CallLetterEntityDetail.DesignationCode != value)
                {
                    CallLetterEntityDetail.DesignationCode = value;
                }
            }
        }

        public System.String Regards
        {
            get { return CallLetterEntityDetail.Regards; }
            set
            {
                if (CallLetterEntityDetail.Regards != value)
                {
                    CallLetterEntityDetail.Regards = value;
                }
            }
        }

        public System.String UniqueIdentifier
        {
            get { return CallLetterEntityDetail.UniqueIdentifier; }
            set
            {
                if (CallLetterEntityDetail.UniqueIdentifier != value)
                {
                    CallLetterEntityDetail.UniqueIdentifier = value;
                }
            }
        }

        public System.String RowID
        {
            get { return CallLetterEntityDetail.RowID; }
            set
            {
                if (CallLetterEntityDetail.RowID != value)
                {
                    CallLetterEntityDetail.RowID = value;
                }
            }
        }


	
        public System.String CompanyName
        {
            get { return CompanyHeaderDetail!=null? CompanyHeaderDetail.CompanyName: default(System.String); }
        }

        public System.String DesignationName
        {
            get { return DesignationDetail!=null? DesignationDetail.DesignationDescription: default(System.String); }
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

        protected override int SaveChildBusinessObject()
        {
            int result = 0;

            result = base.SaveChildBusinessObject();
            $BusinessObjectChildCollectionDetailsSaveLines$

            return result;
        }

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

        protected override bool ValidateChildObjectsBeforeSave()
        {
            bool result = false;

            result = base.ValidateChildObjectsBeforeSave();
            $BusinessObjectChildCollectionDetailsValidateLines$

            return result;
        }

        protected override bool ValidateChildObjectsBeforeDelete()
        {
            bool result = false;

            result = base.ValidateChildObjectsBeforeSave();
            $BusinessObjectChildCollectionDetailsValidateLines$

            return result;
        }

        #endregion Protected

        #endregion Methods
    }
}
