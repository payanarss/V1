using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class CompanyDatabaseAgent : CMD.Payan.Base.DatabaseLayer.Interfaces.DatabaseAgent
    {
        public CompanyDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new CompanyInsertCommand(this);
            UpdateCommand = new CompanyUpdateCommand(this);
            DeleteCommand = new CompanyDeleteCommand(this);
            SelectCommand = new CompanySelectCommand(this, CompanyQuery.SelectQuery);
        }

        public CompanyDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new CompanySelectCommand(this, CompanyQuery.SelectAllQuery);
        }
    }
}
