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
    public class InterviewFormHeaderCollection : BusinessObjectCollection<InterviewFormHeader>
    {
	#region Constructors

        public InterviewFormHeaderCollection()
            : base(InterviewFormHeaderFactory.Factory, InterviewFormHeaderDatabaseAgentFactory.Factory)
        { }

        public InterviewFormHeaderCollection(IParent parent)
            : base(InterviewFormHeaderFactory.Factory, InterviewFormHeaderDatabaseAgentFactory.Factory, parent)
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
