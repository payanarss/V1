using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class CallLetterQuery
    {
        public static string InsertQuery
        {
            get { return @"Insert into dbo.CallLetter ( CallDate, CallNo, CandAdd, CandTo, CompCode, ContNo, IntDate, IntTime, Pos, Regards) values ( @CallDate, @CallNo, @CandAdd, @CandTo, @CompCode, @ContNo, @IntDate, @IntTime, @Pos, @Regards)"; }
        }

        public static string UpdateQuery
        {
            get { return @"Update dbo.CallLetter set  CallDate=@CallDate, CallNo=@CallNo, CandAdd=@CandAdd, CandTo=@CandTo, CompCode=@CompCode, ContNo=@ContNo, IntDate=@IntDate, IntTime=@IntTime, Pos=@Pos, Regards=@Regards where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string DeleteQuery
        {
            get { return @"Delete from dbo.CallLetter where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectQuery
        {
            get { return @"Select  CallDate, CallNo, CandAdd, CandTo, CompCode, ContNo, IntDate, IntTime, Pos, Regards from dbo.CallLetter where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectAllQuery
        {
            get { return @"Select  CallDate, CallNo, CandAdd, CandTo, CompCode, ContNo, IntDate, IntTime, Pos, Regards from dbo.CallLetter"; }
        }
    }
}
