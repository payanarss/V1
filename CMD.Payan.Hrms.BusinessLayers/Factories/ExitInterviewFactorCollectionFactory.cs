using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class ExitInterviewFactorCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static ExitInterviewFactorCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new ExitInterviewFactorCollection();
        }

        public static ExitInterviewFactorCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new ExitInterviewFactorCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
