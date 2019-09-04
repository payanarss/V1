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
    public class EmployeeDetailSelectCommand : SelectCommand
    {
        public EmployeeDetailSelectCommand(IDatabaseAgent databaseAgent, string query)
            : base(databaseAgent, query)
        {
        }

        protected override void MapFromDatabase(IDataReader reader)
        {
            base.MapFromDatabase(reader);
            EmployeeDetailEntityDetail.UniqueIdentifier = ConvertType.ToInt64(reader["UniqueIdentifier"].ToString());
	                EmployeeDetailEntityDetail.Aadhar = ConvertType.ToString(reader["Aadhar"].ToString());
            EmployeeDetailEntityDetail.ABonus = ConvertType.ToInt64(reader["ABonus"].ToString());
            EmployeeDetailEntityDetail.Address1 = ConvertType.ToString(reader["Address1"].ToString());
            EmployeeDetailEntityDetail.Address2 = ConvertType.ToString(reader["Address2"].ToString());
            EmployeeDetailEntityDetail.BankName = ConvertType.ToString(reader["BankName"].ToString());
            EmployeeDetailEntityDetail.BankNumber = ConvertType.ToString(reader["BankNumber"].ToString());
            EmployeeDetailEntityDetail.Basic = ConvertType.ToDecimal(reader["Basic"].ToString());
            EmployeeDetailEntityDetail.CcGroupCode = ConvertType.ToString(reader["CcGroupCode"].ToString());
            EmployeeDetailEntityDetail.City = ConvertType.ToString(reader["City"].ToString());
            EmployeeDetailEntityDetail.Cl = ConvertType.ToInt64(reader["Cl"].ToString());
            EmployeeDetailEntityDetail.Classi = ConvertType.ToString(reader["Classi"].ToString());
            EmployeeDetailEntityDetail.Degree = ConvertType.ToString(reader["Degree"].ToString());
            EmployeeDetailEntityDetail.Deptcode = ConvertType.ToString(reader["Deptcode"].ToString());
            EmployeeDetailEntityDetail.Deptname = ConvertType.ToString(reader["Deptname"].ToString());
            EmployeeDetailEntityDetail.Designation = ConvertType.ToString(reader["Designation"].ToString());
            EmployeeDetailEntityDetail.Designdesc = ConvertType.ToString(reader["Designdesc"].ToString());
            EmployeeDetailEntityDetail.DevCode = ConvertType.ToString(reader["DevCode"].ToString());
            EmployeeDetailEntityDetail.DevName = ConvertType.ToString(reader["DevName"].ToString());
            EmployeeDetailEntityDetail.Dispensary = ConvertType.ToString(reader["Dispensary"].ToString());
            EmployeeDetailEntityDetail.Dob = ConvertType.ToString(reader["Dob"].ToString());
            EmployeeDetailEntityDetail.Doc = ConvertType.ToString(reader["Doc"].ToString());
            EmployeeDetailEntityDetail.Doj = ConvertType.ToString(reader["Doj"].ToString());
            EmployeeDetailEntityDetail.Dor = ConvertType.ToString(reader["Dor"].ToString());
            EmployeeDetailEntityDetail.DoubleOTType = ConvertType.ToDecimal(reader["DoubleOTType"].ToString());
            EmployeeDetailEntityDetail.Email = ConvertType.ToString(reader["Email"].ToString());
            EmployeeDetailEntityDetail.Empcode = ConvertType.ToString(reader["Empcode"].ToString());
            EmployeeDetailEntityDetail.Empimage = ConvertType.ToString(reader["Empimage"].ToString());
            EmployeeDetailEntityDetail.Empname = ConvertType.ToString(reader["Empname"].ToString());
            EmployeeDetailEntityDetail.Empno = ConvertType.ToDecimal(reader["Empno"].ToString());
            EmployeeDetailEntityDetail.EsiLocation = ConvertType.ToString(reader["EsiLocation"].ToString());
            EmployeeDetailEntityDetail.ESIno = ConvertType.ToString(reader["ESIno"].ToString());
            EmployeeDetailEntityDetail.FatherName = ConvertType.ToString(reader["FatherName"].ToString());
            EmployeeDetailEntityDetail.FBonus = ConvertType.ToInt64(reader["FBonus"].ToString());
            EmployeeDetailEntityDetail.FClassi = ConvertType.ToString(reader["FClassi"].ToString());
            EmployeeDetailEntityDetail.FDESIGN = ConvertType.ToString(reader["FDESIGN"].ToString());
            EmployeeDetailEntityDetail.IFSCCODE = ConvertType.ToString(reader["IFSCCODE"].ToString());
            EmployeeDetailEntityDetail.IncrMonth = ConvertType.ToString(reader["IncrMonth"].ToString());
            EmployeeDetailEntityDetail.InsNo = ConvertType.ToString(reader["InsNo"].ToString());
            EmployeeDetailEntityDetail.InsPremium = ConvertType.ToDecimal(reader["InsPremium"].ToString());
            EmployeeDetailEntityDetail.JoinDate = ConvertType.ToDateTime(reader["JoinDate"].ToString());
            EmployeeDetailEntityDetail.OT = ConvertType.ToInt64(reader["OT"].ToString());
            EmployeeDetailEntityDetail.OTType = ConvertType.ToDecimal(reader["OTType"].ToString());
            EmployeeDetailEntityDetail.PanNo = ConvertType.ToString(reader["PanNo"].ToString());
            EmployeeDetailEntityDetail.PayMode = ConvertType.ToString(reader["PayMode"].ToString());
            EmployeeDetailEntityDetail.Pensionpf = ConvertType.ToInt64(reader["Pensionpf"].ToString());
            EmployeeDetailEntityDetail.PFMargin = ConvertType.ToString(reader["PFMargin"].ToString());
            EmployeeDetailEntityDetail.PFno = ConvertType.ToString(reader["PFno"].ToString());
            EmployeeDetailEntityDetail.Phone = ConvertType.ToString(reader["Phone"].ToString());
            EmployeeDetailEntityDetail.Pincode = ConvertType.ToString(reader["Pincode"].ToString());
            EmployeeDetailEntityDetail.Policy1 = ConvertType.ToString(reader["Policy1"].ToString());
            EmployeeDetailEntityDetail.Policy2 = ConvertType.ToString(reader["Policy2"].ToString());
            EmployeeDetailEntityDetail.Policy3 = ConvertType.ToString(reader["Policy3"].ToString());
            EmployeeDetailEntityDetail.PrdEnt = ConvertType.ToInt64(reader["PrdEnt"].ToString());
            EmployeeDetailEntityDetail.RelDate = ConvertType.ToDateTime(reader["RelDate"].ToString());
            EmployeeDetailEntityDetail.ResigReason = ConvertType.ToString(reader["ResigReason"].ToString());
            EmployeeDetailEntityDetail.Revdate = ConvertType.ToString(reader["Revdate"].ToString());
            EmployeeDetailEntityDetail.Revno = ConvertType.ToDecimal(reader["Revno"].ToString());
            EmployeeDetailEntityDetail.SerialNo = ConvertType.ToDecimal(reader["SerialNo"].ToString());
            EmployeeDetailEntityDetail.Sex = ConvertType.ToString(reader["Sex"].ToString());
            EmployeeDetailEntityDetail.Shft = ConvertType.ToString(reader["Shft"].ToString());
            EmployeeDetailEntityDetail.Shft1 = ConvertType.ToString(reader["Shft1"].ToString());
            EmployeeDetailEntityDetail.SrName = ConvertType.ToString(reader["SrName"].ToString());
            EmployeeDetailEntityDetail.Status = ConvertType.ToString(reader["Status"].ToString());
            EmployeeDetailEntityDetail.Subgroup = ConvertType.ToString(reader["Subgroup"].ToString());
            EmployeeDetailEntityDetail.Sunded = ConvertType.ToDecimal(reader["Sunded"].ToString());
            EmployeeDetailEntityDetail.Swapcardno = ConvertType.ToString(reader["Swapcardno"].ToString());

        }

        private EmployeeDetailEntity EmployeeDetailEntityDetail
        {
            get { return BusinessEntityDetail as EmployeeDetailEntity; }
        }
    }
}
