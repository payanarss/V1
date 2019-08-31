using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class InterviewGradeEntityFactory : BusinessEntityFactory
    {
	#region Private Variables

        private static InterviewGradeEntityFactory _factory = null;

	#endregion Private Variables

	#region Methods

        public static InterviewGradeEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewGradeEntityFactory();
                }

                return _factory;
            }
        }

        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create()
        {
            return new InterviewGradeEntity();
        }
        
        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create(IParent parent)
        {
            return new InterviewGradeEntity(parent);
        }

	#endregion Methods
    }
}
