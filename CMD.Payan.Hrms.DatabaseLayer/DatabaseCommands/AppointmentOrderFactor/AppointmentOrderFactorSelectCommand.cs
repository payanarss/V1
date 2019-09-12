using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.Common;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AppointmentOrderFactorSelectCommand : SelectCommand
    {
        public AppointmentOrderFactorSelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            AppointmentOrderFactorEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
	                AppointmentOrderFactorEntityDetail.Description = ConvertType.ToSystem.String(reader["Description"].ToString());
            AppointmentOrderFactorEntityDetail.Rejected = ConvertType.ToSystem.Int64(reader["Rejected"].ToString());
            AppointmentOrderFactorEntityDetail.SiNo = ConvertType.ToSystem.Int64(reader["SiNo"].ToString());

        }

        private AppointmentOrderFactorEntity AppointmentOrderFactorEntityDetail
        {
            get { return BusinessEntityDetail as AppointmentOrderFactorEntity; }
        }
    }
}
