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
    public class TableDetailCollection : BusinessObjectCollection<TableDetail>
    {
	#region Constructors

        public TableDetailCollection()
            : base(TableDetailFactory.Factory, TableDetailDatabaseAgentFactory.Factory)
        { }

        public TableDetailCollection(IParent parent)
            : base(TableDetailFactory.Factory, TableDetailDatabaseAgentFactory.Factory, parent)
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
