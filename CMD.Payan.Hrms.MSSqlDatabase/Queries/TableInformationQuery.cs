using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class TableInformationQuery
    {
        public static string InsertQuery
        {
            get { return @"Insert into TableInformation ( TableName, SequenceNumber, OpeningSequenceNumber) values ( @TableName, @SequenceNumber, @OpeningSequenceNumber)"; }
        }

        public static string UpdateQuery
        {
            get { return @"Update TableInformation set  TableName=@TableName, SequenceNumber=@SequenceNumber, OpeningSequenceNumber=@OpeningSequenceNumber where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string DeleteQuery
        {
            get { return @"Delete from TableInformation where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectQuery
        {
            get { return @"Select  TableName, SequenceNumber, OpeningSequenceNumber from TableInformation where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectAllQuery
        {
            get { return @"Select  TableName, SequenceNumber, OpeningSequenceNumber from TableInformation"; }
        }
    }
}
