using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class CallLetterEntityFactory : BusinessEntityFactory
    {
	#region Private Variables

        private static CallLetterEntityFactory _factory = null;

	#endregion Private Variables

	#region Methods

        public static CallLetterEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new CallLetterEntityFactory();
                }

                return _factory;
            }
        }

        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create()
        {
            return new CallLetterEntity();
        }
        
        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create(IParent parent)
        {
            return new CallLetterEntity(parent);
        }

	#endregion Methods
    }
}
