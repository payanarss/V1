using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class TableInformationInsertCommand : InsertCommand
    {
        public TableInformationInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return TableInformationQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
	                AddParameters("@TableName", GetDbType("System.String"), TableInformationEntityDetail.TableName);
            AddParameters("@SequenceNumber", GetDbType("System.Int64"), TableInformationEntityDetail.SequenceNumber);
            AddParameters("@OpeningSequenceNumber", GetDbType("System.Int64"), TableInformationEntityDetail.OpeningSequenceNumber);

            base.MapToDatabase();
        }

        protected TableInformationEntity TableInformationEntityDetail
        {
            get { return BusinessEntityDetail as TableInformationEntity; }
        }
    }
}
