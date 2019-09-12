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

	        private IField<System.DateTime> _callletterdate;
        private IField<System.Int64> _callletternumber;
        private IField<System.String> _candidateaddress;
        private IField<System.String> _candidatename;
        private IField<System.String> _companycode;
        private IField<System.String> _contactnumber;
        private IField<System.String> _interviewdate;
        private IField<System.String> _interviewtime;
        private IField<System.String> _designationcode;
        private IField<System.String> _regards;
        private IField<System.String> _uniqueidentifier;
        private IField<System.String> _rowid;

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

	$PropertiesDeclarationCode$

        #endregion Properties
	
	#region Methods

	private void InitializeFields()
	{
		            _callletterdate = FieldFactory<System.DateTime>.Factory.Instance(this);
            _callletternumber = FieldFactory<System.Int64>.Factory.Instance(this);
            _candidateaddress = FieldFactory<System.String>.Factory.Instance(this);
            _candidatename = FieldFactory<System.String>.Factory.Instance(this);
            _companycode = FieldFactory<System.String>.Factory.Instance(this);
            _contactnumber = FieldFactory<System.String>.Factory.Instance(this);
            _interviewdate = FieldFactory<System.String>.Factory.Instance(this);
            _interviewtime = FieldFactory<System.String>.Factory.Instance(this);
            _designationcode = FieldFactory<System.String>.Factory.Instance(this);
            _regards = FieldFactory<System.String>.Factory.Instance(this);
            _uniqueidentifier = FieldFactory<System.String>.Factory.Instance(this);
            _rowid = FieldFactory<System.String>.Factory.Instance(this);
		
        }

	#endregion Methods
    }
}
