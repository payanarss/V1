using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class PayanarApplicationInsertCommand : InsertCommand
    {
        public PayanarApplicationInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return PayanarApplicationQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
	                AddParameters("@Name", GetDbType("System.String"), PayanarApplicationEntityDetail.Name);
            AddParameters("@Title", GetDbType("System.String"), PayanarApplicationEntityDetail.Title);
            AddParameters("@Description", GetDbType("System.String"), PayanarApplicationEntityDetail.Description);

            base.MapToDatabase();
        }

        protected PayanarApplicationEntity PayanarApplicationEntityDetail
        {
            get { return BusinessEntityDetail as PayanarApplicationEntity; }
        }
    }
}
