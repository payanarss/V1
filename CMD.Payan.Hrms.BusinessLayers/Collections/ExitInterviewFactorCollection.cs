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
    public class ExitInterviewFactorCollection : BusinessObjectCollection<ExitInterviewFactor>
    {
	#region Constructors

        public ExitInterviewFactorCollection()
            : base(ExitInterviewFactorFactory.Factory, ExitInterviewFactorDatabaseAgentFactory.Factory)
        { }

        public ExitInterviewFactorCollection(IParent parent)
            : base(ExitInterviewFactorFactory.Factory, ExitInterviewFactorDatabaseAgentFactory.Factory, parent)
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
