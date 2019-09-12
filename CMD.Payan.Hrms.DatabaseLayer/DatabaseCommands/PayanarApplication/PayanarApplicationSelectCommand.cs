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
    public class PayanarApplicationSelectCommand : SelectCommand
    {
        public PayanarApplicationSelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            PayanarApplicationEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
	                PayanarApplicationEntityDetail.Name = ConvertType.ToString(reader["Name"].ToString());
            PayanarApplicationEntityDetail.Title = ConvertType.ToString(reader["Title"].ToString());
            PayanarApplicationEntityDetail.Description = ConvertType.ToString(reader["Description"].ToString());

        }

        private PayanarApplicationEntity PayanarApplicationEntityDetail
        {
            get { return BusinessEntityDetail as PayanarApplicationEntity; }
        }
    }
}
