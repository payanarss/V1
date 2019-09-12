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
    public class AssessmentFactorCollection : BusinessObjectCollection<AssessmentFactor>
    {
	#region Constructors

        public AssessmentFactorCollection()
            : base(AssessmentFactorFactory.Factory, AssessmentFactorDatabaseAgentFactory.Factory)
        { }

        public AssessmentFactorCollection(IParent parent)
            : base(AssessmentFactorFactory.Factory, AssessmentFactorDatabaseAgentFactory.Factory, parent)
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
