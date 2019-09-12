using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class PayanarApplicationDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static PayanarApplicationDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new PayanarApplicationDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new PayanarApplicationDatabaseAgent(businessObjectCollection);
        }

        public static PayanarApplicationDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new PayanarApplicationDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
