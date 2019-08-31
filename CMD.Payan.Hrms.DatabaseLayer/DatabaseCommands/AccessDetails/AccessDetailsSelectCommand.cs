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
    public class AccessDetailsSelectCommand : SelectCommand
    {
        public AccessDetailsSelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            AccessDetailsEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
	                AccessDetailsEntityDetail.AccDate = ConvertType.ToString(reader["AccDate"].ToString());
            AccessDetailsEntityDetail.AccTime = ConvertType.ToDecimal(reader["AccTime"].ToString());
            AccessDetailsEntityDetail.DoorNo = ConvertType.ToString(reader["DoorNo"].ToString());
            AccessDetailsEntityDetail.EmpCode = ConvertType.ToString(reader["EmpCode"].ToString());
            AccessDetailsEntityDetail.EmpName = ConvertType.ToString(reader["EmpName"].ToString());
            AccessDetailsEntityDetail.Empno = ConvertType.ToString(reader["Empno"].ToString());
            AccessDetailsEntityDetail.Flg = ConvertType.ToString(reader["Flg"].ToString());
            AccessDetailsEntityDetail.RNo = ConvertType.ToInt64(reader["RNo"].ToString());
            AccessDetailsEntityDetail.Status = ConvertType.ToString(reader["Status"].ToString());

        }

        private AccessDetailsEntity AccessDetailsEntityDetail
        {
            get { return BusinessEntityDetail as AccessDetailsEntity; }
        }
    }
}
