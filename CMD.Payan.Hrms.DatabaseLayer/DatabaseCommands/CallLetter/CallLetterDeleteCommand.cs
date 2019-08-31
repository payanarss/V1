using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class CallLetterDeleteCommand : Command
    {
        public CallLetterDeleteCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return CallLetterQuery.DeleteQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, CallLetterEntityDetail.UniqueIdentifier);
	    base.MapToDatabase();
        }

        private CallLetterEntity CallLetterEntityDetail
        {
            get { return BusinessEntityDetail as CallLetterEntity; }
        }
    }
}
