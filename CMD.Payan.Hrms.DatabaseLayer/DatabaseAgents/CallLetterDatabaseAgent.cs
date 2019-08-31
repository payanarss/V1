using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class CallLetterDatabaseAgent : CMD.Payan.Base.DatabaseLayer.Interfaces.DatabaseAgent
    {
        public CallLetterDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new CallLetterInsertCommand(this);
            UpdateCommand = new CallLetterUpdateCommand(this);
            DeleteCommand = new CallLetterDeleteCommand(this);
            SelectCommand = new CallLetterSelectCommand(this, CallLetterQuery.SelectQuery);
        }

        public CallLetterDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new CallLetterSelectCommand(this, CallLetterQuery.SelectAllQuery);
        }
    }
}
