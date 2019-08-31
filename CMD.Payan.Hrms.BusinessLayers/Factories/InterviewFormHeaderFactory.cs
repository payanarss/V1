using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class InterviewFormHeaderFactory : BusinessObjectFactory
    {
	#region Variable Declarations

        private static InterviewFormHeaderFactory _factory = null;

	#endregion Variable Declarations

	#region Methods

        public static InterviewFormHeaderFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFormHeaderFactory();
                }

                return _factory;
            }
        }


        protected override IBusinessObject Create()
        {
            return new InterviewFormHeader();
        }


        protected override IBusinessObject Create(IParent parent)
        {
            return new InterviewFormHeader(parent);
        }

	#endregion Methods
    }
}
