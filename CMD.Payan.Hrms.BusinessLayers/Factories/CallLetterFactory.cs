using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class CallLetterFactory : BusinessObjectFactory
    {
	#region Variable Declarations

        private static CallLetterFactory _factory = null;

	#endregion Variable Declarations

	#region Methods

        public static CallLetterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new CallLetterFactory();
                }

                return _factory;
            }
        }


        protected override IBusinessObject Create()
        {
            return new CallLetter();
        }


        protected override IBusinessObject Create(IParent parent)
        {
            return new CallLetter(parent);
        }

	#endregion Methods
    }
}
