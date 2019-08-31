using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class InterviewFormHeaderEntityFactory : BusinessEntityFactory
    {
	#region Private Variables

        private static InterviewFormHeaderEntityFactory _factory = null;

	#endregion Private Variables

	#region Methods

        public static InterviewFormHeaderEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFormHeaderEntityFactory();
                }

                return _factory;
            }
        }

        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create()
        {
            return new InterviewFormHeaderEntity();
        }
        
        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create(IParent parent)
        {
            return new InterviewFormHeaderEntity(parent);
        }

	#endregion Methods
    }
}
