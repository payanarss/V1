using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class TableInformationDeleteCommand : Command
    {
        public TableInformationDeleteCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return TableInformationQuery.DeleteQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, TableInformationEntityDetail.UniqueIdentifier);
	    base.MapToDatabase();
        }

        private TableInformationEntity TableInformationEntityDetail
        {
            get { return BusinessEntityDetail as TableInformationEntity; }
        }
    }
}
