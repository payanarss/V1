using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class CompanyQuery
    {
        public static string InsertQuery
        {
            get { return @"Insert into dbo.tbCompany ( CompanyAddress1, CompanyAddress2, CompanyAddress3, CompanyAddress4, CompanyName, CompanyName1, CompanyCode) values ( @CompanyAddress1, @CompanyAddress2, @CompanyAddress3, @CompanyAddress4, @CompanyName, @CompanyName1, @CompanyCode)"; }
        }

        public static string UpdateQuery
        {
            get { return @"Update dbo.tbCompany set  CompanyAddress1=@CompanyAddress1, CompanyAddress2=@CompanyAddress2, CompanyAddress3=@CompanyAddress3, CompanyAddress4=@CompanyAddress4, CompanyName=@CompanyName, CompanyName1=@CompanyName1, CompanyCode=@CompanyCode where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string DeleteQuery
        {
            get { return @"Delete from dbo.tbCompany where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectQuery
        {
            get { return @"Select  CompanyAddress1, CompanyAddress2, CompanyAddress3, CompanyAddress4, CompanyName, CompanyName1, CompanyCode from dbo.tbCompany where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectAllQuery
        {
            get { return @"Select  CompanyAddress1, CompanyAddress2, CompanyAddress3, CompanyAddress4, CompanyName, CompanyName1, CompanyCode from dbo.tbCompany"; }
        }
    }
}
