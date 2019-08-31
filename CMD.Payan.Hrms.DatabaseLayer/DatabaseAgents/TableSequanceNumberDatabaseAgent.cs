using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class TableSequanceNumberDatabaseAgent : DatabaseAgent
    {
        public TableSequanceNumberDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new TableSequanceNumberInsertCommand(this);
            UpdateCommand = new TableSequanceNumberUpdateCommand(this);
            DeleteCommand = new TableSequanceNumberDeleteCommand(this);
            SelectCommand = new TableSequanceNumberSelectCommand(this, TableSequanceNumberQuery.SelectQuery);
        }

        public TableSequanceNumberDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new TableSequanceNumberSelectCommand(this, TableSequanceNumberQuery.SelectAllQuery);
        }
    }
}
