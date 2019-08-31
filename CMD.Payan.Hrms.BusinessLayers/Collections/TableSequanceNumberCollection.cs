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
    public class TableSequanceNumberCollection : BusinessObjectCollection<TableSequanceNumber>
    {
	#region Constructors

        public TableSequanceNumberCollection()
            : base(TableSequanceNumberFactory.Factory, TableSequanceNumberDatabaseAgentFactory.Factory)
        { }

        public TableSequanceNumberCollection(IParent parent)
            : base(TableSequanceNumberFactory.Factory, TableSequanceNumberDatabaseAgentFactory.Factory, parent)
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
