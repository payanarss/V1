using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class PayanarApplicationCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static PayanarApplicationCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new PayanarApplicationCollection();
        }

        public static PayanarApplicationCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new PayanarApplicationCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
