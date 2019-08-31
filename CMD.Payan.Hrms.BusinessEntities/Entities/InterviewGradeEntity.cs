using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class InterviewGradeEntity : BusinessEntity, IBusinessEntity
    {
        #region Private Variables

	        private IField<System.String> _code;
        private IField<System.String> _description;

        #endregion Private Variables

        #region Constructors

        public InterviewGradeEntity()
            : base()
        {
	    InitializeFields();
        }

        public InterviewGradeEntity(IParent parent)
            : base(parent)
        {
	    InitializeFields();
        }

        #endregion Constructors

        #region Properties
	
        public System.String Code
        {
            get { return _code.Value; }
            set { _code.Value = value; }
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
		            _code = FieldFactory<System.String>.Factory.Instance(this);
            _description = FieldFactory<System.String>.Factory.Instance(this);
		}

	#endregion Methods
    }
}