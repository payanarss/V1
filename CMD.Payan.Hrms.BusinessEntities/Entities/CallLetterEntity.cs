using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayanarCommon = Payanar.SS.Net.Libraries.Common;
using BusinessEntityInterfaces = CMD.Payan.Net.Base.BusinessEntity.Interfaces;
using BaseCommon = CMD.Payan.Net.Base.Common;

namespace CMD.Payan.Net.Hrms.BusinessEntities
{
    public class CallLetterEntity : BusinessEntityInterfaces.BusinessEntity
    {
        #region Private Variables

	        private IField<System.DateTime> _calldate;
        private IField<System.Int64> _callno;
        private IField<System.String> _candadd;
        private IField<System.String> _candto;
        private IField<System.String> _compcode;
        private IField<System.String> _contno;
        private IField<System.String> _intdate;
        private IField<System.String> _inttime;
        private IField<System.String> _pos;
        private IField<System.String> _regards;

        #endregion Private Variables

        #region Constructors

        public CallLetterEntity()
            : base()
        {
	    InitializeFields();
        }

        public CallLetterEntity(PayanarCommon.IParent parent)
            : base(parent)
        {
	    InitializeFields();
        }

        #endregion Constructors

        #region Properties

	
        public System.DateTime CallDate
        {
            get { return _calldate.Value; }
            set { _calldate.Value = value; }
        }

        public System.Int64 CallNo
        {
            get { return _callno.Value; }
            set { _callno.Value = value; }
        }

        public System.String CandAdd
        {
            get { return _candadd.Value; }
            set { _candadd.Value = value; }
        }

        public System.String CandTo
        {
            get { return _candto.Value; }
            set { _candto.Value = value; }
        }

        public System.String CompCode
        {
            get { return _compcode.Value; }
            set { _compcode.Value = value; }
        }

        public System.String ContNo
        {
            get { return _contno.Value; }
            set { _contno.Value = value; }
        }

        public System.String IntDate
        {
            get { return _intdate.Value; }
            set { _intdate.Value = value; }
        }

        public System.String IntTime
        {
            get { return _inttime.Value; }
            set { _inttime.Value = value; }
        }

        public System.String Pos
        {
            get { return _pos.Value; }
            set { _pos.Value = value; }
        }

        public System.String Regards
        {
            get { return _regards.Value; }
            set { _regards.Value = value; }
        }


        #endregion Properties
	
	#region Methods

	private void InitializeFields()
	{
		            _calldate = FieldFactory<System.DateTime>.Factory.Instance(this);
            _callno = FieldFactory<System.Int64>.Factory.Instance(this);
            _candadd = FieldFactory<System.String>.Factory.Instance(this);
            _candto = FieldFactory<System.String>.Factory.Instance(this);
            _compcode = FieldFactory<System.String>.Factory.Instance(this);
            _contno = FieldFactory<System.String>.Factory.Instance(this);
            _intdate = FieldFactory<System.String>.Factory.Instance(this);
            _inttime = FieldFactory<System.String>.Factory.Instance(this);
            _pos = FieldFactory<System.String>.Factory.Instance(this);
            _regards = FieldFactory<System.String>.Factory.Instance(this);
		
        }

	#endregion Methods
    }
}
