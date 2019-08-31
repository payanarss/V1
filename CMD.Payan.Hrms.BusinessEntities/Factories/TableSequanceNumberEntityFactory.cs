using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class TableSequanceNumberEntityFactory : BusinessEntityFactory
    {
	#region Private Variables

        private static TableSequanceNumberEntityFactory _factory = null;

	#endregion Private Variables

	#region Methods

        public static TableSequanceNumberEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new TableSequanceNumberEntityFactory();
                }

                return _factory;
            }
        }

        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create()
        {
            return new TableSequanceNumberEntity();
        }
        
        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create(IParent parent)
        {
            return new TableSequanceNumberEntity(parent);
        }

	#endregion Methods
    }
}
