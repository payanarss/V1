using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class TableInformationFactory : BusinessObjectFactory
    {
	#region Variable Declarations

        private static TableInformationFactory _factory = null;

	#endregion Variable Declarations

	#region Methods

        public static TableInformationFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new TableInformationFactory();
                }

                return _factory;
            }
        }


        protected override IBusinessObject Create()
        {
            return new TableInformation();
        }


        protected override IBusinessObject Create(IParent parent)
        {
            return new TableInformation(parent);
        }

	#endregion Methods
    }
}
