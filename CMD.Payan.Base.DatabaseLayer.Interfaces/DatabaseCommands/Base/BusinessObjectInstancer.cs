using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.BusinessLayer.Interfaces;

namespace CMD.Payan.Base.DatabaseLayer.Interfaces
{
    public class BusinessObjectInstancer : Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.BusinessObjectInstancer
    {
        public BusinessObjectInstancer(Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObject businessObject)
            : base(businessObject)
        {
        }
    }
}