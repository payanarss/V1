using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class ExitInterviewFactorDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static ExitInterviewFactorDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new ExitInterviewFactorDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new ExitInterviewFactorDatabaseAgent(businessObjectCollection);
        }

        public static ExitInterviewFactorDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new ExitInterviewFactorDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
