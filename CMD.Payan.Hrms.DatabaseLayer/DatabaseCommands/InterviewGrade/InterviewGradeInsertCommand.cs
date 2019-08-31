using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewGradeInsertCommand : InsertCommand
    {
        public InterviewGradeInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return InterviewGradeQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
	                AddParameters("@Code", GetDbType("System.String"), InterviewGradeEntityDetail.Code);
            AddParameters("@Description", GetDbType("System.String"), InterviewGradeEntityDetail.Description);

            base.MapToDatabase();
        }

        protected InterviewGradeEntity InterviewGradeEntityDetail
        {
            get { return BusinessEntityDetail as InterviewGradeEntity; }
        }
    }
}
