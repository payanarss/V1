using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class AppointmentOrderFactorCollectionFactory : BusinessObjectCollectionFactory
    {
	#region Private Variables

        private static AppointmentOrderFactorCollectionFactory _factory = null;

	#endregion Private Variables

	#region Methods

        protected override IBusinessObjectCollection Create()
        {
            return new AppointmentOrderFactorCollection();
        }

        public static AppointmentOrderFactorCollectionFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new AppointmentOrderFactorCollectionFactory();
                }

                return _factory;
            }
        }

	#endregion Methods
    }
}
