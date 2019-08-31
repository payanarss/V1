using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class AccessDetailsFactory : BusinessObjectFactory
    {
	#region Variable Declarations

        private static AccessDetailsFactory _factory = null;

	#endregion Variable Declarations

	#region Methods

        public static AccessDetailsFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new AccessDetailsFactory();
                }

                return _factory;
            }
        }


        protected override IBusinessObject Create()
        {
            return new AccessDetails();
        }


        protected override IBusinessObject Create(IParent parent)
        {
            return new AccessDetails(parent);
        }

	#endregion Methods
    }
}
