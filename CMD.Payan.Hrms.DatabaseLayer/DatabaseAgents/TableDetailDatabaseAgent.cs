using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class TableDetailDatabaseAgent : CMD.Payan.Base.DatabaseLayer.Interfaces.DatabaseAgent
    {
        public TableDetailDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new TableDetailInsertCommand(this);
            UpdateCommand = new TableDetailUpdateCommand(this);
            DeleteCommand = new TableDetailDeleteCommand(this);
            SelectCommand = new TableDetailSelectCommand(this, TableDetailQuery.SelectQuery);
        }

        public TableDetailDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new TableDetailSelectCommand(this, TableDetailQuery.SelectAllQuery);
        }
    }
}
