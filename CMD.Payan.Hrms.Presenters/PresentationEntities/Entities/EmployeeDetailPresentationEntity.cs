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
    public class EmployeeDetailPresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public EmployeeDetailPresentationEntity(IPresenter presenter)
            : base(presenter, EmployeeDetailFactory.Factory)
        {
        }

        public EmployeeDetailPresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public EmployeeDetailPresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public EmployeeDetailPresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, EmployeeDetailFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties
	
        public System.String Aadhar
        {
            get { return EmployeeDetailDetail.Aadhar; }
            set { EmployeeDetailDetail.Aadhar = value; }
        }

        public System.Int64 ABonus
        {
            get { return EmployeeDetailDetail.ABonus; }
            set { EmployeeDetailDetail.ABonus = value; }
        }

        public System.String Address1
        {
            get { return EmployeeDetailDetail.Address1; }
            set { EmployeeDetailDetail.Address1 = value; }
        }

        public System.String Address2
        {
            get { return EmployeeDetailDetail.Address2; }
            set { EmployeeDetailDetail.Address2 = value; }
        }

        public System.String BankName
        {
            get { return EmployeeDetailDetail.BankName; }
            set { EmployeeDetailDetail.BankName = value; }
        }

        public System.String BankNumber
        {
            get { return EmployeeDetailDetail.BankNumber; }
            set { EmployeeDetailDetail.BankNumber = value; }
        }

        public System.Decimal Basic
        {
            get { return EmployeeDetailDetail.Basic; }
            set { EmployeeDetailDetail.Basic = value; }
        }

        public System.String CcGroupCode
        {
            get { return EmployeeDetailDetail.CcGroupCode; }
            set { EmployeeDetailDetail.CcGroupCode = value; }
        }

        public System.String City
        {
            get { return EmployeeDetailDetail.City; }
            set { EmployeeDetailDetail.City = value; }
        }

        public System.Int64 Cl
        {
            get { return EmployeeDetailDetail.Cl; }
            set { EmployeeDetailDetail.Cl = value; }
        }

        public System.String Classi
        {
            get { return EmployeeDetailDetail.Classi; }
            set { EmployeeDetailDetail.Classi = value; }
        }

        public System.String Degree
        {
            get { return EmployeeDetailDetail.Degree; }
            set { EmployeeDetailDetail.Degree = value; }
        }

        public System.String Deptcode
        {
            get { return EmployeeDetailDetail.Deptcode; }
            set { EmployeeDetailDetail.Deptcode = value; }
        }

        public System.String Deptname
        {
            get { return EmployeeDetailDetail.Deptname; }
            set { EmployeeDetailDetail.Deptname = value; }
        }

        public System.String Designation
        {
            get { return EmployeeDetailDetail.Designation; }
            set { EmployeeDetailDetail.Designation = value; }
        }

        public System.String Designdesc
        {
            get { return EmployeeDetailDetail.Designdesc; }
            set { EmployeeDetailDetail.Designdesc = value; }
        }

        public System.String DevCode
        {
            get { return EmployeeDetailDetail.DevCode; }
            set { EmployeeDetailDetail.DevCode = value; }
        }

        public System.String DevName
        {
            get { return EmployeeDetailDetail.DevName; }
            set { EmployeeDetailDetail.DevName = value; }
        }

        public System.String Dispensary
        {
            get { return EmployeeDetailDetail.Dispensary; }
            set { EmployeeDetailDetail.Dispensary = value; }
        }

        public System.String Dob
        {
            get { return EmployeeDetailDetail.Dob; }
            set { EmployeeDetailDetail.Dob = value; }
        }

        public System.String Doc
        {
            get { return EmployeeDetailDetail.Doc; }
            set { EmployeeDetailDetail.Doc = value; }
        }

        public System.String Doj
        {
            get { return EmployeeDetailDetail.Doj; }
            set { EmployeeDetailDetail.Doj = value; }
        }

        public System.String Dor
        {
            get { return EmployeeDetailDetail.Dor; }
            set { EmployeeDetailDetail.Dor = value; }
        }

        public System.Decimal DoubleOTType
        {
            get { return EmployeeDetailDetail.DoubleOTType; }
            set { EmployeeDetailDetail.DoubleOTType = value; }
        }

        public System.String Email
        {
            get { return EmployeeDetailDetail.Email; }
            set { EmployeeDetailDetail.Email = value; }
        }

        public System.String Empcode
        {
            get { return EmployeeDetailDetail.Empcode; }
            set { EmployeeDetailDetail.Empcode = value; }
        }

        public System.String Empimage
        {
            get { return EmployeeDetailDetail.Empimage; }
            set { EmployeeDetailDetail.Empimage = value; }
        }

        public System.String Empname
        {
            get { return EmployeeDetailDetail.Empname; }
            set { EmployeeDetailDetail.Empname = value; }
        }

        public System.Decimal Empno
        {
            get { return EmployeeDetailDetail.Empno; }
            set { EmployeeDetailDetail.Empno = value; }
        }

        public System.String EsiLocation
        {
            get { return EmployeeDetailDetail.EsiLocation; }
            set { EmployeeDetailDetail.EsiLocation = value; }
        }

        public System.String ESIno
        {
            get { return EmployeeDetailDetail.ESIno; }
            set { EmployeeDetailDetail.ESIno = value; }
        }

        public System.String FatherName
        {
            get { return EmployeeDetailDetail.FatherName; }
            set { EmployeeDetailDetail.FatherName = value; }
        }

        public System.Int64 FBonus
        {
            get { return EmployeeDetailDetail.FBonus; }
            set { EmployeeDetailDetail.FBonus = value; }
        }

        public System.String FClassi
        {
            get { return EmployeeDetailDetail.FClassi; }
            set { EmployeeDetailDetail.FClassi = value; }
        }

        public System.String FDESIGN
        {
            get { return EmployeeDetailDetail.FDESIGN; }
            set { EmployeeDetailDetail.FDESIGN = value; }
        }

        public System.String IFSCCODE
        {
            get { return EmployeeDetailDetail.IFSCCODE; }
            set { EmployeeDetailDetail.IFSCCODE = value; }
        }

        public System.String IncrMonth
        {
            get { return EmployeeDetailDetail.IncrMonth; }
            set { EmployeeDetailDetail.IncrMonth = value; }
        }

        public System.String InsNo
        {
            get { return EmployeeDetailDetail.InsNo; }
            set { EmployeeDetailDetail.InsNo = value; }
        }

        public System.Decimal InsPremium
        {
            get { return EmployeeDetailDetail.InsPremium; }
            set { EmployeeDetailDetail.InsPremium = value; }
        }

        public System.DateTime JoinDate
        {
            get { return EmployeeDetailDetail.JoinDate; }
            set { EmployeeDetailDetail.JoinDate = value; }
        }

        public System.Int64 OT
        {
            get { return EmployeeDetailDetail.OT; }
            set { EmployeeDetailDetail.OT = value; }
        }

        public System.Decimal OTType
        {
            get { return EmployeeDetailDetail.OTType; }
            set { EmployeeDetailDetail.OTType = value; }
        }

        public System.String PanNo
        {
            get { return EmployeeDetailDetail.PanNo; }
            set { EmployeeDetailDetail.PanNo = value; }
        }

        public System.String PayMode
        {
            get { return EmployeeDetailDetail.PayMode; }
            set { EmployeeDetailDetail.PayMode = value; }
        }

        public System.Int64 Pensionpf
        {
            get { return EmployeeDetailDetail.Pensionpf; }
            set { EmployeeDetailDetail.Pensionpf = value; }
        }

        public System.String PFMargin
        {
            get { return EmployeeDetailDetail.PFMargin; }
            set { EmployeeDetailDetail.PFMargin = value; }
        }

        public System.String PFno
        {
            get { return EmployeeDetailDetail.PFno; }
            set { EmployeeDetailDetail.PFno = value; }
        }

        public System.String Phone
        {
            get { return EmployeeDetailDetail.Phone; }
            set { EmployeeDetailDetail.Phone = value; }
        }

        public System.String Pincode
        {
            get { return EmployeeDetailDetail.Pincode; }
            set { EmployeeDetailDetail.Pincode = value; }
        }

        public System.String Policy1
        {
            get { return EmployeeDetailDetail.Policy1; }
            set { EmployeeDetailDetail.Policy1 = value; }
        }

        public System.String Policy2
        {
            get { return EmployeeDetailDetail.Policy2; }
            set { EmployeeDetailDetail.Policy2 = value; }
        }

        public System.String Policy3
        {
            get { return EmployeeDetailDetail.Policy3; }
            set { EmployeeDetailDetail.Policy3 = value; }
        }

        public System.Int64 PrdEnt
        {
            get { return EmployeeDetailDetail.PrdEnt; }
            set { EmployeeDetailDetail.PrdEnt = value; }
        }

        public System.DateTime RelDate
        {
            get { return EmployeeDetailDetail.RelDate; }
            set { EmployeeDetailDetail.RelDate = value; }
        }

        public System.String ResigReason
        {
            get { return EmployeeDetailDetail.ResigReason; }
            set { EmployeeDetailDetail.ResigReason = value; }
        }

        public System.String Revdate
        {
            get { return EmployeeDetailDetail.Revdate; }
            set { EmployeeDetailDetail.Revdate = value; }
        }

        public System.Decimal Revno
        {
            get { return EmployeeDetailDetail.Revno; }
            set { EmployeeDetailDetail.Revno = value; }
        }

        public System.Decimal SerialNo
        {
            get { return EmployeeDetailDetail.SerialNo; }
            set { EmployeeDetailDetail.SerialNo = value; }
        }

        public System.String Sex
        {
            get { return EmployeeDetailDetail.Sex; }
            set { EmployeeDetailDetail.Sex = value; }
        }

        public System.String Shft
        {
            get { return EmployeeDetailDetail.Shft; }
            set { EmployeeDetailDetail.Shft = value; }
        }

        public System.String Shft1
        {
            get { return EmployeeDetailDetail.Shft1; }
            set { EmployeeDetailDetail.Shft1 = value; }
        }

        public System.String SrName
        {
            get { return EmployeeDetailDetail.SrName; }
            set { EmployeeDetailDetail.SrName = value; }
        }

        public System.String Status
        {
            get { return EmployeeDetailDetail.Status; }
            set { EmployeeDetailDetail.Status = value; }
        }

        public System.String Subgroup
        {
            get { return EmployeeDetailDetail.Subgroup; }
            set { EmployeeDetailDetail.Subgroup = value; }
        }

        public System.Decimal Sunded
        {
            get { return EmployeeDetailDetail.Sunded; }
            set { EmployeeDetailDetail.Sunded = value; }
        }

        public System.String Swapcardno
        {
            get { return EmployeeDetailDetail.Swapcardno; }
            set { EmployeeDetailDetail.Swapcardno = value; }
        }

        public EmployeeDetail EmployeeDetailDetail
        {
            get { return BusinessObjectDetail as EmployeeDetail; }
        }

        private EmployeeDetailPresenter EmployeeDetailPresenterDetail
        {
            get { return PresenterDetail as EmployeeDetailPresenter; }
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
