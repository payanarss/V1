using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFormDetailsDatabaseAgent : DatabaseAgent
    {
        public InterviewFormDetailsDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new InterviewFormDetailsInsertCommand(this);
            UpdateCommand = new InterviewFormDetailsUpdateCommand(this);
            DeleteCommand = new InterviewFormDetailsDeleteCommand(this);
            SelectCommand = new InterviewFormDetailsSelectCommand(this, InterviewFormDetailsQuery.SelectQuery);
        }

        public InterviewFormDetailsDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new InterviewFormDetailsSelectCommand(this, InterviewFormDetailsQuery.SelectAllQuery);
        }
    }
}
