using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class EmployeeDetailDatabaseAgent : CMD.Payan.Base.DatabaseLayer.Interfaces.DatabaseAgent
    {
        public EmployeeDetailDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new EmployeeDetailInsertCommand(this);
            UpdateCommand = new EmployeeDetailUpdateCommand(this);
            DeleteCommand = new EmployeeDetailDeleteCommand(this);
            SelectCommand = new EmployeeDetailSelectCommand(this, EmployeeDetailQuery.SelectQuery);
        }

        public EmployeeDetailDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new EmployeeDetailSelectCommand(this, EmployeeDetailQuery.SelectAllQuery);
        }
    }
}
