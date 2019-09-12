using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class InterviewFactorFactory : BusinessObjectFactory
    {
	#region Variable Declarations

        private static InterviewFactorFactory _factory = null;

	#endregion Variable Declarations

	#region Methods

        public static InterviewFactorFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFactorFactory();
                }

                return _factory;
            }
        }


        protected override IBusinessObject Create()
        {
            return new InterviewFactor();
        }


        protected override IBusinessObject Create(IParent parent)
        {
            return new InterviewFactor(parent);
        }

	#endregion Methods
    }
}
