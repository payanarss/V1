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
    public class InterviewFactorCollection : BusinessObjectCollection<InterviewFactor>
    {
	#region Constructors

        public InterviewFactorCollection()
            : base(InterviewFactorFactory.Factory, InterviewFactorDatabaseAgentFactory.Factory)
        { }

        public InterviewFactorCollection(IParent parent)
            : base(InterviewFactorFactory.Factory, InterviewFactorDatabaseAgentFactory.Factory, parent)
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
