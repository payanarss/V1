using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class PayanarApplicationDatabaseAgent : CMD.Payan.Base.DatabaseLayer.Interfaces.DatabaseAgent
    {
        public PayanarApplicationDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new PayanarApplicationInsertCommand(this);
            UpdateCommand = new PayanarApplicationUpdateCommand(this);
            DeleteCommand = new PayanarApplicationDeleteCommand(this);
            SelectCommand = new PayanarApplicationSelectCommand(this, PayanarApplicationQuery.SelectQuery);
        }

        public PayanarApplicationDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new PayanarApplicationSelectCommand(this, PayanarApplicationQuery.SelectAllQuery);
        }
    }
}
