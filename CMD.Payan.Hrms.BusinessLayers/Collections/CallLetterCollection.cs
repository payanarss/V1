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
    public class CallLetterCollection : BusinessObjectCollection<CallLetter>
    {
	#region Constructors

        public CallLetterCollection()
            : base(CallLetterFactory.Factory, CallLetterDatabaseAgentFactory.Factory)
        { }

        public CallLetterCollection(IParent parent)
            : base(CallLetterFactory.Factory, CallLetterDatabaseAgentFactory.Factory, parent)
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
