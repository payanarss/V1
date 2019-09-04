using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class EmployeeDetailDeleteCommand : Command
    {
        public EmployeeDetailDeleteCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return EmployeeDetailQuery.DeleteQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, EmployeeDetailEntityDetail.UniqueIdentifier);
	    base.MapToDatabase();
        }

        private EmployeeDetailEntity EmployeeDetailEntityDetail
        {
            get { return BusinessEntityDetail as EmployeeDetailEntity; }
        }
    }
}
