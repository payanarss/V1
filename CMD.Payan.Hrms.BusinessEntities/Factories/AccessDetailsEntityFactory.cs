using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class AccessDetailsEntityFactory : BusinessEntityFactory
    {
	#region Private Variables

        private static AccessDetailsEntityFactory _factory = null;

	#endregion Private Variables

	#region Methods

        public static AccessDetailsEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new AccessDetailsEntityFactory();
                }

                return _factory;
            }
        }

        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create()
        {
            return new AccessDetailsEntity();
        }
        
        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create(IParent parent)
        {
            return new AccessDetailsEntity(parent);
        }

	#endregion Methods
    }
}
