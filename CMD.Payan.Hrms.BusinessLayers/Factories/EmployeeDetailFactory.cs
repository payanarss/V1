using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class EmployeeDetailFactory : BusinessObjectFactory
    {
	#region Variable Declarations

        private static EmployeeDetailFactory _factory = null;

	#endregion Variable Declarations

	#region Methods

        public static EmployeeDetailFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new EmployeeDetailFactory();
                }

                return _factory;
            }
        }


        protected override IBusinessObject Create()
        {
            return new EmployeeDetail();
        }


        protected override IBusinessObject Create(IParent parent)
        {
            return new EmployeeDetail(parent);
        }

	#endregion Methods
    }
}
