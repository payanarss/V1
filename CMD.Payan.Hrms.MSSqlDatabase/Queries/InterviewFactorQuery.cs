using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFactorQuery
    {
        public static string InsertQuery
        {
            get { return @"Insert into dbo.MExpect ( Description, IsRejected, SlNo) values ( @Description, @IsRejected, @SlNo)"; }
        }

        public static string UpdateQuery
        {
            get { return @"Update dbo.MExpect set  Description=@Description, IsRejected=@IsRejected, SlNo=@SlNo where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string DeleteQuery
        {
            get { return @"Delete from dbo.MExpect where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectQuery
        {
            get { return @"Select  Description, IsRejected, SlNo from dbo.MExpect where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectAllQuery
        {
            get { return @"Select  Description, IsRejected, SlNo from dbo.MExpect"; }
        }
    }
}
