using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using Bhu.Payanar.Apps.Net.BusinessEntity.Interfaces;
using Bhu.Payanar.Apps.Net.Common;
using Bhu.Payanar.Apps.Net.BusinessLayer.Interfaces;

namespace Bhu.Payanar.Apps.Net.DatabaseLayer.Interfaces
{
    public abstract class DMLCommand : Command
    {
        public DMLCommand(IBusinessObject businessObject)
            : base(businessObject)
        {
        }

        protected override int ExecuteQuery()
        {
            int result = 0;

            result = DbCommandObject.ExecuteNonQuery();

            return result;
        }

        protected override void MapFromDatabase(IDataReader reader) { return; }
    }
}