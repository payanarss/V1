using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.BusinessLayer.Interfaces;
using CMD.Payan.Base.DatabaseLayer.Interfaces;

namespace CMD.Payan.Base.DatabaseLayer.Interfaces
{
    public class CollectionDatabaseAgent : Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.CollectionDatabaseAgent
    {
        #region Constructors

        public CollectionDatabaseAgent(Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
        }

        #endregion Constructors
    }
}