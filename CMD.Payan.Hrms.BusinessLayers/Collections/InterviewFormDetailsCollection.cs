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
    public class InterviewFormDetailsCollection : BusinessObjectCollection<InterviewFormDetails>
    {
	#region Constructors

        public InterviewFormDetailsCollection()
            : base(InterviewFormDetailsFactory.Factory, InterviewFormDetailsDatabaseAgentFactory.Factory)
        { }

        public InterviewFormDetailsCollection(IParent parent)
            : base(InterviewFormDetailsFactory.Factory, InterviewFormDetailsDatabaseAgentFactory.Factory, parent)
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
