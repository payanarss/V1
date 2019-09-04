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
    public class CompanySelectCommand : SelectCommand
    {
        public CompanySelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            CompanyEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
	                CompanyEntityDetail.CompanyAddress1 = ConvertType.ToString(reader["CompanyAddress1"].ToString());
            CompanyEntityDetail.CompanyAddress2 = ConvertType.ToString(reader["CompanyAddress2"].ToString());
            CompanyEntityDetail.CompanyAddress3 = ConvertType.ToString(reader["CompanyAddress3"].ToString());
            CompanyEntityDetail.CompanyAddress4 = ConvertType.ToString(reader["CompanyAddress4"].ToString());
            CompanyEntityDetail.CompanyName = ConvertType.ToString(reader["CompanyName"].ToString());
            CompanyEntityDetail.CompanyName1 = ConvertType.ToString(reader["CompanyName1"].ToString());
            CompanyEntityDetail.CompanyCode = ConvertType.ToString(reader["CompanyCode"].ToString());

        }

        private CompanyEntity CompanyEntityDetail
        {
            get { return BusinessEntityDetail as CompanyEntity; }
        }
    }
}
