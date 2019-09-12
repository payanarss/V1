using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class TableInformationDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static TableInformationDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new TableInformationDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new TableInformationDatabaseAgent(businessObjectCollection);
        }

        public static TableInformationDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new TableInformationDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
