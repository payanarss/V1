using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFormDetailsDeleteCommand : Command
    {
        public InterviewFormDetailsDeleteCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return InterviewFormDetailsQuery.DeleteQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, InterviewFormDetailsEntityDetail.UniqueIdentifier);
	    base.MapToDatabase();
        }

        private InterviewFormDetailsEntity InterviewFormDetailsEntityDetail
        {
            get { return BusinessEntityDetail as InterviewFormDetailsEntity; }
        }
    }
}
