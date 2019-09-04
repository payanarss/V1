using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class TableDetailDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static TableDetailDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new TableDetailDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new TableDetailDatabaseAgent(businessObjectCollection);
        }

        public static TableDetailDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new TableDetailDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
