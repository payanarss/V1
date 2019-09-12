using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class TableInformationCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static TableInformationCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new TableInformationCollection();
        }

        public static TableInformationCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new TableInformationCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
