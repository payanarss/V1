using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.BusinessLayer;
using CMD.Payan.Base.Common;
using CMD.Payan.Base.BusinessLayer.Interfaces;
using CMD.Payan.Base.DatabaseLayer.Interfaces;
using System.Collections;
using System.Data;

namespace CMD.Payan.Base.BusinessLayer
{
    public class BusinessObjectCollection<T> : Payanar.SS.Net.Libraries.BusinessLayer.BusinessObjectCollection<T> where T : Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObject
    {
        #region Constructors

        public BusinessObjectCollection()
            : base()
        {
        }

        public BusinessObjectCollection(Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectFactory businessObjectFactory, Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.IDatabaseAgentFactory databaseAgentFactory)
            : base(businessObjectFactory, databaseAgentFactory)
        {
        }

        public BusinessObjectCollection(Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectFactory businessObjectFactory, Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.IDatabaseAgentFactory databaseAgentFactory, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(businessObjectFactory, databaseAgentFactory, parent)
        {
        }

        #endregion Constructors
    }
}