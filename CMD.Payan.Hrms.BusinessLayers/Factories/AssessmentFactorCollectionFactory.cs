using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class AssessmentFactorCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static AssessmentFactorCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new AssessmentFactorCollection();
        }

        public static AssessmentFactorCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new AssessmentFactorCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
