using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class AppointmentOrderFactorQuery
    {
        public static string InsertQuery
        {
            get { return @"Insert into dbo.MAppOrdFactors ( Description, Rejected, SiNo) values ( @Description, @Rejected, @SiNo)"; }
        }

        public static string UpdateQuery
        {
            get { return @"Update dbo.MAppOrdFactors set  Description=@Description, Rejected=@Rejected, SiNo=@SiNo where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string DeleteQuery
        {
            get { return @"Delete from dbo.MAppOrdFactors where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectQuery
        {
            get { return @"Select  Description, Rejected, SiNo from dbo.MAppOrdFactors where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectAllQuery
        {
            get { return @"Select  Description, Rejected, SiNo from dbo.MAppOrdFactors"; }
        }
    }
}
