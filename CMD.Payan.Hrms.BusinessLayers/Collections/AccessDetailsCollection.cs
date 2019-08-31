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
    public class AccessDetailsCollection : BusinessObjectCollection<AccessDetails>
    {
	#region Constructors

        public AccessDetailsCollection()
            : base(AccessDetailsFactory.Factory, AccessDetailsDatabaseAgentFactory.Factory)
        { }

        public AccessDetailsCollection(IParent parent)
            : base(AccessDetailsFactory.Factory, AccessDetailsDatabaseAgentFactory.Factory, parent)
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
