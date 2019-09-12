using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayanarCommon = Payanar.SS.Net.Libraries.Common;
using BaseBusinessLayer = CMD.Payan.Net.Base.BusinessLayer;
using BaseCommon = CMD.Payan.Net.Base.Common;
using CMD.Payan.Net.Hrms.BusinessEntities;
using CMD.Payan.Net.Hrms.DatabaseLayer;

namespace CMD.Payan.Net.Hrms.BusinessLayers
{
    public class AppointmentOrderFactor : BaseBusinessLayer.BusinessObject, BaseCommon.IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public AppointmentOrderFactor()
            : base(AppointmentOrderFactorEntityFactory.Factory, AppointmentOrderFactorDatabaseAgentFactory.Factory)
        { }

 	public AppointmentOrderFactor(PayanarCommon.IParent parent)
            : base(AppointmentOrderFactorEntityFactory.Factory, AppointmentOrderFactorDatabaseAgentFactory.Factory, parent)
        { }

        #endregion Constructors

        #region Properties

        public AppointmentOrderFactorEntity AppointmentOrderFactorEntityDetail
        {
            get { return BusinessEntityObject as AppointmentOrderFactorEntity; }
        }

	

        $BusinessObjectChildInstanceDetailsProperty$

        
        public System.String Description
        {
            get { return AppointmentOrderFactorEntityDetail.Description; }
            set
            {
                if (AppointmentOrderFactorEntityDetail.Description != value)
                {
                    AppointmentOrderFactorEntityDetail.Description = value;
                }
            }
        }

        public System.Int64 Rejected
        {
            get { return AppointmentOrderFactorEntityDetail.Rejected; }
            set
            {
                if (AppointmentOrderFactorEntityDetail.Rejected != value)
                {
                    AppointmentOrderFactorEntityDetail.Rejected = value;
                }
            }
        }

        public System.Int64 SiNo
        {
            get { return AppointmentOrderFactorEntityDetail.SiNo; }
            set
            {
                if (AppointmentOrderFactorEntityDetail.SiNo != value)
                {
                    AppointmentOrderFactorEntityDetail.SiNo = value;
                }
            }
        }


	

        #endregion Properties

        #region Methods

        #region Public

        public override int Load()
        {
            int result = 0;

            result += base.Load();

            return result;
        }

        #endregion Public

        #region Protected

        protected override int SaveChildBusinessObject()
        {
            int result = 0;

            result = base.SaveChildBusinessObject();
            $BusinessObjectChildCollectionDetailsSaveLines$

            return result;
        }

        protected override bool ValidateBeforeSave()
        {
            bool isValid = base.ValidateBeforeSave();

            return isValid;
        }

        protected override bool ValidateBeforeDelete()
        {
            bool isValid = base.ValidateBeforeDelete();

            return isValid;
        }

        protected override bool ValidateChildObjectsBeforeSave()
        {
            bool result = false;

            result = base.ValidateChildObjectsBeforeSave();
            $BusinessObjectChildCollectionDetailsValidateLines$

            return result;
        }

        protected override bool ValidateChildObjectsBeforeDelete()
        {
            bool result = false;

            result = base.ValidateChildObjectsBeforeSave();
            $BusinessObjectChildCollectionDetailsValidateLines$

            return result;
        }

        #endregion Protected

        #endregion Methods
    }
}
