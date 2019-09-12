using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.Common;
using CMD.Payan.Hrms.BusinessEntities;
using CMD.Payan.Hrms.DatabaseLayer;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class PayanarApplication : BusinessObject, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public PayanarApplication()
            : base(PayanarApplicationEntityFactory.Factory, PayanarApplicationDatabaseAgentFactory.Factory)
        { }

        public PayanarApplication(IParent parent)
            : base(PayanarApplicationEntityFactory.Factory, PayanarApplicationDatabaseAgentFactory.Factory, parent)
        { }

        #endregion Constructors

        #region Properties

        ////private static PayanarApplication _payanarApplicationInstance = null;
        ////public static PayanarApplication PayanarApplicationInstance
        ////{
        ////    get
        ////    {
        ////        if (_payanarApplicationInstance == null)
        ////            _payanarApplicationInstance = PayanarApplicationFactory.Factory.Instance() as PayanarApplication;

        ////        return _payanarApplicationInstance;
        ////    }
        ////}

        public System.String Name
        {
            get { return PayanarApplicationEntityDetail.Name; }
            set { PayanarApplicationEntityDetail.Name = value; }
        }

        public System.String Title
        {
            get { return PayanarApplicationEntityDetail.Title; }
            set { PayanarApplicationEntityDetail.Title = value; }
        }

        public System.String Description
        {
            get { return PayanarApplicationEntityDetail.Description; }
            set { PayanarApplicationEntityDetail.Description = value; }
        }

        private PayanarApplicationEntity PayanarApplicationEntityDetail
        {
            get { return BusinessEntityObject as PayanarApplicationEntity; }
        }

        private TableInformation _tableInformationInstance = null;
        public TableInformation TableInformationInstance
        {
            get
            {
                return _tableInformationInstance == null ? _tableInformationInstance = TableInformationFactory.Factory.Instance() as TableInformation : _tableInformationInstance;
            }
        }

        private TableInformationCollection _tableInformationCollection = null;
        public TableInformationCollection TableInformationCollectionInstance
        {
            get
            {
                return _tableInformationCollection == null ? _tableInformationCollection = TableInformationCollectionFactory.Factory.Instance() as TableInformationCollection : _tableInformationCollection;
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

        #endregion Protected

        #endregion Methods
    }
}
