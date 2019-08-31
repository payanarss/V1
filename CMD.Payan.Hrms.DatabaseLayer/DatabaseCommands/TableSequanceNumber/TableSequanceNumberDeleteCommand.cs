using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class TableSequanceNumberDeleteCommand : Command
    {
        public TableSequanceNumberDeleteCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return TableSequanceNumberQuery.DeleteQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, TableSequanceNumberEntityDetail.UniqueIdentifier);
	    base.MapToDatabase();
        }

        private TableSequanceNumberEntity TableSequanceNumberEntityDetail
        {
            get { return BusinessEntityDetail as TableSequanceNumberEntity; }
        }
    }
}
