using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.DatabaseLayer.Interfaces;
using CMD.Payan.Base.BusinessLayer.Interfaces;

namespace CMD.Payan.Base.DatabaseLayer.Interfaces
{
    public class UserCollectionDatabaseAgent : Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.UserCollectionDatabaseAgent
    {
        public UserCollectionDatabaseAgent(Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
        }
    }
}