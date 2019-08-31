using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFormHeaderDatabaseAgent : DatabaseAgent
    {
        public InterviewFormHeaderDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new InterviewFormHeaderInsertCommand(this);
            UpdateCommand = new InterviewFormHeaderUpdateCommand(this);
            DeleteCommand = new InterviewFormHeaderDeleteCommand(this);
            SelectCommand = new InterviewFormHeaderSelectCommand(this, InterviewFormHeaderQuery.SelectQuery);
        }

        public InterviewFormHeaderDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new InterviewFormHeaderSelectCommand(this, InterviewFormHeaderQuery.SelectAllQuery);
        }
    }
}
