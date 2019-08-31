using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace $CMD.Payan$.$Hrms$.BusinessEntities
{
    public class AccessDetailsEntity : BusinessEntity, IBusinessEntity
    {
        #region Private Variables

	private IField<System.String> _accdate;private IField<System.Decimal> _acctime;private IField<System.String> _doorno;private IField<System.String> _empcode;private IField<System.String> _empname;private IField<System.String> _empno;private IField<System.String> _flg;private IField<System.Int64> _rno;private IField<System.String> _status;
        #endregion Private Variables

        #region Constructors

        public AccessDetailsEntity()
            : base()
        {
	    InitializeFields();
        }

        public AccessDetailsEntity(IParent parent)
            : base(parent)
        {
	    InitializeFields();
        }

        #endregion Constructors

        #region Properties
	public System.String AccDate
        {
            get { return _accdate.Value; }
            set { _accdate.Value = value; }
        }public System.Decimal AccTime
        {
            get { return _acctime.Value; }
            set { _acctime.Value = value; }
        }public System.String DoorNo
        {
            get { return _doorno.Value; }
            set { _doorno.Value = value; }
        }public System.String EmpCode
        {
            get { return _empcode.Value; }
            set { _empcode.Value = value; }
        }public System.String EmpName
        {
            get { return _empname.Value; }
            set { _empname.Value = value; }
        }public System.String Empno
        {
            get { return _empno.Value; }
            set { _empno.Value = value; }
        }public System.String Flg
        {
            get { return _flg.Value; }
            set { _flg.Value = value; }
        }public System.Int64 RNo
        {
            get { return _rno.Value; }
            set { _rno.Value = value; }
        }public System.String Status
        {
            get { return _status.Value; }
            set { _status.Value = value; }
        }
        #endregion Properties
	
	#region Methods

	private void InitializeFields()
	{
		_accdate = FieldFactory<System.String>.Factory.Instance(this);_acctime = FieldFactory<System.Decimal>.Factory.Instance(this);_doorno = FieldFactory<System.String>.Factory.Instance(this);_empcode = FieldFactory<System.String>.Factory.Instance(this);_empname = FieldFactory<System.String>.Factory.Instance(this);_empno = FieldFactory<System.String>.Factory.Instance(this);_flg = FieldFactory<System.String>.Factory.Instance(this);_rno = FieldFactory<System.Int64>.Factory.Instance(this);_status = FieldFactory<System.String>.Factory.Instance(this);		}

	#endregion Methods
    }
}