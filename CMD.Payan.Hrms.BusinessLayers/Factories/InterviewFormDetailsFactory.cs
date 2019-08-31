using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class InterviewFormDetailsFactory : BusinessObjectFactory
    {
	#region Variable Declarations

        private static InterviewFormDetailsFactory _factory = null;

	#endregion Variable Declarations

	#region Methods

        public static InterviewFormDetailsFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFormDetailsFactory();
                }

                return _factory;
            }
        }


        protected override IBusinessObject Create()
        {
            return new InterviewFormDetails();
        }


        protected override IBusinessObject Create(IParent parent)
        {
            return new InterviewFormDetails(parent);
        }

	#endregion Methods
    }
}
