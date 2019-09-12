using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AppointmentOrderFactorDatabaseAgentFactory : DatabaseAgentFactory
    {
        private static AppointmentOrderFactorDatabaseAgentFactory _factory = null;

        protected override IDatabaseAgent Create(IBusinessObject businessObject)
        {
            return new AppointmentOrderFactorDatabaseAgent(businessObject);
        }

        protected override IDatabaseAgent Create(IBusinessObjectCollection businessObjectCollection)
        {
            return new AppointmentOrderFactorDatabaseAgent(businessObjectCollection);
        }

        public static AppointmentOrderFactorDatabaseAgentFactory Factory
        {
            get
            {
                _factory = _factory == null ? new AppointmentOrderFactorDatabaseAgentFactory() : _factory;
                return _factory;
            }
        }
    }
}
