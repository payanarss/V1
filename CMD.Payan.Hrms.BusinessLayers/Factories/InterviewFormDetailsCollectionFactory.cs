using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class InterviewFormDetailsCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static InterviewFormDetailsCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new InterviewFormDetailsCollection();
        }

        public static InterviewFormDetailsCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFormDetailsCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
