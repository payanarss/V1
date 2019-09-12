using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AssessmentFactorDeleteCommand : Command
    {
        public AssessmentFactorDeleteCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return AssessmentFactorQuery.DeleteQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, AssessmentFactorEntityDetail.UniqueIdentifier);
	    base.MapToDatabase();
        }

        private AssessmentFactorEntity AssessmentFactorEntityDetail
        {
            get { return BusinessEntityDetail as AssessmentFactorEntity; }
        }
    }
}
