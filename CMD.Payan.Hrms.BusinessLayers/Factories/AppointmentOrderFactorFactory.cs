using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class AppointmentOrderFactorFactory : BusinessObjectFactory
    {
	#region Variable Declarations

        private static AppointmentOrderFactorFactory _factory = null;

	#endregion Variable Declarations

	#region Methods

        public static AppointmentOrderFactorFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new AppointmentOrderFactorFactory();
                }

                return _factory;
            }
        }


        protected override IBusinessObject Create()
        {
            return new AppointmentOrderFactor();
        }


        protected override IBusinessObject Create(IParent parent)
        {
            return new AppointmentOrderFactor(parent);
        }

	#endregion Methods
    }
}
