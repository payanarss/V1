using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CMD.Payan.Base.BusinessLayer.Interfaces;

namespace CMD.Payan.Base.DatabaseLayer.Interfaces
{
    public class UserDatabaseAgent : Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.UserDatabaseAgent
    {
        public UserDatabaseAgent(Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IUser userObject)
            : base(userObject)
        {
        }

        public UserDatabaseAgent(Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
        }
    }
}