using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AccessDetailsInsertCommand : InsertCommand
    {
        public AccessDetailsInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return AccessDetailsQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
	                AddParameters("@AccDate", GetDbType("System.String"), AccessDetailsEntityDetail.AccDate);
            AddParameters("@AccTime", GetDbType("System.Decimal"), AccessDetailsEntityDetail.AccTime);
            AddParameters("@DoorNo", GetDbType("System.String"), AccessDetailsEntityDetail.DoorNo);
            AddParameters("@EmpCode", GetDbType("System.String"), AccessDetailsEntityDetail.EmpCode);
            AddParameters("@EmpName", GetDbType("System.String"), AccessDetailsEntityDetail.EmpName);
            AddParameters("@Empno", GetDbType("System.String"), AccessDetailsEntityDetail.Empno);
            AddParameters("@Flg", GetDbType("System.String"), AccessDetailsEntityDetail.Flg);
            AddParameters("@RNo", GetDbType("System.Int64"), AccessDetailsEntityDetail.RNo);
            AddParameters("@Status", GetDbType("System.String"), AccessDetailsEntityDetail.Status);

            base.MapToDatabase();
        }

        protected AccessDetailsEntity AccessDetailsEntityDetail
        {
            get { return BusinessEntityDetail as AccessDetailsEntity; }
        }
    }
}
