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
            get { return @"Insert into dbo.CallLetter ( CallLetterDate, CallLetterNumber, CandidateAddress, CandidateName, CompanyCode, ContactNumber, InterviewDate, InterviewTime, DesignationCode, Regards, UniqueIdentifier, RowID) values ( @CallLetterDate, @CallLetterNumber, @CandidateAddress, @CandidateName, @CompanyCode, @ContactNumber, @InterviewDate, @InterviewTime, @DesignationCode, @Regards, @UniqueIdentifier, @RowID)"; }
        }

        public static string UpdateQuery
        {
            get { return @"Update dbo.CallLetter set  CallLetterDate=@CallLetterDate, CallLetterNumber=@CallLetterNumber, CandidateAddress=@CandidateAddress, CandidateName=@CandidateName, CompanyCode=@CompanyCode, ContactNumber=@ContactNumber, InterviewDate=@InterviewDate, InterviewTime=@InterviewTime, DesignationCode=@DesignationCode, Regards=@Regards, UniqueIdentifier=@UniqueIdentifier, RowID=@RowID where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string DeleteQuery
        {
            get { return @"Delete from dbo.CallLetter where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectQuery
        {
            get { return @"Select  CallLetterDate, CallLetterNumber, CandidateAddress, CandidateName, CompanyCode, ContactNumber, InterviewDate, InterviewTime, DesignationCode, Regards, UniqueIdentifier, RowID from dbo.CallLetter where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectAllQuery
        {
            get { return @"Select  CallLetterDate, CallLetterNumber, CandidateAddress, CandidateName, CompanyCode, ContactNumber, InterviewDate, InterviewTime, DesignationCode, Regards, UniqueIdentifier, RowID from dbo.CallLetter"; }
        }
    }
}
