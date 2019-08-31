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
            ////CallLetterEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
            CallLetterEntityDetail.CallDate = ConvertType.ToDateTime(reader["CallDate"].ToString());
            CallLetterEntityDetail.CallNo = ConvertType.ToInt64(reader["CallNo"].ToString());
            CallLetterEntityDetail.CandAdd = ConvertType.ToString(reader["CandAdd"].ToString());
            CallLetterEntityDetail.CandTo = ConvertType.ToString(reader["CandTo"].ToString());
            CallLetterEntityDetail.CompCode = ConvertType.ToString(reader["CompCode"].ToString());
            CallLetterEntityDetail.ContNo = ConvertType.ToString(reader["ContNo"].ToString());
            CallLetterEntityDetail.IntDate = ConvertType.ToString(reader["IntDate"].ToString());
            CallLetterEntityDetail.IntTime = ConvertType.ToString(reader["IntTime"].ToString());
            CallLetterEntityDetail.Pos = ConvertType.ToString(reader["Pos"].ToString());
            CallLetterEntityDetail.Regards = ConvertType.ToString(reader["Regards"].ToString());

        }

        private CallLetterEntity CallLetterEntityDetail
        {
            get { return BusinessEntityDetail as CallLetterEntity; }
        }
    }
}
