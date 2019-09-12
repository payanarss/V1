using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class PayanarApplicationDeleteCommand : Command
    {
        public PayanarApplicationDeleteCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return PayanarApplicationQuery.DeleteQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, PayanarApplicationEntityDetail.UniqueIdentifier);
	    base.MapToDatabase();
        }

        private PayanarApplicationEntity PayanarApplicationEntityDetail
        {
            get { return BusinessEntityDetail as PayanarApplicationEntity; }
        }
    }
}
