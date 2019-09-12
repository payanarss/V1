using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessEntity.Interfaces;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Hrms.BusinessEntities
{
    public class AppointmentOrderFactorEntityFactory : BusinessEntityFactory
    {
	#region Private Variables

        private static AppointmentOrderFactorEntityFactory _factory = null;

	#endregion Private Variables

	#region Methods

        public static AppointmentOrderFactorEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new AppointmentOrderFactorEntityFactory();
                }

                return _factory;
            }
        }

        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create()
        {
            return new AppointmentOrderFactorEntity();
        }
        
        protected override Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.IBusinessEntity Create(IParent parent)
        {
            return new AppointmentOrderFactorEntity(parent);
        }

	#endregion Methods
    }
}
