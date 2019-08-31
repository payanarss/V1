using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFormDetailsQuery
    {
        public static string InsertQuery
        {
            get { return @"Insert into dbo.InterviewDt ( Des, Grade, IntNo, Remarks, Slno) values ( @Des, @Grade, @IntNo, @Remarks, @Slno)"; }
        }

        public static string UpdateQuery
        {
            get { return @"Update dbo.InterviewDt set  Des=@Des, Grade=@Grade, IntNo=@IntNo, Remarks=@Remarks, Slno=@Slno where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string DeleteQuery
        {
            get { return @"Delete from dbo.InterviewDt where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectQuery
        {
            get { return @"Select  Des, Grade, IntNo, Remarks, Slno from dbo.InterviewDt where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectAllQuery
        {
            get { return @"Select  Des, Grade, IntNo, Remarks, Slno from dbo.InterviewDt"; }
        }
    }
}
