using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class InterviewFormDetailsEntityFactory : BusinessEntityFactory
    {
	#region Private Variables

        private static InterviewFormDetailsEntityFactory _factory = null;

	#endregion Private Variables

	#region Methods

        public static InterviewFormDetailsEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFormDetailsEntityFactory();
                }

                return _factory;
            }
        }

        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create()
        {
            return new InterviewFormDetailsEntity();
        }
        
        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create(IParent parent)
        {
            return new InterviewFormDetailsEntity(parent);
        }

	#endregion Methods
    }
}
