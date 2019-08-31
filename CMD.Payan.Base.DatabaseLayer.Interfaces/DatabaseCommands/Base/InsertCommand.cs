using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using CMD.Payan.Base.BusinessEntity.Interfaces;
using CMD.Payan.Base.Common;
using CMD.Payan.Base.BusinessLayer.Interfaces;

namespace CMD.Payan.Base.DatabaseLayer.Interfaces
{
    public abstract class InsertCommand : Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.InsertCommand
    {
        public InsertCommand(Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        {
        }
    }
}