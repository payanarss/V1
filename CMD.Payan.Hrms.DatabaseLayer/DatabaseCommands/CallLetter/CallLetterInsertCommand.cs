using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class CallLetterInsertCommand : InsertCommand
    {
        public CallLetterInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return CallLetterQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
	                AddParameters("@CallLetterDate", GetDbType("System.DateTime"), CallLetterEntityDetail.CallLetterDate);
            AddParameters("@CallLetterNumber", GetDbType("System.Int64"), CallLetterEntityDetail.CallLetterNumber);
            AddParameters("@CandidateAddress", GetDbType("System.String"), CallLetterEntityDetail.CandidateAddress);
            AddParameters("@CandidateName", GetDbType("System.String"), CallLetterEntityDetail.CandidateName);
            AddParameters("@CompanyCode", GetDbType("System.String"), CallLetterEntityDetail.CompanyCode);
            AddParameters("@ContactNumber", GetDbType("System.String"), CallLetterEntityDetail.ContactNumber);
            AddParameters("@InterviewDate", GetDbType("System.String"), CallLetterEntityDetail.InterviewDate);
            AddParameters("@InterviewTime", GetDbType("System.String"), CallLetterEntityDetail.InterviewTime);
            AddParameters("@Position", GetDbType("System.String"), CallLetterEntityDetail.Position);
            AddParameters("@Regards", GetDbType("System.String"), CallLetterEntityDetail.Regards);

            base.MapToDatabase();
        }

        protected CallLetterEntity CallLetterEntityDetail
        {
            get { return BusinessEntityDetail as CallLetterEntity; }
        }
    }
}
