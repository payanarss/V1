using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewGradeDatabaseAgent : DatabaseAgent
    {
        public InterviewGradeDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new InterviewGradeInsertCommand(this);
            UpdateCommand = new InterviewGradeUpdateCommand(this);
            DeleteCommand = new InterviewGradeDeleteCommand(this);
            SelectCommand = new InterviewGradeSelectCommand(this, InterviewGradeQuery.SelectQuery);
        }

        public InterviewGradeDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new InterviewGradeSelectCommand(this, InterviewGradeQuery.SelectAllQuery);
        }
    }
}
