using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class InterviewFormDetailsEntity : BusinessEntity, IBusinessEntity
    {
        #region Private Variables

	        private IField<System.String> _des;
        private IField<System.String> _grade;
        private IField<System.Decimal> _intno;
        private IField<System.String> _remarks;
        private IField<System.Int64> _slno;

        #endregion Private Variables

        #region Constructors

        public InterviewFormDetailsEntity()
            : base()
        {
	    InitializeFields();
        }

        public InterviewFormDetailsEntity(IParent parent)
            : base(parent)
        {
	    InitializeFields();
        }

        #endregion Constructors

        #region Properties
	
        public System.String Des
        {
            get { return _des.Value; }
            set { _des.Value = value; }
        }

        public System.String Grade
        {
            get { return _grade.Value; }
            set { _grade.Value = value; }
        }

        public System.Decimal IntNo
        {
            get { return _intno.Value; }
            set { _intno.Value = value; }
        }

        public System.String Remarks
        {
            get { return _remarks.Value; }
            set { _remarks.Value = value; }
        }

        public System.Int64 Slno
        {
            get { return _slno.Value; }
            set { _slno.Value = value; }
        }

        #endregion Properties
	
	#region Methods

	private void InitializeFields()
	{
		            _des = FieldFactory<System.String>.Factory.Instance(this);
            _grade = FieldFactory<System.String>.Factory.Instance(this);
            _intno = FieldFactory<System.Decimal>.Factory.Instance(this);
            _remarks = FieldFactory<System.String>.Factory.Instance(this);
            _slno = FieldFactory<System.Int64>.Factory.Instance(this);
		}

	#endregion Methods
    }
}