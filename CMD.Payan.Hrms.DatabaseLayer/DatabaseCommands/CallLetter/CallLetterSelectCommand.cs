using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.Common;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class CallLetterSelectCommand : SelectCommand
    {
        public CallLetterSelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            CallLetterEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
	                CallLetterEntityDetail.CallDate = ConvertType.ToSystem.DateTime(reader["CallDate"].ToString());
            CallLetterEntityDetail.CallNo = ConvertType.ToSystem.Int64(reader["CallNo"].ToString());
            CallLetterEntityDetail.CandAdd = ConvertType.ToSystem.String(reader["CandAdd"].ToString());
            CallLetterEntityDetail.CandTo = ConvertType.ToSystem.String(reader["CandTo"].ToString());
            CallLetterEntityDetail.CompCode = ConvertType.ToSystem.String(reader["CompCode"].ToString());
            CallLetterEntityDetail.ContNo = ConvertType.ToSystem.String(reader["ContNo"].ToString());
            CallLetterEntityDetail.IntDate = ConvertType.ToSystem.String(reader["IntDate"].ToString());
            CallLetterEntityDetail.IntTime = ConvertType.ToSystem.String(reader["IntTime"].ToString());
            CallLetterEntityDetail.Pos = ConvertType.ToSystem.String(reader["Pos"].ToString());
            CallLetterEntityDetail.Regards = ConvertType.ToSystem.String(reader["Regards"].ToString());

        }

        private CallLetterEntity CallLetterEntityDetail
        {
            get { return BusinessEntityDetail as CallLetterEntity; }
        }
    }
}
