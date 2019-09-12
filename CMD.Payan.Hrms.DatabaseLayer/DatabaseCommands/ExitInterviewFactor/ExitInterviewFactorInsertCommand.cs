using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class ExitInterviewFactorInsertCommand : InsertCommand
    {
        public ExitInterviewFactorInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return ExitInterviewFactorQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
	                AddParameters("@Description", GetDbType("System.String"), ExitInterviewFactorEntityDetail.Description);
            AddParameters("@Rejected", GetDbType("System.Int64"), ExitInterviewFactorEntityDetail.Rejected);
            AddParameters("@SiNo", GetDbType("System.Int64"), ExitInterviewFactorEntityDetail.SiNo);

            base.MapToDatabase();
        }

        protected ExitInterviewFactorEntity ExitInterviewFactorEntityDetail
        {
            get { return BusinessEntityDetail as ExitInterviewFactorEntity; }
        }
    }
}
