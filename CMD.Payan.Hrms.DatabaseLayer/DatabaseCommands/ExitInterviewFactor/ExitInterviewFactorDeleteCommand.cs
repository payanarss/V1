using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class ExitInterviewFactorDeleteCommand : Command
    {
        public ExitInterviewFactorDeleteCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return ExitInterviewFactorQuery.DeleteQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, ExitInterviewFactorEntityDetail.UniqueIdentifier);
	    base.MapToDatabase();
        }

        private ExitInterviewFactorEntity ExitInterviewFactorEntityDetail
        {
            get { return BusinessEntityDetail as ExitInterviewFactorEntity; }
        }
    }
}
