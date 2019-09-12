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
    public class InterviewFactor : BaseBusinessLayer.BusinessObject, BaseCommon.IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public InterviewFactor()
            : base(InterviewFactorEntityFactory.Factory, InterviewFactorDatabaseAgentFactory.Factory)
        { }

 	public InterviewFactor(PayanarCommon.IParent parent)
            : base(InterviewFactorEntityFactory.Factory, InterviewFactorDatabaseAgentFactory.Factory, parent)
        { }

        #endregion Constructors

        #region Properties

        public InterviewFactorEntity InterviewFactorEntityDetail
        {
            get { return BusinessEntityObject as InterviewFactorEntity; }
        }

	

        $BusinessObjectChildInstanceDetailsProperty$

        
        public System.String Description
        {
            get { return InterviewFactorEntityDetail.Description; }
            set
            {
                if (InterviewFactorEntityDetail.Description != value)
                {
                    InterviewFactorEntityDetail.Description = value;
                }
            }
        }

        public System.Int64 IsRejected
        {
            get { return InterviewFactorEntityDetail.IsRejected; }
            set
            {
                if (InterviewFactorEntityDetail.IsRejected != value)
                {
                    InterviewFactorEntityDetail.IsRejected = value;
                }
            }
        }

        public System.Int64 SlNo
        {
            get { return InterviewFactorEntityDetail.SlNo; }
            set
            {
                if (InterviewFactorEntityDetail.SlNo != value)
                {
                    InterviewFactorEntityDetail.SlNo = value;
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
