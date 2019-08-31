using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.BusinessLayer;
using CMD.Payan.Base.BusinessLayer.Interfaces;
using CMD.Payan.Base.BusinessEntity.Interfaces;
using CMD.Payan.Base.DatabaseLayer.Interfaces;
using CMD.Payan.Base.Common;

namespace CMD.Payan.Base.BusinessLayer
{
    public class MasterBusinessObject : Payanar.SS.Net.Libraries.BusinessLayer.MasterBusinessObject
    {
        #region Constructors

        public MasterBusinessObject() : base() { }

        public MasterBusinessObject(Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntityFactory businessEntityFactory)
            : base(businessEntityFactory)
        {
        }

        public MasterBusinessObject(Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntityFactory businessEntityFactory, Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.IDatabaseAgentFactory databaseAgentFactory)
            : base(businessEntityFactory, databaseAgentFactory)
        {
        }

        public MasterBusinessObject(Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntityFactory businessEntityFactory, Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.IDatabaseAgentFactory databaseAgentFactory, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(businessEntityFactory, databaseAgentFactory, parent)
        {
        }

        #endregion Constructors
    }
}