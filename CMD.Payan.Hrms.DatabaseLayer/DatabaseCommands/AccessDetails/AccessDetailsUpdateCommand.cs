using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AccessDetailsUpdateCommand : AccessDetailsInsertCommand
    {
        public AccessDetailsUpdateCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return AccessDetailsQuery.UpdateQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, AccessDetailsEntityDetail.UniqueIdentifier);
            base.MapToDatabase();
        }
    }
}
