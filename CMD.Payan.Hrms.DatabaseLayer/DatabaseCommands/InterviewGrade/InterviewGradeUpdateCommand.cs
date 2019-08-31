using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewGradeUpdateCommand : InterviewGradeInsertCommand
    {
        public InterviewGradeUpdateCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return InterviewGradeQuery.UpdateQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, InterviewGradeEntityDetail.UniqueIdentifier);
            base.MapToDatabase();
        }
    }
}
