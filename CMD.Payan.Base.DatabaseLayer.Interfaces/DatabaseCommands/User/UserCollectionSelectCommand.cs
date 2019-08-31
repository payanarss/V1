using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CMD.Payan.Base.BusinessEntity.Interfaces;
using CMD.Payan.Base.BusinessLayer.Interfaces;

namespace CMD.Payan.Base.DatabaseLayer.Interfaces
{
    public class UserCollectionSelectCommand : Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.UserCollectionSelectCommand
    {
        public UserCollectionSelectCommand(Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.IDatabaseAgent databaseAgent)
            : base(databaseAgent)
        {
        }
    }
}