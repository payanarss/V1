using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class TableDetailFactory : BusinessObjectFactory
    {
	#region Variable Declarations

        private static TableDetailFactory _factory = null;

	#endregion Variable Declarations

	#region Methods

        public static TableDetailFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new TableDetailFactory();
                }

                return _factory;
            }
        }


        protected override IBusinessObject Create()
        {
            return new TableDetail();
        }


        protected override IBusinessObject Create(IParent parent)
        {
            return new TableDetail(parent);
        }

	#endregion Methods
    }
}
