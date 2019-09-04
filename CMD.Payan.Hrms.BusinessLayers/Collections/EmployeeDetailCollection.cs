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
    public class EmployeeDetailCollection : BusinessObjectCollection<EmployeeDetail>
    {
	#region Constructors

        public EmployeeDetailCollection()
            : base(EmployeeDetailFactory.Factory, EmployeeDetailDatabaseAgentFactory.Factory)
        { }

        public EmployeeDetailCollection(IParent parent)
            : base(EmployeeDetailFactory.Factory, EmployeeDetailDatabaseAgentFactory.Factory, parent)
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
