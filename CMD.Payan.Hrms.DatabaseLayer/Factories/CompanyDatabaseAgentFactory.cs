using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class CompanyDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static CompanyDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new CompanyDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new CompanyDatabaseAgent(businessObjectCollection);
        }

        public static CompanyDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new CompanyDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
