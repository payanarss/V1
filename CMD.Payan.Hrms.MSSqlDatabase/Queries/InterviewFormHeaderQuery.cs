using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewFormHeaderQuery
    {
        public static string InsertQuery
        {
            get { return @"Insert into dbo.InterviewHd ( CallDate, CallNo, CandAdd, CandName, EmpName, IntDate, IntNo, Post, Recom, Selected, ToBePost, InterviewDtCollectionInstance) values ( @CallDate, @CallNo, @CandAdd, @CandName, @EmpName, @IntDate, @IntNo, @Post, @Recom, @Selected, @ToBePost, @InterviewDtCollectionInstance)"; }
        }

        public static string UpdateQuery
        {
            get { return @"Update dbo.InterviewHd set  CallDate=@CallDate, CallNo=@CallNo, CandAdd=@CandAdd, CandName=@CandName, EmpName=@EmpName, IntDate=@IntDate, IntNo=@IntNo, Post=@Post, Recom=@Recom, Selected=@Selected, ToBePost=@ToBePost, InterviewDtCollectionInstance=@InterviewDtCollectionInstance where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string DeleteQuery
        {
            get { return @"Delete from dbo.InterviewHd where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectQuery
        {
            get { return @"Select  CallDate, CallNo, CandAdd, CandName, EmpName, IntDate, IntNo, Post, Recom, Selected, ToBePost, InterviewDtCollectionInstance from dbo.InterviewHd where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectAllQuery
        {
            get { return @"Select  CallDate, CallNo, CandAdd, CandName, EmpName, IntDate, IntNo, Post, Recom, Selected, ToBePost, InterviewDtCollectionInstance from dbo.InterviewHd"; }
        }
    }
}
