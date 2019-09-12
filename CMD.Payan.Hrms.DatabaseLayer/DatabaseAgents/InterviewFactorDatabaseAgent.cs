using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFactorDatabaseAgent : CMD.Payan.Base.DatabaseLayer.Interfaces.DatabaseAgent
    {
        public InterviewFactorDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new InterviewFactorInsertCommand(this);
            UpdateCommand = new InterviewFactorUpdateCommand(this);
            DeleteCommand = new InterviewFactorDeleteCommand(this);
            SelectCommand = new InterviewFactorSelectCommand(this, InterviewFactorQuery.SelectQuery);
        }

        public InterviewFactorDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new InterviewFactorSelectCommand(this, InterviewFactorQuery.SelectAllQuery);
        }
    }
}
