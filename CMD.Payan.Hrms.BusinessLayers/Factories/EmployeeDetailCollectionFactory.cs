using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class EmployeeDetailCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static EmployeeDetailCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new EmployeeDetailCollection();
        }

        public static EmployeeDetailCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new EmployeeDetailCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
