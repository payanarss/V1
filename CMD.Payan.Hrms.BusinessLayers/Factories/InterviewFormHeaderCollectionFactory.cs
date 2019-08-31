using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class InterviewFormHeaderCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static InterviewFormHeaderCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new InterviewFormHeaderCollection();
        }

        public static InterviewFormHeaderCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFormHeaderCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
