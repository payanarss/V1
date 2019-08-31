using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.DatabaseLayer
{
    public class TableSequanceNumberQuery
    {
        public static string InsertQuery
        {
            get { return @"Insert into TableSequanceNumber ( TableName, SequenceNumber, NextSequenceNumber, CurrentDate) values ( @TableName, @SequenceNumber, @NextSequenceNumber, @CurrentDate)"; }
        }

        public static string UpdateQuery
        {
            get { return @"Update TableSequanceNumber set  TableName=@TableName, SequenceNumber=@SequenceNumber, NextSequenceNumber=@NextSequenceNumber, CurrentDate=@CurrentDate where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string DeleteQuery
        {
            get { return @"Delete from TableSequanceNumber where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectQuery
        {
            get { return @"Select  TableName, SequenceNumber, NextSequenceNumber, CurrentDate from TableSequanceNumber where [UniqueIdentifier]=@UniqueIdentifier"; }
        }

        public static string SelectAllQuery
        {
            get { return @"Select  TableName, SequenceNumber, NextSequenceNumber, CurrentDate from TableSequanceNumber"; }
        }
    }
}
