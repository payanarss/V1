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
	                AddParameters("@CallDate", GetDbType("System.DateTime"), CallLetterEntityDetail.CallDate);
            AddParameters("@CallNo", GetDbType("System.Int64"), CallLetterEntityDetail.CallNo);
            AddParameters("@CandAdd", GetDbType("System.String"), CallLetterEntityDetail.CandAdd);
            AddParameters("@CandTo", GetDbType("System.String"), CallLetterEntityDetail.CandTo);
            AddParameters("@CompCode", GetDbType("System.String"), CallLetterEntityDetail.CompCode);
            AddParameters("@ContNo", GetDbType("System.String"), CallLetterEntityDetail.ContNo);
            AddParameters("@IntDate", GetDbType("System.String"), CallLetterEntityDetail.IntDate);
            AddParameters("@IntTime", GetDbType("System.String"), CallLetterEntityDetail.IntTime);
            AddParameters("@Pos", GetDbType("System.String"), CallLetterEntityDetail.Pos);
            AddParameters("@Regards", GetDbType("System.String"), CallLetterEntityDetail.Regards);

            base.MapToDatabase();
        }

        protected CallLetterEntity CallLetterEntityDetail
        {
            get { return BusinessEntityDetail as CallLetterEntity; }
        }
    }
}
