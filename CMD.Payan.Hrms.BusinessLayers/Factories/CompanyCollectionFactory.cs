using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class CompanyCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static CompanyCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new CompanyCollection();
        }

        public static CompanyCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new CompanyCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
