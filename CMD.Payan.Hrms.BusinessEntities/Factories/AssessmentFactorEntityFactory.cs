using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class AssessmentFactorEntityFactory : BusinessEntityFactory
    {
	#region Private Variables

        private static AssessmentFactorEntityFactory _factory = null;

	#endregion Private Variables

	#region Methods

        public static AssessmentFactorEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new AssessmentFactorEntityFactory();
                }

                return _factory;
            }
        }

        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create()
        {
            return new AssessmentFactorEntity();
        }
        
        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create(IParent parent)
        {
            return new AssessmentFactorEntity(parent);
        }

	#endregion Methods
    }
}
