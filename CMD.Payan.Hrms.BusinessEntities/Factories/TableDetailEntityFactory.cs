using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class TableDetailEntityFactory : BusinessEntityFactory
    {
	#region Private Variables

        private static TableDetailEntityFactory _factory = null;

	#endregion Private Variables

	#region Methods

        public static TableDetailEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new TableDetailEntityFactory();
                }

                return _factory;
            }
        }

        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create()
        {
            return new TableDetailEntity();
        }
        
        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create(IParent parent)
        {
            return new TableDetailEntity(parent);
        }

	#endregion Methods
    }
}
