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
    public class ExitInterviewFactorSelectCommand : SelectCommand
    {
        public ExitInterviewFactorSelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            ExitInterviewFactorEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
	                ExitInterviewFactorEntityDetail.Description = ConvertType.ToSystem.String(reader["Description"].ToString());
            ExitInterviewFactorEntityDetail.Rejected = ConvertType.ToSystem.Int64(reader["Rejected"].ToString());
            ExitInterviewFactorEntityDetail.SiNo = ConvertType.ToSystem.Int64(reader["SiNo"].ToString());

        }

        private ExitInterviewFactorEntity ExitInterviewFactorEntityDetail
        {
            get { return BusinessEntityDetail as ExitInterviewFactorEntity; }
        }
    }
}
