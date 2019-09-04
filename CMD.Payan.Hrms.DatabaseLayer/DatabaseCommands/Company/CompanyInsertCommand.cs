using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class CompanyInsertCommand : InsertCommand
    {
        public CompanyInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return CompanyQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
	                AddParameters("@CompanyAddress1", GetDbType("System.String"), CompanyEntityDetail.CompanyAddress1);
            AddParameters("@CompanyAddress2", GetDbType("System.String"), CompanyEntityDetail.CompanyAddress2);
            AddParameters("@CompanyAddress3", GetDbType("System.String"), CompanyEntityDetail.CompanyAddress3);
            AddParameters("@CompanyAddress4", GetDbType("System.String"), CompanyEntityDetail.CompanyAddress4);
            AddParameters("@CompanyName", GetDbType("System.String"), CompanyEntityDetail.CompanyName);
            AddParameters("@CompanyName1", GetDbType("System.String"), CompanyEntityDetail.CompanyName1);
            AddParameters("@CompanyCode", GetDbType("System.String"), CompanyEntityDetail.CompanyCode);

            base.MapToDatabase();
        }

        protected CompanyEntity CompanyEntityDetail
        {
            get { return BusinessEntityDetail as CompanyEntity; }
        }
    }
}
