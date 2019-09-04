using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class EmployeeDetailQuery
    {
        public static string InsertQuery
        {
            get { return @"Insert into dbo.Empdet_tb ( Aadhar, ABonus, Address1, Address2, BankName, BankNumber, Basic, CcGroupCode, City, Cl, Classi, Degree, Deptcode, Deptname, Designation, Designdesc, DevCode, DevName, Dispensary, Dob, Doc, Doj, Dor, DoubleOTType, Email, Empcode, Empimage, Empname, Empno, EsiLocation, ESIno, FatherName, FBonus, FClassi, FDESIGN, IFSCCODE, IncrMonth, InsNo, InsPremium, JoinDate, OT, OTType, PanNo, PayMode, Pensionpf, PFMargin, PFno, Phone, Pincode, Policy1, Policy2, Policy3, PrdEnt, RelDate, ResigReason, Revdate, Revno, SerialNo, Sex, Shft, Shft1, SrName, Status, Subgroup, Sunded, Swapcardno) values ( @Aadhar, @ABonus, @Address1, @Address2, @BankName, @BankNumber, @Basic, @CcGroupCode, @City, @Cl, @Classi, @Degree, @Deptcode, @Deptname, @Designation, @Designdesc, @DevCode, @DevName, @Dispensary, @Dob, @Doc, @Doj, @Dor, @DoubleOTType, @Email, @Empcode, @Empimage, @Empname, @Empno, @EsiLocation, @ESIno, @FatherName, @FBonus, @FClassi, @FDESIGN, @IFSCCODE, @IncrMonth, @InsNo, @InsPremium, @JoinDate, @OT, @OTType, @PanNo, @PayMode, @Pensionpf, @PFMargin, @PFno, @Phone, @Pincode, @Policy1, @Policy2, @Policy3, @PrdEnt, @RelDate, @ResigReason, @Revdate, @Revno, @SerialNo, @Sex, @Shft, @Shft1, @SrName, @Status, @Subgroup, @Sunded, @Swapcardno)"; }
        }

        public static string UpdateQuery
        {
            get { return @"Update dbo.Empdet_tb set  Aadhar=@Aadhar, ABonus=@ABonus, Address1=@Address1, Address2=@Address2, BankName=@BankName, BankNumber=@BankNumber, Basic=@Basic, CcGroupCode=@CcGroupCode, City=@City, Cl=@Cl, Classi=@Classi, Degree=@Degree, Deptcode=@Deptcode, Deptname=@Deptname, Designation=@Designation, Designdesc=@Designdesc, DevCode=@DevCode, DevName=@DevName, Dispensary=@Dispensary, Dob=@Dob, Doc=@Doc, Doj=@Doj, Dor=@Dor, DoubleOTType=@DoubleOTType, Email=@Email, Empcode=@Empcode, Empimage=@Empimage, Empname=@Empname, Empno=@Empno, EsiLocation=@EsiLocation, ESIno=@ESIno, FatherName=@FatherName, FBonus=@FBonus, FClassi=@FClassi, FDESIGN=@FDESIGN, IFSCCODE=@IFSCCODE, IncrMonth=@IncrMonth, InsNo=@InsNo, InsPremium=@InsPremium, JoinDate=@JoinDate, OT=@OT, OTType=@OTType, PanNo=@PanNo, PayMode=@PayMode, Pensionpf=@Pensionpf, PFMargin=@PFMargin, PFno=@PFno, Phone=@Phone, Pincode=@Pincode, Policy1=@Policy1, Policy2=@Policy2, Policy3=@Policy3, PrdEnt=@PrdEnt, RelDate=@RelDate, ResigReason=@ResigReason, Revdate=@Revdate, Revno=@Revno, SerialNo=@SerialNo, Sex=@Sex, Shft=@Shft, Shft1=@Shft1, SrName=@SrName, Status=@Status, Subgroup=@Subgroup, Sunded=@Sunded, Swapcardno=@Swapcardno where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string DeleteQuery
        {
            get { return @"Delete from dbo.Empdet_tb where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectQuery
        {
            get { return @"Select  Aadhar, ABonus, Address1, Address2, BankName, BankNumber, Basic, CcGroupCode, City, Cl, Classi, Degree, Deptcode, Deptname, Designation, Designdesc, DevCode, DevName, Dispensary, Dob, Doc, Doj, Dor, DoubleOTType, Email, Empcode, Empimage, Empname, Empno, EsiLocation, ESIno, FatherName, FBonus, FClassi, FDESIGN, IFSCCODE, IncrMonth, InsNo, InsPremium, JoinDate, OT, OTType, PanNo, PayMode, Pensionpf, PFMargin, PFno, Phone, Pincode, Policy1, Policy2, Policy3, PrdEnt, RelDate, ResigReason, Revdate, Revno, SerialNo, Sex, Shft, Shft1, SrName, Status, Subgroup, Sunded, Swapcardno from dbo.Empdet_tb where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectAllQuery
        {
            get { return @"Select  Aadhar, ABonus, Address1, Address2, BankName, BankNumber, Basic, CcGroupCode, City, Cl, Classi, Degree, Deptcode, Deptname, Designation, Designdesc, DevCode, DevName, Dispensary, Dob, Doc, Doj, Dor, DoubleOTType, Email, Empcode, Empimage, Empname, Empno, EsiLocation, ESIno, FatherName, FBonus, FClassi, FDESIGN, IFSCCODE, IncrMonth, InsNo, InsPremium, JoinDate, OT, OTType, PanNo, PayMode, Pensionpf, PFMargin, PFno, Phone, Pincode, Policy1, Policy2, Policy3, PrdEnt, RelDate, ResigReason, Revdate, Revno, SerialNo, Sex, Shft, Shft1, SrName, Status, Subgroup, Sunded, Swapcardno from dbo.Empdet_tb"; }
        }
    }
}
