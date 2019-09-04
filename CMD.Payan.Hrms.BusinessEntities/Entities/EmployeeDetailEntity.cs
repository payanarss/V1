using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class EmployeeDetailEntity : BusinessEntity, IBusinessEntity
    {
        #region Private Variables

	        private IField<System.String> _aadhar;
        private IField<System.Int64> _abonus;
        private IField<System.String> _address1;
        private IField<System.String> _address2;
        private IField<System.String> _bankname;
        private IField<System.String> _banknumber;
        private IField<System.Decimal> _basic;
        private IField<System.String> _ccgroupcode;
        private IField<System.String> _city;
        private IField<System.Int64> _cl;
        private IField<System.String> _classi;
        private IField<System.String> _degree;
        private IField<System.String> _deptcode;
        private IField<System.String> _deptname;
        private IField<System.String> _designation;
        private IField<System.String> _designdesc;
        private IField<System.String> _devcode;
        private IField<System.String> _devname;
        private IField<System.String> _dispensary;
        private IField<System.String> _dob;
        private IField<System.String> _doc;
        private IField<System.String> _doj;
        private IField<System.String> _dor;
        private IField<System.Decimal> _doubleottype;
        private IField<System.String> _email;
        private IField<System.String> _empcode;
        private IField<System.String> _empimage;
        private IField<System.String> _empname;
        private IField<System.Decimal> _empno;
        private IField<System.String> _esilocation;
        private IField<System.String> _esino;
        private IField<System.String> _fathername;
        private IField<System.Int64> _fbonus;
        private IField<System.String> _fclassi;
        private IField<System.String> _fdesign;
        private IField<System.String> _ifsccode;
        private IField<System.String> _incrmonth;
        private IField<System.String> _insno;
        private IField<System.Decimal> _inspremium;
        private IField<System.DateTime> _joindate;
        private IField<System.Int64> _ot;
        private IField<System.Decimal> _ottype;
        private IField<System.String> _panno;
        private IField<System.String> _paymode;
        private IField<System.Int64> _pensionpf;
        private IField<System.String> _pfmargin;
        private IField<System.String> _pfno;
        private IField<System.String> _phone;
        private IField<System.String> _pincode;
        private IField<System.String> _policy1;
        private IField<System.String> _policy2;
        private IField<System.String> _policy3;
        private IField<System.Int64> _prdent;
        private IField<System.DateTime> _reldate;
        private IField<System.String> _resigreason;
        private IField<System.String> _revdate;
        private IField<System.Decimal> _revno;
        private IField<System.Decimal> _serialno;
        private IField<System.String> _sex;
        private IField<System.String> _shft;
        private IField<System.String> _shft1;
        private IField<System.String> _srname;
        private IField<System.String> _status;
        private IField<System.String> _subgroup;
        private IField<System.Decimal> _sunded;
        private IField<System.String> _swapcardno;

        #endregion Private Variables

        #region Constructors

        public EmployeeDetailEntity()
            : base()
        {
	    InitializeFields();
        }

        public EmployeeDetailEntity(IParent parent)
            : base(parent)
        {
	    InitializeFields();
        }

        #endregion Constructors

        #region Properties
	
        public System.String Aadhar
        {
            get { return _aadhar.Value; }
            set { _aadhar.Value = value; }
        }

        public System.Int64 ABonus
        {
            get { return _abonus.Value; }
            set { _abonus.Value = value; }
        }

        public System.String Address1
        {
            get { return _address1.Value; }
            set { _address1.Value = value; }
        }

        public System.String Address2
        {
            get { return _address2.Value; }
            set { _address2.Value = value; }
        }

        public System.String BankName
        {
            get { return _bankname.Value; }
            set { _bankname.Value = value; }
        }

        public System.String BankNumber
        {
            get { return _banknumber.Value; }
            set { _banknumber.Value = value; }
        }

        public System.Decimal Basic
        {
            get { return _basic.Value; }
            set { _basic.Value = value; }
        }

        public System.String CcGroupCode
        {
            get { return _ccgroupcode.Value; }
            set { _ccgroupcode.Value = value; }
        }

        public System.String City
        {
            get { return _city.Value; }
            set { _city.Value = value; }
        }

        public System.Int64 Cl
        {
            get { return _cl.Value; }
            set { _cl.Value = value; }
        }

        public System.String Classi
        {
            get { return _classi.Value; }
            set { _classi.Value = value; }
        }

        public System.String Degree
        {
            get { return _degree.Value; }
            set { _degree.Value = value; }
        }

        public System.String Deptcode
        {
            get { return _deptcode.Value; }
            set { _deptcode.Value = value; }
        }

        public System.String Deptname
        {
            get { return _deptname.Value; }
            set { _deptname.Value = value; }
        }

        public System.String Designation
        {
            get { return _designation.Value; }
            set { _designation.Value = value; }
        }

        public System.String Designdesc
        {
            get { return _designdesc.Value; }
            set { _designdesc.Value = value; }
        }

        public System.String DevCode
        {
            get { return _devcode.Value; }
            set { _devcode.Value = value; }
        }

        public System.String DevName
        {
            get { return _devname.Value; }
            set { _devname.Value = value; }
        }

        public System.String Dispensary
        {
            get { return _dispensary.Value; }
            set { _dispensary.Value = value; }
        }

        public System.String Dob
        {
            get { return _dob.Value; }
            set { _dob.Value = value; }
        }

        public System.String Doc
        {
            get { return _doc.Value; }
            set { _doc.Value = value; }
        }

        public System.String Doj
        {
            get { return _doj.Value; }
            set { _doj.Value = value; }
        }

        public System.String Dor
        {
            get { return _dor.Value; }
            set { _dor.Value = value; }
        }

        public System.Decimal DoubleOTType
        {
            get { return _doubleottype.Value; }
            set { _doubleottype.Value = value; }
        }

        public System.String Email
        {
            get { return _email.Value; }
            set { _email.Value = value; }
        }

        public System.String Empcode
        {
            get { return _empcode.Value; }
            set { _empcode.Value = value; }
        }

        public System.String Empimage
        {
            get { return _empimage.Value; }
            set { _empimage.Value = value; }
        }

        public System.String Empname
        {
            get { return _empname.Value; }
            set { _empname.Value = value; }
        }

        public System.Decimal Empno
        {
            get { return _empno.Value; }
            set { _empno.Value = value; }
        }

        public System.String EsiLocation
        {
            get { return _esilocation.Value; }
            set { _esilocation.Value = value; }
        }

        public System.String ESIno
        {
            get { return _esino.Value; }
            set { _esino.Value = value; }
        }

        public System.String FatherName
        {
            get { return _fathername.Value; }
            set { _fathername.Value = value; }
        }

        public System.Int64 FBonus
        {
            get { return _fbonus.Value; }
            set { _fbonus.Value = value; }
        }

        public System.String FClassi
        {
            get { return _fclassi.Value; }
            set { _fclassi.Value = value; }
        }

        public System.String FDESIGN
        {
            get { return _fdesign.Value; }
            set { _fdesign.Value = value; }
        }

        public System.String IFSCCODE
        {
            get { return _ifsccode.Value; }
            set { _ifsccode.Value = value; }
        }

        public System.String IncrMonth
        {
            get { return _incrmonth.Value; }
            set { _incrmonth.Value = value; }
        }

        public System.String InsNo
        {
            get { return _insno.Value; }
            set { _insno.Value = value; }
        }

        public System.Decimal InsPremium
        {
            get { return _inspremium.Value; }
            set { _inspremium.Value = value; }
        }

        public System.DateTime JoinDate
        {
            get { return _joindate.Value; }
            set { _joindate.Value = value; }
        }

        public System.Int64 OT
        {
            get { return _ot.Value; }
            set { _ot.Value = value; }
        }

        public System.Decimal OTType
        {
            get { return _ottype.Value; }
            set { _ottype.Value = value; }
        }

        public System.String PanNo
        {
            get { return _panno.Value; }
            set { _panno.Value = value; }
        }

        public System.String PayMode
        {
            get { return _paymode.Value; }
            set { _paymode.Value = value; }
        }

        public System.Int64 Pensionpf
        {
            get { return _pensionpf.Value; }
            set { _pensionpf.Value = value; }
        }

        public System.String PFMargin
        {
            get { return _pfmargin.Value; }
            set { _pfmargin.Value = value; }
        }

        public System.String PFno
        {
            get { return _pfno.Value; }
            set { _pfno.Value = value; }
        }

        public System.String Phone
        {
            get { return _phone.Value; }
            set { _phone.Value = value; }
        }

        public System.String Pincode
        {
            get { return _pincode.Value; }
            set { _pincode.Value = value; }
        }

        public System.String Policy1
        {
            get { return _policy1.Value; }
            set { _policy1.Value = value; }
        }

        public System.String Policy2
        {
            get { return _policy2.Value; }
            set { _policy2.Value = value; }
        }

        public System.String Policy3
        {
            get { return _policy3.Value; }
            set { _policy3.Value = value; }
        }

        public System.Int64 PrdEnt
        {
            get { return _prdent.Value; }
            set { _prdent.Value = value; }
        }

        public System.DateTime RelDate
        {
            get { return _reldate.Value; }
            set { _reldate.Value = value; }
        }

        public System.String ResigReason
        {
            get { return _resigreason.Value; }
            set { _resigreason.Value = value; }
        }

        public System.String Revdate
        {
            get { return _revdate.Value; }
            set { _revdate.Value = value; }
        }

        public System.Decimal Revno
        {
            get { return _revno.Value; }
            set { _revno.Value = value; }
        }

        public System.Decimal SerialNo
        {
            get { return _serialno.Value; }
            set { _serialno.Value = value; }
        }

        public System.String Sex
        {
            get { return _sex.Value; }
            set { _sex.Value = value; }
        }

        public System.String Shft
        {
            get { return _shft.Value; }
            set { _shft.Value = value; }
        }

        public System.String Shft1
        {
            get { return _shft1.Value; }
            set { _shft1.Value = value; }
        }

        public System.String SrName
        {
            get { return _srname.Value; }
            set { _srname.Value = value; }
        }

        public System.String Status
        {
            get { return _status.Value; }
            set { _status.Value = value; }
        }

        public System.String Subgroup
        {
            get { return _subgroup.Value; }
            set { _subgroup.Value = value; }
        }

        public System.Decimal Sunded
        {
            get { return _sunded.Value; }
            set { _sunded.Value = value; }
        }

        public System.String Swapcardno
        {
            get { return _swapcardno.Value; }
            set { _swapcardno.Value = value; }
        }

        #endregion Properties
	
	#region Methods

	private void InitializeFields()
	{
		            _aadhar = FieldFactory<System.String>.Factory.Instance(this);
            _abonus = FieldFactory<System.Int64>.Factory.Instance(this);
            _address1 = FieldFactory<System.String>.Factory.Instance(this);
            _address2 = FieldFactory<System.String>.Factory.Instance(this);
            _bankname = FieldFactory<System.String>.Factory.Instance(this);
            _banknumber = FieldFactory<System.String>.Factory.Instance(this);
            _basic = FieldFactory<System.Decimal>.Factory.Instance(this);
            _ccgroupcode = FieldFactory<System.String>.Factory.Instance(this);
            _city = FieldFactory<System.String>.Factory.Instance(this);
            _cl = FieldFactory<System.Int64>.Factory.Instance(this);
            _classi = FieldFactory<System.String>.Factory.Instance(this);
            _degree = FieldFactory<System.String>.Factory.Instance(this);
            _deptcode = FieldFactory<System.String>.Factory.Instance(this);
            _deptname = FieldFactory<System.String>.Factory.Instance(this);
            _designation = FieldFactory<System.String>.Factory.Instance(this);
            _designdesc = FieldFactory<System.String>.Factory.Instance(this);
            _devcode = FieldFactory<System.String>.Factory.Instance(this);
            _devname = FieldFactory<System.String>.Factory.Instance(this);
            _dispensary = FieldFactory<System.String>.Factory.Instance(this);
            _dob = FieldFactory<System.String>.Factory.Instance(this);
            _doc = FieldFactory<System.String>.Factory.Instance(this);
            _doj = FieldFactory<System.String>.Factory.Instance(this);
            _dor = FieldFactory<System.String>.Factory.Instance(this);
            _doubleottype = FieldFactory<System.Decimal>.Factory.Instance(this);
            _email = FieldFactory<System.String>.Factory.Instance(this);
            _empcode = FieldFactory<System.String>.Factory.Instance(this);
            _empimage = FieldFactory<System.String>.Factory.Instance(this);
            _empname = FieldFactory<System.String>.Factory.Instance(this);
            _empno = FieldFactory<System.Decimal>.Factory.Instance(this);
            _esilocation = FieldFactory<System.String>.Factory.Instance(this);
            _esino = FieldFactory<System.String>.Factory.Instance(this);
            _fathername = FieldFactory<System.String>.Factory.Instance(this);
            _fbonus = FieldFactory<System.Int64>.Factory.Instance(this);
            _fclassi = FieldFactory<System.String>.Factory.Instance(this);
            _fdesign = FieldFactory<System.String>.Factory.Instance(this);
            _ifsccode = FieldFactory<System.String>.Factory.Instance(this);
            _incrmonth = FieldFactory<System.String>.Factory.Instance(this);
            _insno = FieldFactory<System.String>.Factory.Instance(this);
            _inspremium = FieldFactory<System.Decimal>.Factory.Instance(this);
            _joindate = FieldFactory<System.DateTime>.Factory.Instance(this);
            _ot = FieldFactory<System.Int64>.Factory.Instance(this);
            _ottype = FieldFactory<System.Decimal>.Factory.Instance(this);
            _panno = FieldFactory<System.String>.Factory.Instance(this);
            _paymode = FieldFactory<System.String>.Factory.Instance(this);
            _pensionpf = FieldFactory<System.Int64>.Factory.Instance(this);
            _pfmargin = FieldFactory<System.String>.Factory.Instance(this);
            _pfno = FieldFactory<System.String>.Factory.Instance(this);
            _phone = FieldFactory<System.String>.Factory.Instance(this);
            _pincode = FieldFactory<System.String>.Factory.Instance(this);
            _policy1 = FieldFactory<System.String>.Factory.Instance(this);
            _policy2 = FieldFactory<System.String>.Factory.Instance(this);
            _policy3 = FieldFactory<System.String>.Factory.Instance(this);
            _prdent = FieldFactory<System.Int64>.Factory.Instance(this);
            _reldate = FieldFactory<System.DateTime>.Factory.Instance(this);
            _resigreason = FieldFactory<System.String>.Factory.Instance(this);
            _revdate = FieldFactory<System.String>.Factory.Instance(this);
            _revno = FieldFactory<System.Decimal>.Factory.Instance(this);
            _serialno = FieldFactory<System.Decimal>.Factory.Instance(this);
            _sex = FieldFactory<System.String>.Factory.Instance(this);
            _shft = FieldFactory<System.String>.Factory.Instance(this);
            _shft1 = FieldFactory<System.String>.Factory.Instance(this);
            _srname = FieldFactory<System.String>.Factory.Instance(this);
            _status = FieldFactory<System.String>.Factory.Instance(this);
            _subgroup = FieldFactory<System.String>.Factory.Instance(this);
            _sunded = FieldFactory<System.Decimal>.Factory.Instance(this);
            _swapcardno = FieldFactory<System.String>.Factory.Instance(this);
		}

	#endregion Methods
    }
}