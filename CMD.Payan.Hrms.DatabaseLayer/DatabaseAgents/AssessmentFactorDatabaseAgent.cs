using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AssessmentFactorDatabaseAgent : CMD.Payan.Base.DatabaseLayer.Interfaces.DatabaseAgent
    {
        public AssessmentFactorDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new AssessmentFactorInsertCommand(this);
            UpdateCommand = new AssessmentFactorUpdateCommand(this);
            DeleteCommand = new AssessmentFactorDeleteCommand(this);
            SelectCommand = new AssessmentFactorSelectCommand(this, AssessmentFactorQuery.SelectQuery);
        }

        public AssessmentFactorDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new AssessmentFactorSelectCommand(this, AssessmentFactorQuery.SelectAllQuery);
        }
    }
}
