using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CMD.Payan.Base.BusinessEntity.Interfaces;
using CMD.Payan.Base.BusinessLayer.Interfaces;
using System.Data.OleDb;

namespace CMD.Payan.Base.DatabaseLayer.Interfaces
{
    public class UserInsertCommand : Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.UserInsertCommand
    {
        public UserInsertCommand(Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        { }
    }
}