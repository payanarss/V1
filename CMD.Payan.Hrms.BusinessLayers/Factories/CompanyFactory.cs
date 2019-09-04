using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class CompanyFactory : BusinessObjectFactory
    {
	#region Variable Declarations

        private static CompanyFactory _factory = null;

	#endregion Variable Declarations

	#region Methods

        public static CompanyFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new CompanyFactory();
                }

                return _factory;
            }
        }


        protected override IBusinessObject Create()
        {
            return new Company();
        }


        protected override IBusinessObject Create(IParent parent)
        {
            return new Company(parent);
        }

	#endregion Methods
    }
}
