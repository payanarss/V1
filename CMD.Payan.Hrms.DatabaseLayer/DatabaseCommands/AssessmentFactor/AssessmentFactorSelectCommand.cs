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
    public class AssessmentFactorSelectCommand : SelectCommand
    {
        public AssessmentFactorSelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            AssessmentFactorEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
	                AssessmentFactorEntityDetail.Description = ConvertType.ToSystem.String(reader["Description"].ToString());
            AssessmentFactorEntityDetail.Rejected = ConvertType.ToSystem.Int64(reader["Rejected"].ToString());
            AssessmentFactorEntityDetail.SiNo = ConvertType.ToSystem.Int64(reader["SiNo"].ToString());

        }

        private AssessmentFactorEntity AssessmentFactorEntityDetail
        {
            get { return BusinessEntityDetail as AssessmentFactorEntity; }
        }
    }
}
