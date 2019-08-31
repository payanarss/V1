using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.BusinessLayer.Interfaces;

namespace CMD.Payan.Base.DatabaseLayer.Interfaces
{
    public class CollectionInstancer : Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.CollectionInstancer
    {
        public CollectionInstancer(Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
        }
    }
}