using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class ExitInterviewFactorFactory : BusinessObjectFactory
    {
	#region Variable Declarations

        private static ExitInterviewFactorFactory _factory = null;

	#endregion Variable Declarations

	#region Methods

        public static ExitInterviewFactorFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new ExitInterviewFactorFactory();
                }

                return _factory;
            }
        }


        protected override IBusinessObject Create()
        {
            return new ExitInterviewFactor();
        }


        protected override IBusinessObject Create(IParent parent)
        {
            return new ExitInterviewFactor(parent);
        }

	#endregion Methods
    }
}
