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
    public class InterviewGradeSelectCommand : SelectCommand
    {
        public InterviewGradeSelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            InterviewGradeEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
	                InterviewGradeEntityDetail.Code = ConvertType.ToString(reader["Code"].ToString());
            InterviewGradeEntityDetail.Description = ConvertType.ToString(reader["Description"].ToString());

        }

        private InterviewGradeEntity InterviewGradeEntityDetail
        {
            get { return BusinessEntityDetail as InterviewGradeEntity; }
        }
    }
}
