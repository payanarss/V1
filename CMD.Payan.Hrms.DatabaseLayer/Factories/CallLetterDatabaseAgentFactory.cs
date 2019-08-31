using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class CallLetterDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static CallLetterDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new CallLetterDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new CallLetterDatabaseAgent(businessObjectCollection);
        }

        public static CallLetterDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new CallLetterDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
