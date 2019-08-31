using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AccessDetailsDatabaseAgent : DatabaseAgent
    {
        public AccessDetailsDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new AccessDetailsInsertCommand(this);
            UpdateCommand = new AccessDetailsUpdateCommand(this);
            DeleteCommand = new AccessDetailsDeleteCommand(this);
            SelectCommand = new AccessDetailsSelectCommand(this, AccessDetailsQuery.SelectQuery);
        }

        public AccessDetailsDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new AccessDetailsSelectCommand(this, AccessDetailsQuery.SelectAllQuery);
        }
    }
}
