using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class TableSequanceNumberCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static TableSequanceNumberCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new TableSequanceNumberCollection();
        }

        public static TableSequanceNumberCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new TableSequanceNumberCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
