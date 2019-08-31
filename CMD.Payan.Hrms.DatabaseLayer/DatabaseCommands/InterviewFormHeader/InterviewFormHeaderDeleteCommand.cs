using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFormHeaderDeleteCommand : Command
    {
        public InterviewFormHeaderDeleteCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return InterviewFormHeaderQuery.DeleteQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, InterviewFormHeaderEntityDetail.UniqueIdentifier);
	    base.MapToDatabase();
        }

        private InterviewFormHeaderEntity InterviewFormHeaderEntityDetail
        {
            get { return BusinessEntityDetail as InterviewFormHeaderEntity; }
        }
    }
}
