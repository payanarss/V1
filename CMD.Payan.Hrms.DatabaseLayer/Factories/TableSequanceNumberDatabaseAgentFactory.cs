using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class TableSequanceNumberDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static TableSequanceNumberDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new TableSequanceNumberDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new TableSequanceNumberDatabaseAgent(businessObjectCollection);
        }

        public static TableSequanceNumberDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new TableSequanceNumberDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
