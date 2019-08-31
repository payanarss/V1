using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class TableSequanceNumberInsertCommand : InsertCommand
    {
        public TableSequanceNumberInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return TableSequanceNumberQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
	                AddParameters("@TableName", GetDbType("System.String"), TableSequanceNumberEntityDetail.TableName);
            AddParameters("@SequenceNumber", GetDbType("System.Int64"), TableSequanceNumberEntityDetail.SequenceNumber);
            AddParameters("@NextSequenceNumber", GetDbType("System.Int64"), TableSequanceNumberEntityDetail.NextSequenceNumber);
            AddParameters("@CurrentDate", GetDbType("System.DateTime"), TableSequanceNumberEntityDetail.CurrentDate);

            base.MapToDatabase();
        }

        protected TableSequanceNumberEntity TableSequanceNumberEntityDetail
        {
            get { return BusinessEntityDetail as TableSequanceNumberEntity; }
        }
    }
}
