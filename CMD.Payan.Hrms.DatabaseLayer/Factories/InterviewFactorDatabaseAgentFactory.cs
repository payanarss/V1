using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFactorDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static InterviewFactorDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new InterviewFactorDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new InterviewFactorDatabaseAgent(businessObjectCollection);
        }

        public static InterviewFactorDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new InterviewFactorDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
