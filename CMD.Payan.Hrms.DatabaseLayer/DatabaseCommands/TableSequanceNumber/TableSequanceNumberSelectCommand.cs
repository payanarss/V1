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
    public class TableSequanceNumberSelectCommand : SelectCommand
    {
        public TableSequanceNumberSelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            TableSequanceNumberEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
	                TableSequanceNumberEntityDetail.TableName = ConvertType.ToString(reader["TableName"].ToString());
            TableSequanceNumberEntityDetail.SequenceNumber = ConvertType.ToInt64(reader["SequenceNumber"].ToString());
            TableSequanceNumberEntityDetail.NextSequenceNumber = ConvertType.ToInt64(reader["NextSequenceNumber"].ToString());
            TableSequanceNumberEntityDetail.CurrentDate = ConvertType.ToDateTime(reader["CurrentDate"].ToString());

        }

        private TableSequanceNumberEntity TableSequanceNumberEntityDetail
        {
            get { return BusinessEntityDetail as TableSequanceNumberEntity; }
        }
    }
}
