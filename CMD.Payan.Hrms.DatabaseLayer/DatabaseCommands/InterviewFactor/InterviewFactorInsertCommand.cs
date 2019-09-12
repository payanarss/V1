using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFactorInsertCommand : InsertCommand
    {
        public InterviewFactorInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return InterviewFactorQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
	                AddParameters("@Description", GetDbType("System.String"), InterviewFactorEntityDetail.Description);
            AddParameters("@IsRejected", GetDbType("System.Int64"), InterviewFactorEntityDetail.IsRejected);
            AddParameters("@SlNo", GetDbType("System.Int64"), InterviewFactorEntityDetail.SlNo);

            base.MapToDatabase();
        }

        protected InterviewFactorEntity InterviewFactorEntityDetail
        {
            get { return BusinessEntityDetail as InterviewFactorEntity; }
        }
    }
}
