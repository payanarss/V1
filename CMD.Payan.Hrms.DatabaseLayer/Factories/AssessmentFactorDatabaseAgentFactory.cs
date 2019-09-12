using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AssessmentFactorDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static AssessmentFactorDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new AssessmentFactorDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new AssessmentFactorDatabaseAgent(businessObjectCollection);
        }

        public static AssessmentFactorDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new AssessmentFactorDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
