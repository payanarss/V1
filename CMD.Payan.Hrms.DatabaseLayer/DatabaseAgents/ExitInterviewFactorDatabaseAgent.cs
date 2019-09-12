using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class ExitInterviewFactorDatabaseAgent : CMD.Payan.Base.DatabaseLayer.Interfaces.DatabaseAgent
    {
        public ExitInterviewFactorDatabaseAgent(IBusinessObject businessObject)
            : base(businessObject)
        {
            InsertCommand = new ExitInterviewFactorInsertCommand(this);
            UpdateCommand = new ExitInterviewFactorUpdateCommand(this);
            DeleteCommand = new ExitInterviewFactorDeleteCommand(this);
            SelectCommand = new ExitInterviewFactorSelectCommand(this, ExitInterviewFactorQuery.SelectQuery);
        }

        public ExitInterviewFactorDatabaseAgent(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
            SelectAllCommand = new ExitInterviewFactorSelectCommand(this, ExitInterviewFactorQuery.SelectAllQuery);
        }
    }
}
