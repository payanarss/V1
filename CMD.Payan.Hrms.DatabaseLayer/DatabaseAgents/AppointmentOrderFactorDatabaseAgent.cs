using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AppointmentOrderFactorDatabaseAgent : CMD.Payan.Base.DatabaseLayer.Interfaces.DatabaseAgent
    {
        public AppointmentOrderFactorDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new AppointmentOrderFactorInsertCommand(this);
            UpdateCommand = new AppointmentOrderFactorUpdateCommand(this);
            DeleteCommand = new AppointmentOrderFactorDeleteCommand(this);
            SelectCommand = new AppointmentOrderFactorSelectCommand(this, AppointmentOrderFactorQuery.SelectQuery);
        }

        public AppointmentOrderFactorDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new AppointmentOrderFactorSelectCommand(this, AppointmentOrderFactorQuery.SelectAllQuery);
        }
    }
}
