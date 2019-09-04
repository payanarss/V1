using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class TableDetailQuery
    {
        public static string InsertQuery
        {
            get { return @"Insert into TableDetail ( TableName, SequenceNumber, NextSequenceNumber, CurrentDate) values ( @TableName, @SequenceNumber, @NextSequenceNumber, @CurrentDate)"; }
        }

        public static string UpdateQuery
        {
            get { return @"Update TableDetail set  TableName=@TableName, SequenceNumber=@SequenceNumber, NextSequenceNumber=@NextSequenceNumber, CurrentDate=@CurrentDate where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string DeleteQuery
        {
            get { return @"Delete from TableDetail where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectQuery
        {
            get { return @"Select  TableName, SequenceNumber, NextSequenceNumber, CurrentDate from TableDetail where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectAllQuery
        {
            get { return @"Select  TableName, SequenceNumber, NextSequenceNumber, CurrentDate from TableDetail"; }
        }
    }
}
