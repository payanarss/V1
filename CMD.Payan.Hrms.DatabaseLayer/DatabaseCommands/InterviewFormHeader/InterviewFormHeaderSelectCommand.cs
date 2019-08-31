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
    public class InterviewFormHeaderSelectCommand : SelectCommand
    {
        public InterviewFormHeaderSelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            InterviewFormHeaderEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
            InterviewFormHeaderEntityDetail.CallDate = ConvertType.ToDateTime(reader["CallDate"].ToString());
            InterviewFormHeaderEntityDetail.CallNo = ConvertType.ToInt64(reader["CallNo"].ToString());
            InterviewFormHeaderEntityDetail.CandAdd = ConvertType.ToString(reader["CandAdd"].ToString());
            InterviewFormHeaderEntityDetail.CandName = ConvertType.ToString(reader["CandName"].ToString());
            InterviewFormHeaderEntityDetail.EmpName = ConvertType.ToString(reader["EmpName"].ToString());
            InterviewFormHeaderEntityDetail.IntDate = ConvertType.ToDateTime(reader["IntDate"].ToString());
            InterviewFormHeaderEntityDetail.IntNo = ConvertType.ToInt64(reader["IntNo"].ToString());
            InterviewFormHeaderEntityDetail.Post = ConvertType.ToString(reader["Post"].ToString());
            InterviewFormHeaderEntityDetail.Recom = ConvertType.ToString(reader["Recom"].ToString());
            InterviewFormHeaderEntityDetail.Selected = ConvertType.ToInt64(reader["Selected"].ToString());
            InterviewFormHeaderEntityDetail.ToBePost = ConvertType.ToString(reader["ToBePost"].ToString());
        }

        private InterviewFormHeaderEntity InterviewFormHeaderEntityDetail
        {
            get { return BusinessEntityDetail as InterviewFormHeaderEntity; }
        }
    }
}
