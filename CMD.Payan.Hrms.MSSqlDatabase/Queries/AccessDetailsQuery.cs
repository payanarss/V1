using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AccessDetailsQuery
    {
        public static string InsertQuery
        {
            get { return @"Insert into dbo.access_details ( AccDate, AccTime, DoorNo, EmpCode, EmpName, Empno, Flg, RNo, Status) values ( @AccDate, @AccTime, @DoorNo, @EmpCode, @EmpName, @Empno, @Flg, @RNo, @Status)"; }
        }

        public static string UpdateQuery
        {
            get { return @"Update dbo.access_details set  AccDate=@AccDate, AccTime=@AccTime, DoorNo=@DoorNo, EmpCode=@EmpCode, EmpName=@EmpName, Empno=@Empno, Flg=@Flg, RNo=@RNo, Status=@Status where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string DeleteQuery
        {
            get { return @"Delete from dbo.access_details where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectQuery
        {
            get { return @"Select  AccDate, AccTime, DoorNo, EmpCode, EmpName, Empno, Flg, RNo, Status from dbo.access_details where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectAllQuery
        {
            get { return @"Select  AccDate, AccTime, DoorNo, EmpCode, EmpName, Empno, Flg, RNo, Status from dbo.access_details"; }
        }
    }
}
