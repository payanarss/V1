using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewGradeDeleteCommand : Command
    {
        public InterviewGradeDeleteCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return InterviewGradeQuery.DeleteQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, InterviewGradeEntityDetail.UniqueIdentifier);
	    base.MapToDatabase();
        }

        private InterviewGradeEntity InterviewGradeEntityDetail
        {
            get { return BusinessEntityDetail as InterviewGradeEntity; }
        }
    }
}
