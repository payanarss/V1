using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class CompanyEntityFactory : BusinessEntityFactory
    {
	#region Private Variables

        private static CompanyEntityFactory _factory = null;

	#endregion Private Variables

	#region Methods

        public static CompanyEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new CompanyEntityFactory();
                }

                return _factory;
            }
        }

        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create()
        {
            return new CompanyEntity();
        }
        
        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create(IParent parent)
        {
            return new CompanyEntity(parent);
        }

	#endregion Methods
    }
}
