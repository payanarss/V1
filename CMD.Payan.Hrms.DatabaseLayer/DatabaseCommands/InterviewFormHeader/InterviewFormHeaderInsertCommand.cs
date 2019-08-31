using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFormHeaderInsertCommand : InsertCommand
    {
        public InterviewFormHeaderInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return InterviewFormHeaderQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@CallDate", GetDbType("System.DateTime"), InterviewFormHeaderEntityDetail.CallDate);
            AddParameters("@CallNo", GetDbType("System.Decimal"), InterviewFormHeaderEntityDetail.CallNo);
            AddParameters("@CandAdd", GetDbType("System.String"), InterviewFormHeaderEntityDetail.CandAdd);
            AddParameters("@CandName", GetDbType("System.String"), InterviewFormHeaderEntityDetail.CandName);
            AddParameters("@EmpName", GetDbType("System.String"), InterviewFormHeaderEntityDetail.EmpName);
            AddParameters("@IntDate", GetDbType("System.DateTime"), InterviewFormHeaderEntityDetail.IntDate);
            AddParameters("@IntNo", GetDbType("System.Int64"), InterviewFormHeaderEntityDetail.IntNo);
            AddParameters("@Post", GetDbType("System.String"), InterviewFormHeaderEntityDetail.Post);
            AddParameters("@Recom", GetDbType("System.String"), InterviewFormHeaderEntityDetail.Recom);
            AddParameters("@Selected", GetDbType("System.Int64"), InterviewFormHeaderEntityDetail.Selected);
            AddParameters("@ToBePost", GetDbType("System.String"), InterviewFormHeaderEntityDetail.ToBePost);

            base.MapToDatabase();
        }

        protected InterviewFormHeaderEntity InterviewFormHeaderEntityDetail
        {
            get { return BusinessEntityDetail as InterviewFormHeaderEntity; }
        }
    }
}
