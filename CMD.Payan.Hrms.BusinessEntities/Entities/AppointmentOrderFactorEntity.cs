using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayanarCommon = Payanar.SS.Net.Libraries.Common;
using BusinessEntityInterfaces = CMD.Payan.Net.Base.BusinessEntity.Interfaces;
using BaseCommon = CMD.Payan.Net.Base.Common;

namespace CMD.Payan.Net.Hrms.BusinessEntities
{
    public class AppointmentOrderFactorEntity : BusinessEntityInterfaces.BusinessEntity
    {
        #region Private Variables

	        private IField<System.String> _description;
        private IField<System.Int64> _rejected;
        private IField<System.Int64> _sino;

        #endregion Private Variables

        #region Constructors

        public AppointmentOrderFactorEntity()
            : base()
        {
	    InitializeFields();
        }

        public AppointmentOrderFactorEntity(PayanarCommon.IParent parent)
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
		            _description = FieldFactory<System.String>.Factory.Instance(this);
            _rejected = FieldFactory<System.Int64>.Factory.Instance(this);
            _sino = FieldFactory<System.Int64>.Factory.Instance(this);
		
        }

	#endregion Methods
    }
}
