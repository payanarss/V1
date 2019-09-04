using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class CallLetterEntity : BusinessEntity, IBusinessEntity
    {
        #region Private Variables

        private IField<System.DateTime> _callletterdate;
        private IField<System.Int64> _callletternumber;
        private IField<System.String> _candidateaddress;
        private IField<System.String> _candidatename;
        private IField<System.String> _companycode;
        private IField<System.String> _contactnumber;
        private IField<System.DateTime> _interviewdate;
        private IField<System.String> _interviewtime;
        private IField<System.String> _position;
        private IField<System.String> _regards;

        #endregion Private Variables

        #region Constructors

        public CallLetterEntity()
            : base()
        {
            InitializeFields();
        }

        public CallLetterEntity(IParent parent)
            : base(parent)
        {
            InitializeFields();
        }

        #endregion Constructors

        #region Properties

        public System.DateTime CallLetterDate
        {
            get { return _callletterdate.Value; }
            set { _callletterdate.Value = value; }
        }

        public System.Int64 CallLetterNumber
        {
            get { return _callletternumber.Value; }
            set { _callletternumber.Value = value; }
        }

        public System.String CandidateAddress
        {
            get { return _candidateaddress.Value; }
            set { _candidateaddress.Value = value; }
        }

        public System.String CandidateName
        {
            get { return _candidatename.Value; }
            set { _candidatename.Value = value; }
        }

        public System.String CompanyCode
        {
            get { return _companycode.Value; }
            set { _companycode.Value = value; }
        }

        public System.String ContactNumber
        {
            get { return _contactnumber.Value; }
            set { _contactnumber.Value = value; }
        }

        public System.DateTime InterviewDate
        {
            get { return _interviewdate.Value; }
            set { _interviewdate.Value = value; }
        }

        public System.String InterviewTime
        {
            get { return _interviewtime.Value; }
            set { _interviewtime.Value = value; }
        }

        public System.String Position
        {
            get { return _position.Value; }
            set { _position.Value = value; }
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
            _callletterdate = FieldFactory<System.DateTime>.Factory.Instance(this);
            _callletternumber = FieldFactory<System.Int64>.Factory.Instance(this);
            _candidateaddress = FieldFactory<System.String>.Factory.Instance(this);
            _candidatename = FieldFactory<System.String>.Factory.Instance(this);
            _companycode = FieldFactory<System.String>.Factory.Instance(this);
            _contactnumber = FieldFactory<System.String>.Factory.Instance(this);
            _interviewdate = FieldFactory<System.DateTime>.Factory.Instance(this);
            _interviewtime = FieldFactory<System.String>.Factory.Instance(this);
            _position = FieldFactory<System.String>.Factory.Instance(this);
            _regards = FieldFactory<System.String>.Factory.Instance(this);
        }

        #endregion Methods
    }
}