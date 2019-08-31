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
    public class InterviewFormDetailsSelectCommand : SelectCommand
    {
        public InterviewFormDetailsSelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            InterviewFormDetailsEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
            InterviewFormDetailsEntityDetail.Des = ConvertType.ToString(reader["Des"].ToString());
            InterviewFormDetailsEntityDetail.Grade = ConvertType.ToString(reader["Grade"].ToString());
            InterviewFormDetailsEntityDetail.IntNo = ConvertType.ToInt64(reader["IntNo"].ToString());
            InterviewFormDetailsEntityDetail.Remarks = ConvertType.ToString(reader["Remarks"].ToString());
            InterviewFormDetailsEntityDetail.Slno = ConvertType.ToInt64(reader["Slno"].ToString());

        }

        private InterviewFormDetailsEntity InterviewFormDetailsEntityDetail
        {
            get { return BusinessEntityDetail as InterviewFormDetailsEntity; }
        }
    }
}
