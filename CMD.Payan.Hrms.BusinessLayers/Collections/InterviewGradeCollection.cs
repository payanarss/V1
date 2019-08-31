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
    public class InterviewGradeCollection : BusinessObjectCollection<InterviewGrade>
    {
	#region Constructors

        public InterviewGradeCollection()
            : base(InterviewGradeFactory.Factory, InterviewGradeDatabaseAgentFactory.Factory)
        { }

        public InterviewGradeCollection(IParent parent)
            : base(InterviewGradeFactory.Factory, InterviewGradeDatabaseAgentFactory.Factory, parent)
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
