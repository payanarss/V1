using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class EmployeeDetailDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static EmployeeDetailDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new EmployeeDetailDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new EmployeeDetailDatabaseAgent(businessObjectCollection);
        }

        public static EmployeeDetailDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new EmployeeDetailDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
