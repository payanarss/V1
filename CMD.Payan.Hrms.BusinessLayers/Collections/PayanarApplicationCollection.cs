using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.Common;
using CMD.Payan.Hrms.BusinessEntities;
using CMD.Payan.Hrms.DatabaseLayer;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class PayanarApplicationCollection : BusinessObjectCollection<PayanarApplication>
    {
	#region Constructors

        public PayanarApplicationCollection()
            : base(PayanarApplicationFactory.Factory, PayanarApplicationDatabaseAgentFactory.Factory)
        { }

        public PayanarApplicationCollection(IParent parent)
            : base(PayanarApplicationFactory.Factory, PayanarApplicationDatabaseAgentFactory.Factory, parent)
        {
        }

	#endregion Constructors

	#region Methods

        public override void WhereParameters()
        {
            base.WhereParameters();
        }

	#endregion
    }
}
