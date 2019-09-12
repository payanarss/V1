using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class InterviewFactorEntityFactory : BusinessEntityFactory
    {
	#region Private Variables

        private static InterviewFactorEntityFactory _factory = null;

	#endregion Private Variables

	#region Methods

        public static InterviewFactorEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFactorEntityFactory();
                }

                return _factory;
            }
        }

        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create()
        {
            return new InterviewFactorEntity();
        }
        
        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create(IParent parent)
        {
            return new InterviewFactorEntity(parent);
        }

	#endregion Methods
    }
}
