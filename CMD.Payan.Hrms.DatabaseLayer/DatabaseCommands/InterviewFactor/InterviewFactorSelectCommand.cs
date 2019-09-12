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
    public class InterviewFactorSelectCommand : SelectCommand
    {
        public InterviewFactorSelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            InterviewFactorEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
	                InterviewFactorEntityDetail.Description = ConvertType.ToSystem.String(reader["Description"].ToString());
            InterviewFactorEntityDetail.IsRejected = ConvertType.ToSystem.Int64(reader["IsRejected"].ToString());
            InterviewFactorEntityDetail.SlNo = ConvertType.ToSystem.Int64(reader["SlNo"].ToString());

        }

        private InterviewFactorEntity InterviewFactorEntityDetail
        {
            get { return BusinessEntityDetail as InterviewFactorEntity; }
        }
    }
}
