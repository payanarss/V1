using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using CMD.Payan.Base.BusinessEntity.Interfaces;
using CMD.Payan.Base.BusinessLayer.Interfaces;

namespace CMD.Payan.Base.DatabaseLayer.Interfaces
{
    public abstract class Command : Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.Command
    {
        #region Constructors

        public Command()
            : base()
        {
        }

        public Command(Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        {
        }

        #endregion Constructors
    }
}