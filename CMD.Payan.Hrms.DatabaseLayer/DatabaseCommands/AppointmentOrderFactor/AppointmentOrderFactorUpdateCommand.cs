using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AppointmentOrderFactorUpdateCommand : AppointmentOrderFactorInsertCommand
    {
        public AppointmentOrderFactorUpdateCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return AppointmentOrderFactorQuery.UpdateQuery;
        }

        protected override void MapToDatabase()
        {
            AddParameters("@UniqueIdentifier", DbType.Int64, AppointmentOrderFactorEntityDetail.UniqueIdentifier);
            base.MapToDatabase();
        }
    }
}
