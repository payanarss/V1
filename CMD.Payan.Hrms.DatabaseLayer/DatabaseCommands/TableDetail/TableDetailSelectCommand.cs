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
    public class TableDetailSelectCommand : SelectCommand
    {
        public TableDetailSelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            TableDetailEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
	                TableDetailEntityDetail.TableName = ConvertType.ToString(reader["TableName"].ToString());
            TableDetailEntityDetail.SequenceNumber = ConvertType.ToInt64(reader["SequenceNumber"].ToString());
            TableDetailEntityDetail.NextSequenceNumber = ConvertType.ToInt64(reader["NextSequenceNumber"].ToString());
            TableDetailEntityDetail.CurrentDate = ConvertType.ToDateTime(reader["CurrentDate"].ToString());

        }

        private TableDetailEntity TableDetailEntityDetail
        {
            get { return BusinessEntityDetail as TableDetailEntity; }
        }
    }
}
