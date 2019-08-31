using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class CallLetterCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static CallLetterCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new CallLetterCollection();
        }

        public static CallLetterCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new CallLetterCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
