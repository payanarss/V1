using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AssessmentFactorInsertCommand : InsertCommand
    {
        public AssessmentFactorInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return AssessmentFactorQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
	                AddParameters("@Description", GetDbType("System.String"), AssessmentFactorEntityDetail.Description);
            AddParameters("@Rejected", GetDbType("System.Int64"), AssessmentFactorEntityDetail.Rejected);
            AddParameters("@SiNo", GetDbType("System.Int64"), AssessmentFactorEntityDetail.SiNo);

            base.MapToDatabase();
        }

        protected AssessmentFactorEntity AssessmentFactorEntityDetail
        {
            get { return BusinessEntityDetail as AssessmentFactorEntity; }
        }
    }
}
