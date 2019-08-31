using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFormDetailsInsertCommand : InsertCommand
    {
        public InterviewFormDetailsInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return InterviewFormDetailsQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
	                AddParameters("@Des", GetDbType("System.String"), InterviewFormDetailsEntityDetail.Des);
            AddParameters("@Grade", GetDbType("System.String"), InterviewFormDetailsEntityDetail.Grade);
            AddParameters("@IntNo", GetDbType("System.Decimal"), InterviewFormDetailsEntityDetail.IntNo);
            AddParameters("@Remarks", GetDbType("System.String"), InterviewFormDetailsEntityDetail.Remarks);
            AddParameters("@Slno", GetDbType("System.Int64"), InterviewFormDetailsEntityDetail.Slno);

            base.MapToDatabase();
        }

        protected InterviewFormDetailsEntity InterviewFormDetailsEntityDetail
        {
            get { return BusinessEntityDetail as InterviewFormDetailsEntity; }
        }
    }
}
