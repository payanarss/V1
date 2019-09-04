using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces;
using CMD.Payan.Hrms.BusinessEntities;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class EmployeeDetailInsertCommand : InsertCommand
    {
        public EmployeeDetailInsertCommand(IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }

        protected override string Query()
        {
            return EmployeeDetailQuery.InsertQuery;
        }

        protected override void MapToDatabase()
        {
	                AddParameters("@Aadhar", GetDbType("System.String"), EmployeeDetailEntityDetail.Aadhar);
            AddParameters("@ABonus", GetDbType("System.Int64"), EmployeeDetailEntityDetail.ABonus);
            AddParameters("@Address1", GetDbType("System.String"), EmployeeDetailEntityDetail.Address1);
            AddParameters("@Address2", GetDbType("System.String"), EmployeeDetailEntityDetail.Address2);
            AddParameters("@BankName", GetDbType("System.String"), EmployeeDetailEntityDetail.BankName);
            AddParameters("@BankNumber", GetDbType("System.String"), EmployeeDetailEntityDetail.BankNumber);
            AddParameters("@Basic", GetDbType("System.Decimal"), EmployeeDetailEntityDetail.Basic);
            AddParameters("@CcGroupCode", GetDbType("System.String"), EmployeeDetailEntityDetail.CcGroupCode);
            AddParameters("@City", GetDbType("System.String"), EmployeeDetailEntityDetail.City);
            AddParameters("@Cl", GetDbType("System.Int64"), EmployeeDetailEntityDetail.Cl);
            AddParameters("@Classi", GetDbType("System.String"), EmployeeDetailEntityDetail.Classi);
            AddParameters("@Degree", GetDbType("System.String"), EmployeeDetailEntityDetail.Degree);
            AddParameters("@Deptcode", GetDbType("System.String"), EmployeeDetailEntityDetail.Deptcode);
            AddParameters("@Deptname", GetDbType("System.String"), EmployeeDetailEntityDetail.Deptname);
            AddParameters("@Designation", GetDbType("System.String"), EmployeeDetailEntityDetail.Designation);
            AddParameters("@Designdesc", GetDbType("System.String"), EmployeeDetailEntityDetail.Designdesc);
            AddParameters("@DevCode", GetDbType("System.String"), EmployeeDetailEntityDetail.DevCode);
            AddParameters("@DevName", GetDbType("System.String"), EmployeeDetailEntityDetail.DevName);
            AddParameters("@Dispensary", GetDbType("System.String"), EmployeeDetailEntityDetail.Dispensary);
            AddParameters("@Dob", GetDbType("System.String"), EmployeeDetailEntityDetail.Dob);
            AddParameters("@Doc", GetDbType("System.String"), EmployeeDetailEntityDetail.Doc);
            AddParameters("@Doj", GetDbType("System.String"), EmployeeDetailEntityDetail.Doj);
            AddParameters("@Dor", GetDbType("System.String"), EmployeeDetailEntityDetail.Dor);
            AddParameters("@DoubleOTType", GetDbType("System.Decimal"), EmployeeDetailEntityDetail.DoubleOTType);
            AddParameters("@Email", GetDbType("System.String"), EmployeeDetailEntityDetail.Email);
            AddParameters("@Empcode", GetDbType("System.String"), EmployeeDetailEntityDetail.Empcode);
            AddParameters("@Empimage", GetDbType("System.String"), EmployeeDetailEntityDetail.Empimage);
            AddParameters("@Empname", GetDbType("System.String"), EmployeeDetailEntityDetail.Empname);
            AddParameters("@Empno", GetDbType("System.Decimal"), EmployeeDetailEntityDetail.Empno);
            AddParameters("@EsiLocation", GetDbType("System.String"), EmployeeDetailEntityDetail.EsiLocation);
            AddParameters("@ESIno", GetDbType("System.String"), EmployeeDetailEntityDetail.ESIno);
            AddParameters("@FatherName", GetDbType("System.String"), EmployeeDetailEntityDetail.FatherName);
            AddParameters("@FBonus", GetDbType("System.Int64"), EmployeeDetailEntityDetail.FBonus);
            AddParameters("@FClassi", GetDbType("System.String"), EmployeeDetailEntityDetail.FClassi);
            AddParameters("@FDESIGN", GetDbType("System.String"), EmployeeDetailEntityDetail.FDESIGN);
            AddParameters("@IFSCCODE", GetDbType("System.String"), EmployeeDetailEntityDetail.IFSCCODE);
            AddParameters("@IncrMonth", GetDbType("System.String"), EmployeeDetailEntityDetail.IncrMonth);
            AddParameters("@InsNo", GetDbType("System.String"), EmployeeDetailEntityDetail.InsNo);
            AddParameters("@InsPremium", GetDbType("System.Decimal"), EmployeeDetailEntityDetail.InsPremium);
            AddParameters("@JoinDate", GetDbType("System.DateTime"), EmployeeDetailEntityDetail.JoinDate);
            AddParameters("@OT", GetDbType("System.Int64"), EmployeeDetailEntityDetail.OT);
            AddParameters("@OTType", GetDbType("System.Decimal"), EmployeeDetailEntityDetail.OTType);
            AddParameters("@PanNo", GetDbType("System.String"), EmployeeDetailEntityDetail.PanNo);
            AddParameters("@PayMode", GetDbType("System.String"), EmployeeDetailEntityDetail.PayMode);
            AddParameters("@Pensionpf", GetDbType("System.Int64"), EmployeeDetailEntityDetail.Pensionpf);
            AddParameters("@PFMargin", GetDbType("System.String"), EmployeeDetailEntityDetail.PFMargin);
            AddParameters("@PFno", GetDbType("System.String"), EmployeeDetailEntityDetail.PFno);
            AddParameters("@Phone", GetDbType("System.String"), EmployeeDetailEntityDetail.Phone);
            AddParameters("@Pincode", GetDbType("System.String"), EmployeeDetailEntityDetail.Pincode);
            AddParameters("@Policy1", GetDbType("System.String"), EmployeeDetailEntityDetail.Policy1);
            AddParameters("@Policy2", GetDbType("System.String"), EmployeeDetailEntityDetail.Policy2);
            AddParameters("@Policy3", GetDbType("System.String"), EmployeeDetailEntityDetail.Policy3);
            AddParameters("@PrdEnt", GetDbType("System.Int64"), EmployeeDetailEntityDetail.PrdEnt);
            AddParameters("@RelDate", GetDbType("System.DateTime"), EmployeeDetailEntityDetail.RelDate);
            AddParameters("@ResigReason", GetDbType("System.String"), EmployeeDetailEntityDetail.ResigReason);
            AddParameters("@Revdate", GetDbType("System.String"), EmployeeDetailEntityDetail.Revdate);
            AddParameters("@Revno", GetDbType("System.Decimal"), EmployeeDetailEntityDetail.Revno);
            AddParameters("@SerialNo", GetDbType("System.Decimal"), EmployeeDetailEntityDetail.SerialNo);
            AddParameters("@Sex", GetDbType("System.String"), EmployeeDetailEntityDetail.Sex);
            AddParameters("@Shft", GetDbType("System.String"), EmployeeDetailEntityDetail.Shft);
            AddParameters("@Shft1", GetDbType("System.String"), EmployeeDetailEntityDetail.Shft1);
            AddParameters("@SrName", GetDbType("System.String"), EmployeeDetailEntityDetail.SrName);
            AddParameters("@Status", GetDbType("System.String"), EmployeeDetailEntityDetail.Status);
            AddParameters("@Subgroup", GetDbType("System.String"), EmployeeDetailEntityDetail.Subgroup);
            AddParameters("@Sunded", GetDbType("System.Decimal"), EmployeeDetailEntityDetail.Sunded);
            AddParameters("@Swapcardno", GetDbType("System.String"), EmployeeDetailEntityDetail.Swapcardno);

            base.MapToDatabase();
        }

        protected EmployeeDetailEntity EmployeeDetailEntityDetail
        {
            get { return BusinessEntityDetail as EmployeeDetailEntity; }
        }
    }
}
