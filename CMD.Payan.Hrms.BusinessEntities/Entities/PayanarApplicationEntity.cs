using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class PayanarApplicationEntity : BusinessEntity, IBusinessEntity
    {
        #region Private Variables

	        private IField<System.String> _name;
        private IField<System.String> _title;
        private IField<System.String> _description;

        #endregion Private Variables

        #region Constructors

        public PayanarApplicationEntity()
            : base()
        {
	    InitializeFields();
        }

        public PayanarApplicationEntity(IParent parent)
            : base(parent)
        {
	    InitializeFields();
        }

        #endregion Constructors

        #region Properties
	
        public System.String Name
        {
            get { return _name.Value; }
            set { _name.Value = value; }
        }

        public System.String Title
        {
            get { return _title.Value; }
            set { _title.Value = value; }
        }

        public System.String Description
        {
            get { return _description.Value; }
            set { _description.Value = value; }
        }

        #endregion Properties
	
	#region Methods

	private void InitializeFields()
	{
		            _name = FieldFactory<System.String>.Factory.Instance(this);
            _title = FieldFactory<System.String>.Factory.Instance(this);
            _description = FieldFactory<System.String>.Factory.Instance(this);
		}

	#endregion Methods
    }
}