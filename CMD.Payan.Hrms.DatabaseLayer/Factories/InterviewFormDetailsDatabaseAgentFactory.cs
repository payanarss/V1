using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFormDetailsDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static InterviewFormDetailsDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new InterviewFormDetailsDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new InterviewFormDetailsDatabaseAgent(businessObjectCollection);
        }

        public static InterviewFormDetailsDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new InterviewFormDetailsDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
