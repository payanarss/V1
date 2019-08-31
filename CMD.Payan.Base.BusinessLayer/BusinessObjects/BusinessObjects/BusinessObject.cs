using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using System.Data;
using System.Collections;
using CMD.Payan.Base.BusinessLayer;
using CMD.Payan.Base.BusinessLayer.Interfaces;
using CMD.Payan.Base.BusinessEntity.Interfaces;
using CMD.Payan.Base.Common;
using CMD.Payan.Base.DatabaseLayer.Interfaces;

namespace CMD.Payan.Base.BusinessLayer
{
    public class BusinessObject : Payanar.SS.Net.Libraries.BusinessLayer.BusinessObject
    {
        #region Constructors

        public BusinessObject() : base() { }

        public BusinessObject(Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntityFactory businessEntityFactory)
            : this()
        {
        }

        public BusinessObject(Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntityFactory businessEntityFactory, Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.IDatabaseAgentFactory databaseAgentFactory)
            : base(businessEntityFactory, databaseAgentFactory)
        {
        }

        public BusinessObject(Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntityFactory businessEntityFactory, Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.IDatabaseAgentFactory databaseAgentFactory, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(businessEntityFactory, databaseAgentFactory, parent)
        {
        }

        #endregion Constructors
    }
}