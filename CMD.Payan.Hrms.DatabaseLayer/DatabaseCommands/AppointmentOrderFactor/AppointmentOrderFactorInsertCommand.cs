using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AppointmentOrderFactorInsertCommand : InsertCommand
    {
        public AppointmentOrderFactorInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return AppointmentOrderFactorQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
	                AddParameters("@Description", GetDbType("System.String"), AppointmentOrderFactorEntityDetail.Description);
            AddParameters("@Rejected", GetDbType("System.Int64"), AppointmentOrderFactorEntityDetail.Rejected);
            AddParameters("@SiNo", GetDbType("System.Int64"), AppointmentOrderFactorEntityDetail.SiNo);

            base.MapToDatabase();
        }

        protected AppointmentOrderFactorEntity AppointmentOrderFactorEntityDetail
        {
            get { return BusinessEntityDetail as AppointmentOrderFactorEntity; }
        }
    }
}
