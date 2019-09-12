using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class PayanarApplicationQuery
    {
        public static string InsertQuery
        {
            get { return @"Insert into PayanarApplication ( Name, Title, Description) values ( @Name, @Title, @Description)"; }
        }

        public static string UpdateQuery
        {
            get { return @"Update PayanarApplication set  Name=@Name, Title=@Title, Description=@Description where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string DeleteQuery
        {
            get { return @"Delete from PayanarApplication where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectQuery
        {
            get { return @"Select  Name, Title, Description from PayanarApplication where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectAllQuery
        {
            get { return @"Select  Name, Title, Description from PayanarApplication"; }
        }
    }
}
