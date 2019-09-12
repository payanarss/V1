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
    public class TableInformationSelectCommand : SelectCommand
    {
        public TableInformationSelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            ////TableInformationEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
            TableInformationEntityDetail.TableName = ConvertType.ToString(reader["TableName"].ToString());
            TableInformationEntityDetail.SequenceNumber = ConvertType.ToInt64(reader["SequenceNumber"].ToString());
            TableInformationEntityDetail.OpeningSequenceNumber = ConvertType.ToInt64(reader["OpeningSequenceNumber"].ToString());

        }

        private TableInformationEntity TableInformationEntityDetail
        {
            get { return BusinessEntityDetail as TableInformationEntity; }
        }
    }
}
