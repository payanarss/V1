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
            CallLetterEntityDetail.CallLetterDate = ConvertType.ToDateTime(reader["CallLetterDate"].ToString());
            CallLetterEntityDetail.CallLetterNumber = ConvertType.ToInt64(reader["CallLetterNumber"].ToString());
            CallLetterEntityDetail.CandidateAddress = ConvertType.ToString(reader["CandidateAddress"].ToString());
            CallLetterEntityDetail.CandidateName = ConvertType.ToString(reader["CandidateName"].ToString());
            CallLetterEntityDetail.CompanyCode = ConvertType.ToString(reader["CompanyCode"].ToString());
            CallLetterEntityDetail.ContactNumber = ConvertType.ToString(reader["ContactNumber"].ToString());
            CallLetterEntityDetail.InterviewDate = ConvertType.ToDateTime(reader["InterviewDate"].ToString());
            CallLetterEntityDetail.InterviewTime = ConvertType.ToString(reader["InterviewTime"].ToString());
            CallLetterEntityDetail.Position = ConvertType.ToString(reader["Position"].ToString());
            CallLetterEntityDetail.Regards = ConvertType.ToString(reader["Regards"].ToString());

        }

        private CallLetterEntity CallLetterEntityDetail
        {
            get { return BusinessEntityDetail as CallLetterEntity; }
        }
    }
}
