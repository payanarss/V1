using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class AccessDetailsCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static AccessDetailsCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new AccessDetailsCollection();
        }

        public static AccessDetailsCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new AccessDetailsCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
