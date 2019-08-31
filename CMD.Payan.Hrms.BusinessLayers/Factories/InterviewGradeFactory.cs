using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class InterviewGradeFactory : BusinessObjectFactory
    {
	#region Variable Declarations

        private static InterviewGradeFactory _factory = null;

	#endregion Variable Declarations

	#region Methods

        public static InterviewGradeFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewGradeFactory();
                }

                return _factory;
            }
        }


        protected override IBusinessObject Create()
        {
            return new InterviewGrade();
        }


        protected override IBusinessObject Create(IParent parent)
        {
            return new InterviewGrade(parent);
        }

	#endregion Methods
    }
}
