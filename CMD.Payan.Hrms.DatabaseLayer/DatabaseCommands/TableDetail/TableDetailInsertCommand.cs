using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class TableDetailInsertCommand : InsertCommand
    {
        public TableDetailInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return TableDetailQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
	                AddParameters("@TableName", GetDbType("System.String"), TableDetailEntityDetail.TableName);
            AddParameters("@SequenceNumber", GetDbType("System.Int64"), TableDetailEntityDetail.SequenceNumber);
            AddParameters("@NextSequenceNumber", GetDbType("System.Int64"), TableDetailEntityDetail.NextSequenceNumber);
            AddParameters("@CurrentDate", GetDbType("System.DateTime"), TableDetailEntityDetail.CurrentDate);

            base.MapToDatabase();
        }

        protected TableDetailEntity TableDetailEntityDetail
        {
            get { return BusinessEntityDetail as TableDetailEntity; }
        }
    }
}
