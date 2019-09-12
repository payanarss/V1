using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class TableInformationDatabaseAgent : CMD.Payan.Base.DatabaseLayer.Interfaces.DatabaseAgent
    {
        public TableInformationDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new TableInformationInsertCommand(this);
            UpdateCommand = new TableInformationUpdateCommand(this);
            DeleteCommand = new TableInformationDeleteCommand(this);
            SelectCommand = new TableInformationSelectCommand(this, TableInformationQuery.SelectQuery);
        }

        public TableInformationDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new TableInformationSelectCommand(this, TableInformationQuery.SelectAllQuery);
        }
    }
}
