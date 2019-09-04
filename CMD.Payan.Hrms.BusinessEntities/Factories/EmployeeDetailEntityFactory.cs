using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class EmployeeDetailEntityFactory : BusinessEntityFactory
    {
	#region Private Variables

        private static EmployeeDetailEntityFactory _factory = null;

	#endregion Private Variables

	#region Methods

        public static EmployeeDetailEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new EmployeeDetailEntityFactory();
                }

                return _factory;
            }
        }

        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create()
        {
            return new EmployeeDetailEntity();
        }
        
        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create(IParent parent)
        {
            return new EmployeeDetailEntity(parent);
        }

	#endregion Methods
    }
}
