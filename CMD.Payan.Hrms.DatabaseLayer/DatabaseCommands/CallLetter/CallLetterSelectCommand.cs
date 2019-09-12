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
	                CallLetterEntityDetail.CallLetterDate = ConvertType.ToSystem.DateTime(reader["CallLetterDate"].ToString());
            CallLetterEntityDetail.CallLetterNumber = ConvertType.ToSystem.Int64(reader["CallLetterNumber"].ToString());
            CallLetterEntityDetail.CandidateAddress = ConvertType.ToSystem.String(reader["CandidateAddress"].ToString());
            CallLetterEntityDetail.CandidateName = ConvertType.ToSystem.String(reader["CandidateName"].ToString());
            CallLetterEntityDetail.CompanyCode = ConvertType.ToTableSequanceNumber.NextSequenceNumber(reader["CompanyCode"].ToString());
            CallLetterEntityDetail.ContactNumber = ConvertType.ToSystem.String(reader["ContactNumber"].ToString());
            CallLetterEntityDetail.InterviewDate = ConvertType.ToSystem.String(reader["InterviewDate"].ToString());
            CallLetterEntityDetail.InterviewTime = ConvertType.ToSystem.String(reader["InterviewTime"].ToString());
            CallLetterEntityDetail.DesignationCode = ConvertType.ToSystem.String(reader["DesignationCode"].ToString());
            CallLetterEntityDetail.Regards = ConvertType.ToSystem.String(reader["Regards"].ToString());
            CallLetterEntityDetail.UniqueIdentifier = ConvertType.ToSystem.String(reader["UniqueIdentifier"].ToString());
            CallLetterEntityDetail.RowID = ConvertType.ToSystem.String(reader["RowID"].ToString());

        }

        private CallLetterEntity CallLetterEntityDetail
        {
            get { return BusinessEntityDetail as CallLetterEntity; }
        }
    }
}
