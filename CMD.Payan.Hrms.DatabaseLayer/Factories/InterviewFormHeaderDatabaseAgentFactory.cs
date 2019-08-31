using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFormHeaderDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static InterviewFormHeaderDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new InterviewFormHeaderDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new InterviewFormHeaderDatabaseAgent(businessObjectCollection);
        }

        public static InterviewFormHeaderDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new InterviewFormHeaderDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
