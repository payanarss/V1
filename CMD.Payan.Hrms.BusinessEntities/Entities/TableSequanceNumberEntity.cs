using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class TableSequanceNumberEntity : BusinessEntity, IBusinessEntity
    {
        #region Private Variables

	        private IField<System.String> _tablename;
        private IField<System.Int64> _sequencenumber;
        private IField<System.Int64> _nextsequencenumber;
        private IField<System.DateTime> _currentdate;

        #endregion Private Variables

        #region Constructors

        public TableSequanceNumberEntity()
            : base()
        {
	    InitializeFields();
        }

        public TableSequanceNumberEntity(IParent parent)
            : base(parent)
        {
	    InitializeFields();
        }

        #endregion Constructors

        #region Properties
	
        public System.String TableName
        {
            get { return _tablename.Value; }
            set { _tablename.Value = value; }
        }

        public System.Int64 SequenceNumber
        {
            get { return _sequencenumber.Value; }
            set { _sequencenumber.Value = value; }
        }

        public System.Int64 NextSequenceNumber
        {
            get { return _nextsequencenumber.Value; }
            set { _nextsequencenumber.Value = value; }
        }

        public System.DateTime CurrentDate
        {
            get { return _currentdate.Value; }
            set { _currentdate.Value = value; }
        }

        #endregion Properties
	
	#region Methods

	private void InitializeFields()
	{
		            _tablename = FieldFactory<System.String>.Factory.Instance(this);
            _sequencenumber = FieldFactory<System.Int64>.Factory.Instance(this);
            _nextsequencenumber = FieldFactory<System.Int64>.Factory.Instance(this);
            _currentdate = FieldFactory<System.DateTime>.Factory.Instance(this);
		}

	#endregion Methods
    }
}