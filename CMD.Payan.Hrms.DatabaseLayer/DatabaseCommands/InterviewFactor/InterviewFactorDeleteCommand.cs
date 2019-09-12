using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFactorDeleteCommand : Command
    {
        public InterviewFactorDeleteCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return InterviewFactorQuery.DeleteQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, InterviewFactorEntityDetail.UniqueIdentifier);
	    base.MapToDatabase();
        }

        private InterviewFactorEntity InterviewFactorEntityDetail
        {
            get { return BusinessEntityDetail as InterviewFactorEntity; }
        }
    }
}
