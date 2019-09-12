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
    public class AppointmentOrderFactorCollection : BusinessObjectCollection<AppointmentOrderFactor>
    {
	#region Constructors

        public AppointmentOrderFactorCollection()
            : base(AppointmentOrderFactorFactory.Factory, AppointmentOrderFactorDatabaseAgentFactory.Factory)
        { }

        public AppointmentOrderFactorCollection(IParent parent)
            : base(AppointmentOrderFactorFactory.Factory, AppointmentOrderFactorDatabaseAgentFactory.Factory, parent)
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
