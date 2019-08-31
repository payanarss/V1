using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AccessDetailsDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static AccessDetailsDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new AccessDetailsDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new AccessDetailsDatabaseAgent(businessObjectCollection);
        }

        public static AccessDetailsDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new AccessDetailsDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
