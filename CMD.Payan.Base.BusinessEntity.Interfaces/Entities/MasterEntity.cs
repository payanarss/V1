using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.Common;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Base.BusinessEntity.Interfaces
{
    public class MasterEntity : Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.MasterEntity
    {
        #region Constructors

        public MasterEntity()
            : base()
        {
        }

        public MasterEntity(IParent parent)
            : base(parent)
        {
        }

        #endregion Constructors
    }
}