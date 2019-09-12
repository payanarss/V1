using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class InterviewFactorCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static InterviewFactorCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new InterviewFactorCollection();
        }

        public static InterviewFactorCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFactorCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
