using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class InterviewGradeCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static InterviewGradeCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new InterviewGradeCollection();
        }

        public static InterviewGradeCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewGradeCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
