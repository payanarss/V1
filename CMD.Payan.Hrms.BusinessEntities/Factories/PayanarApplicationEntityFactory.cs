using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class PayanarApplicationEntityFactory : BusinessEntityFactory
    {
	#region Private Variables

        private static PayanarApplicationEntityFactory _factory = null;

	#endregion Private Variables

	#region Methods

        public static PayanarApplicationEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new PayanarApplicationEntityFactory();
                }

                return _factory;
            }
        }

        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create()
        {
            return new PayanarApplicationEntity();
        }
        
        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create(IParent parent)
        {
            return new PayanarApplicationEntity(parent);
        }

	#endregion Methods
    }
}
