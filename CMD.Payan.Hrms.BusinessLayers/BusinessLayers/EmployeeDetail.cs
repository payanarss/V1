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
    public class EmployeeDetail : BusinessObject, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public EmployeeDetail()
            : base(EmployeeDetailEntityFactory.Factory, EmployeeDetailDatabaseAgentFactory.Factory)
        { }

 	public EmployeeDetail(IParent parent)
            : base(EmployeeDetailEntityFactory.Factory, EmployeeDetailDatabaseAgentFactory.Factory, parent)
        { }

        #endregion Constructors

        #region Properties
	
        public System.String Aadhar
        {
            get { return EmployeeDetailEntityDetail.Aadhar; }
            set { EmployeeDetailEntityDetail.Aadhar = value; }
        }

        public System.Int64 ABonus
        {
            get { return EmployeeDetailEntityDetail.ABonus; }
            set { EmployeeDetailEntityDetail.ABonus = value; }
        }

        public System.String Address1
        {
            get { return EmployeeDetailEntityDetail.Address1; }
            set { EmployeeDetailEntityDetail.Address1 = value; }
        }

        public System.String Address2
        {
            get { return EmployeeDetailEntityDetail.Address2; }
            set { EmployeeDetailEntityDetail.Address2 = value; }
        }

        public System.String BankName
        {
            get { return EmployeeDetailEntityDetail.BankName; }
            set { EmployeeDetailEntityDetail.BankName = value; }
        }

        public System.String BankNumber
        {
            get { return EmployeeDetailEntityDetail.BankNumber; }
            set { EmployeeDetailEntityDetail.BankNumber = value; }
        }

        public System.Decimal Basic
        {
            get { return EmployeeDetailEntityDetail.Basic; }
            set { EmployeeDetailEntityDetail.Basic = value; }
        }

        public System.String CcGroupCode
        {
            get { return EmployeeDetailEntityDetail.CcGroupCode; }
            set { EmployeeDetailEntityDetail.CcGroupCode = value; }
        }

        public System.String City
        {
            get { return EmployeeDetailEntityDetail.City; }
            set { EmployeeDetailEntityDetail.City = value; }
        }

        public System.Int64 Cl
        {
            get { return EmployeeDetailEntityDetail.Cl; }
            set { EmployeeDetailEntityDetail.Cl = value; }
        }

        public System.String Classi
        {
            get { return EmployeeDetailEntityDetail.Classi; }
            set { EmployeeDetailEntityDetail.Classi = value; }
        }

        public System.String Degree
        {
            get { return EmployeeDetailEntityDetail.Degree; }
            set { EmployeeDetailEntityDetail.Degree = value; }
        }

        public System.String Deptcode
        {
            get { return EmployeeDetailEntityDetail.Deptcode; }
            set { EmployeeDetailEntityDetail.Deptcode = value; }
        }

        public System.String Deptname
        {
            get { return EmployeeDetailEntityDetail.Deptname; }
            set { EmployeeDetailEntityDetail.Deptname = value; }
        }

        public System.String Designation
        {
            get { return EmployeeDetailEntityDetail.Designation; }
            set { EmployeeDetailEntityDetail.Designation = value; }
        }

        public System.String Designdesc
        {
            get { return EmployeeDetailEntityDetail.Designdesc; }
            set { EmployeeDetailEntityDetail.Designdesc = value; }
        }

        public System.String DevCode
        {
            get { return EmployeeDetailEntityDetail.DevCode; }
            set { EmployeeDetailEntityDetail.DevCode = value; }
        }

        public System.String DevName
        {
            get { return EmployeeDetailEntityDetail.DevName; }
            set { EmployeeDetailEntityDetail.DevName = value; }
        }

        public System.String Dispensary
        {
            get { return EmployeeDetailEntityDetail.Dispensary; }
            set { EmployeeDetailEntityDetail.Dispensary = value; }
        }

        public System.String Dob
        {
            get { return EmployeeDetailEntityDetail.Dob; }
            set { EmployeeDetailEntityDetail.Dob = value; }
        }

        public System.String Doc
        {
            get { return EmployeeDetailEntityDetail.Doc; }
            set { EmployeeDetailEntityDetail.Doc = value; }
        }

        public System.String Doj
        {
            get { return EmployeeDetailEntityDetail.Doj; }
            set { EmployeeDetailEntityDetail.Doj = value; }
        }

        public System.String Dor
        {
            get { return EmployeeDetailEntityDetail.Dor; }
            set { EmployeeDetailEntityDetail.Dor = value; }
        }

        public System.Decimal DoubleOTType
        {
            get { return EmployeeDetailEntityDetail.DoubleOTType; }
            set { EmployeeDetailEntityDetail.DoubleOTType = value; }
        }

        public System.String Email
        {
            get { return EmployeeDetailEntityDetail.Email; }
            set { EmployeeDetailEntityDetail.Email = value; }
        }

        public System.String Empcode
        {
            get { return EmployeeDetailEntityDetail.Empcode; }
            set { EmployeeDetailEntityDetail.Empcode = value; }
        }

        public System.String Empimage
        {
            get { return EmployeeDetailEntityDetail.Empimage; }
            set { EmployeeDetailEntityDetail.Empimage = value; }
        }

        public System.String Empname
        {
            get { return EmployeeDetailEntityDetail.Empname; }
            set { EmployeeDetailEntityDetail.Empname = value; }
        }

        public System.Decimal Empno
        {
            get { return EmployeeDetailEntityDetail.Empno; }
            set { EmployeeDetailEntityDetail.Empno = value; }
        }

        public System.String EsiLocation
        {
            get { return EmployeeDetailEntityDetail.EsiLocation; }
            set { EmployeeDetailEntityDetail.EsiLocation = value; }
        }

        public System.String ESIno
        {
            get { return EmployeeDetailEntityDetail.ESIno; }
            set { EmployeeDetailEntityDetail.ESIno = value; }
        }

        public System.String FatherName
        {
            get { return EmployeeDetailEntityDetail.FatherName; }
            set { EmployeeDetailEntityDetail.FatherName = value; }
        }

        public System.Int64 FBonus
        {
            get { return EmployeeDetailEntityDetail.FBonus; }
            set { EmployeeDetailEntityDetail.FBonus = value; }
        }

        public System.String FClassi
        {
            get { return EmployeeDetailEntityDetail.FClassi; }
            set { EmployeeDetailEntityDetail.FClassi = value; }
        }

        public System.String FDESIGN
        {
            get { return EmployeeDetailEntityDetail.FDESIGN; }
            set { EmployeeDetailEntityDetail.FDESIGN = value; }
        }

        public System.String IFSCCODE
        {
            get { return EmployeeDetailEntityDetail.IFSCCODE; }
            set { EmployeeDetailEntityDetail.IFSCCODE = value; }
        }

        public System.String IncrMonth
        {
            get { return EmployeeDetailEntityDetail.IncrMonth; }
            set { EmployeeDetailEntityDetail.IncrMonth = value; }
        }

        public System.String InsNo
        {
            get { return EmployeeDetailEntityDetail.InsNo; }
            set { EmployeeDetailEntityDetail.InsNo = value; }
        }

        public System.Decimal InsPremium
        {
            get { return EmployeeDetailEntityDetail.InsPremium; }
            set { EmployeeDetailEntityDetail.InsPremium = value; }
        }

        public System.DateTime JoinDate
        {
            get { return EmployeeDetailEntityDetail.JoinDate; }
            set { EmployeeDetailEntityDetail.JoinDate = value; }
        }

        public System.Int64 OT
        {
            get { return EmployeeDetailEntityDetail.OT; }
            set { EmployeeDetailEntityDetail.OT = value; }
        }

        public System.Decimal OTType
        {
            get { return EmployeeDetailEntityDetail.OTType; }
            set { EmployeeDetailEntityDetail.OTType = value; }
        }

        public System.String PanNo
        {
            get { return EmployeeDetailEntityDetail.PanNo; }
            set { EmployeeDetailEntityDetail.PanNo = value; }
        }

        public System.String PayMode
        {
            get { return EmployeeDetailEntityDetail.PayMode; }
            set { EmployeeDetailEntityDetail.PayMode = value; }
        }

        public System.Int64 Pensionpf
        {
            get { return EmployeeDetailEntityDetail.Pensionpf; }
            set { EmployeeDetailEntityDetail.Pensionpf = value; }
        }

        public System.String PFMargin
        {
            get { return EmployeeDetailEntityDetail.PFMargin; }
            set { EmployeeDetailEntityDetail.PFMargin = value; }
        }

        public System.String PFno
        {
            get { return EmployeeDetailEntityDetail.PFno; }
            set { EmployeeDetailEntityDetail.PFno = value; }
        }

        public System.String Phone
        {
            get { return EmployeeDetailEntityDetail.Phone; }
            set { EmployeeDetailEntityDetail.Phone = value; }
        }

        public System.String Pincode
        {
            get { return EmployeeDetailEntityDetail.Pincode; }
            set { EmployeeDetailEntityDetail.Pincode = value; }
        }

        public System.String Policy1
        {
            get { return EmployeeDetailEntityDetail.Policy1; }
            set { EmployeeDetailEntityDetail.Policy1 = value; }
        }

        public System.String Policy2
        {
            get { return EmployeeDetailEntityDetail.Policy2; }
            set { EmployeeDetailEntityDetail.Policy2 = value; }
        }

        public System.String Policy3
        {
            get { return EmployeeDetailEntityDetail.Policy3; }
            set { EmployeeDetailEntityDetail.Policy3 = value; }
        }

        public System.Int64 PrdEnt
        {
            get { return EmployeeDetailEntityDetail.PrdEnt; }
            set { EmployeeDetailEntityDetail.PrdEnt = value; }
        }

        public System.DateTime RelDate
        {
            get { return EmployeeDetailEntityDetail.RelDate; }
            set { EmployeeDetailEntityDetail.RelDate = value; }
        }

        public System.String ResigReason
        {
            get { return EmployeeDetailEntityDetail.ResigReason; }
            set { EmployeeDetailEntityDetail.ResigReason = value; }
        }

        public System.String Revdate
        {
            get { return EmployeeDetailEntityDetail.Revdate; }
            set { EmployeeDetailEntityDetail.Revdate = value; }
        }

        public System.Decimal Revno
        {
            get { return EmployeeDetailEntityDetail.Revno; }
            set { EmployeeDetailEntityDetail.Revno = value; }
        }

        public System.Decimal SerialNo
        {
            get { return EmployeeDetailEntityDetail.SerialNo; }
            set { EmployeeDetailEntityDetail.SerialNo = value; }
        }

        public System.String Sex
        {
            get { return EmployeeDetailEntityDetail.Sex; }
            set { EmployeeDetailEntityDetail.Sex = value; }
        }

        public System.String Shft
        {
            get { return EmployeeDetailEntityDetail.Shft; }
            set { EmployeeDetailEntityDetail.Shft = value; }
        }

        public System.String Shft1
        {
            get { return EmployeeDetailEntityDetail.Shft1; }
            set { EmployeeDetailEntityDetail.Shft1 = value; }
        }

        public System.String SrName
        {
            get { return EmployeeDetailEntityDetail.SrName; }
            set { EmployeeDetailEntityDetail.SrName = value; }
        }

        public System.String Status
        {
            get { return EmployeeDetailEntityDetail.Status; }
            set { EmployeeDetailEntityDetail.Status = value; }
        }

        public System.String Subgroup
        {
            get { return EmployeeDetailEntityDetail.Subgroup; }
            set { EmployeeDetailEntityDetail.Subgroup = value; }
        }

        public System.Decimal Sunded
        {
            get { return EmployeeDetailEntityDetail.Sunded; }
            set { EmployeeDetailEntityDetail.Sunded = value; }
        }

        public System.String Swapcardno
        {
            get { return EmployeeDetailEntityDetail.Swapcardno; }
            set { EmployeeDetailEntityDetail.Swapcardno = value; }
        }

        private EmployeeDetailEntity EmployeeDetailEntityDetail
        {
            get { return BusinessEntityObject as EmployeeDetailEntity; }
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
