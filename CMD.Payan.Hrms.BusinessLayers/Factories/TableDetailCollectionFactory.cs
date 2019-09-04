using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class TableDetailCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static TableDetailCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new TableDetailCollection();
        }

        public static TableDetailCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new TableDetailCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
