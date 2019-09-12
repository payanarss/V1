using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AppointmentOrderFactorDeleteCommand : Command
    {
        public AppointmentOrderFactorDeleteCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return AppointmentOrderFactorQuery.DeleteQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, AppointmentOrderFactorEntityDetail.UniqueIdentifier);
	    base.MapToDatabase();
        }

        private AppointmentOrderFactorEntity AppointmentOrderFactorEntityDetail
        {
            get { return BusinessEntityDetail as AppointmentOrderFactorEntity; }
        }
    }
}
