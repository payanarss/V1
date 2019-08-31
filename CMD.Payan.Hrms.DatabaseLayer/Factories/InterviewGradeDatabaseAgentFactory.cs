using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewGradeDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static InterviewGradeDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new InterviewGradeDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new InterviewGradeDatabaseAgent(businessObjectCollection);
        }

        public static InterviewGradeDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new InterviewGradeDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
