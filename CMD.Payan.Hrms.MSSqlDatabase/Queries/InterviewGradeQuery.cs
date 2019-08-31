using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class InterviewGradeQuery
    {
        public static string InsertQuery
        {
            get { return @"Insert into InterviewGrade ( Code, Description) values ( @Code, @Description)"; }
        }

        public static string UpdateQuery
        {
            get { return @"Update InterviewGrade set  Code=@Code, Description=@Description where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string DeleteQuery
        {
            get { return @"Delete from InterviewGrade where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectQuery
        {
            get { return @"Select  Code, Description from InterviewGrade where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectAllQuery
        {
            get { return @"Select  Code, Description from InterviewGrade"; }
        }
    }
}
