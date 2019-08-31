using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFormHeaderUpdateCommand : InterviewFormHeaderInsertCommand
    {
        public InterviewFormHeaderUpdateCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return InterviewFormHeaderQuery.UpdateQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, InterviewFormHeaderEntityDetail.UniqueIdentifier);
            base.MapToDatabase();
        }
    }
}
