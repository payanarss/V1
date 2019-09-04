using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class CompanyEntity : BusinessEntity, IBusinessEntity
    {
        #region Private Variables

	        private IField<System.String> _companyaddress1;
        private IField<System.String> _companyaddress2;
        private IField<System.String> _companyaddress3;
        private IField<System.String> _companyaddress4;
        private IField<System.String> _companyname;
        private IField<System.String> _companyname1;
        private IField<System.String> _companycode;

        #endregion Private Variables

        #region Constructors

        public CompanyEntity()
            : base()
        {
	    InitializeFields();
        }

        public CompanyEntity(IParent parent)
            : base(parent)
        {
	    InitializeFields();
        }

        #endregion Constructors

        #region Properties
	
        public System.String CompanyAddress1
        {
            get { return _companyaddress1.Value; }
            set { _companyaddress1.Value = value; }
        }

        public System.String CompanyAddress2
        {
            get { return _companyaddress2.Value; }
            set { _companyaddress2.Value = value; }
        }

        public System.String CompanyAddress3
        {
            get { return _companyaddress3.Value; }
            set { _companyaddress3.Value = value; }
        }

        public System.String CompanyAddress4
        {
            get { return _companyaddress4.Value; }
            set { _companyaddress4.Value = value; }
        }

        public System.String CompanyName
        {
            get { return _companyname.Value; }
            set { _companyname.Value = value; }
        }

        public System.String CompanyName1
        {
            get { return _companyname1.Value; }
            set { _companyname1.Value = value; }
        }

        public System.String CompanyCode
        {
            get { return _companycode.Value; }
            set { _companycode.Value = value; }
        }

        #endregion Properties
	
	#region Methods

	private void InitializeFields()
	{
		            _companyaddress1 = FieldFactory<System.String>.Factory.Instance(this);
            _companyaddress2 = FieldFactory<System.String>.Factory.Instance(this);
            _companyaddress3 = FieldFactory<System.String>.Factory.Instance(this);
            _companyaddress4 = FieldFactory<System.String>.Factory.Instance(this);
            _companyname = FieldFactory<System.String>.Factory.Instance(this);
            _companyname1 = FieldFactory<System.String>.Factory.Instance(this);
            _companycode = FieldFactory<System.String>.Factory.Instance(this);
		}

	#endregion Methods
    }
}