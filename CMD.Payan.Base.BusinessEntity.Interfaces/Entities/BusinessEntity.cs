using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using CMD.Payan.Base.Common;
using CMD.Payan.Base.BusinessEntity.Interfaces;

namespace CMD.Payan.Base.BusinessEntity.Interfaces
{
    public class BusinessEntity : Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.BusinessEntity
    {
        public BusinessEntity()
        {
        }

        public BusinessEntity(Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(parent)
        {
        }
    }
}