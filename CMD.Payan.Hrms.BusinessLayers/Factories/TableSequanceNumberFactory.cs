using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class TableSequanceNumberFactory : BusinessObjectFactory
    {
	#region Variable Declarations

        private static TableSequanceNumberFactory _factory = null;

	#endregion Variable Declarations

	#region Methods

        public static TableSequanceNumberFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new TableSequanceNumberFactory();
                }

                return _factory;
            }
        }


        protected override IBusinessObject Create()
        {
            return new TableSequanceNumber();
        }


        protected override IBusinessObject Create(IParent parent)
        {
            return new TableSequanceNumber(parent);
        }

	#endregion Methods
    }
}
