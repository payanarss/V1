using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class TableInformationEntityFactory : BusinessEntityFactory
    {
	#region Private Variables

        private static TableInformationEntityFactory _factory = null;

	#endregion Private Variables

	#region Methods

        public static TableInformationEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new TableInformationEntityFactory();
                }

                return _factory;
            }
        }

        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create()
        {
            return new TableInformationEntity();
        }
        
        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create(IParent parent)
        {
            return new TableInformationEntity(parent);
        }

	#endregion Methods
    }
}
