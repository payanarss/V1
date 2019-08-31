using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class InterviewFormHeaderEntity : BusinessEntity, IBusinessEntity
    {
        #region Private Variables

        private IField<System.DateTime> _calldate;
        private IField<System.Decimal> _callno;
        private IField<System.String> _candadd;
        private IField<System.String> _candname;
        private IField<System.String> _empname;
        private IField<System.DateTime> _intdate;
        private IField<System.Int64> _intno;
        private IField<System.String> _post;
        private IField<System.String> _recom;
        private IField<System.Int64> _selected;
        private IField<System.String> _tobepost;

        #endregion Private Variables

        #region Constructors

        public InterviewFormHeaderEntity()
            : base()
        {
            InitializeFields();
        }

        public InterviewFormHeaderEntity(IParent parent)
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

        public System.Decimal CallNo
        {
            get { return _callno.Value; }
            set { _callno.Value = value; }
        }

        public System.String CandAdd
        {
            get { return _candadd.Value; }
            set { _candadd.Value = value; }
        }

        public System.String CandName
        {
            get { return _candname.Value; }
            set { _candname.Value = value; }
        }

        public System.String EmpName
        {
            get { return _empname.Value; }
            set { _empname.Value = value; }
        }

        public System.DateTime IntDate
        {
            get { return _intdate.Value; }
            set { _intdate.Value = value; }
        }

        public System.Int64 IntNo
        {
            get { return _intno.Value; }
            set { _intno.Value = value; }
        }

        public System.String Post
        {
            get { return _post.Value; }
            set { _post.Value = value; }
        }

        public System.String Recom
        {
            get { return _recom.Value; }
            set { _recom.Value = value; }
        }

        public System.Int64 Selected
        {
            get { return _selected.Value; }
            set { _selected.Value = value; }
        }

        public System.String ToBePost
        {
            get { return _tobepost.Value; }
            set { _tobepost.Value = value; }
        }

        #endregion Properties

        #region Methods

        private void InitializeFields()
        {
            _calldate = FieldFactory<System.DateTime>.Factory.Instance(this);
            _callno = FieldFactory<System.Decimal>.Factory.Instance(this);
            _candadd = FieldFactory<System.String>.Factory.Instance(this);
            _candname = FieldFactory<System.String>.Factory.Instance(this);
            _empname = FieldFactory<System.String>.Factory.Instance(this);
            _intdate = FieldFactory<System.DateTime>.Factory.Instance(this);
            _intno = FieldFactory<System.Int64>.Factory.Instance(this);
            _post = FieldFactory<System.String>.Factory.Instance(this);
            _recom = FieldFactory<System.String>.Factory.Instance(this);
            _selected = FieldFactory<System.Int64>.Factory.Instance(this);
            _tobepost = FieldFactory<System.String>.Factory.Instance(this);
        }

        #endregion Methods
    }
}