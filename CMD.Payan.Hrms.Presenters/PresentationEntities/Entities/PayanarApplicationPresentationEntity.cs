using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;
using CMD.Payan.Hrms.BusinessLayers;

namespace CMD.Payan.Hrms.Presenters
{
    public class PayanarApplicationPresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public PayanarApplicationPresentationEntity(IPresenter presenter)
            : base(presenter, PayanarApplicationFactory.Factory)
        {
        }

        public PayanarApplicationPresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public PayanarApplicationPresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public PayanarApplicationPresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, PayanarApplicationFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        private static PayanarApplicationPresentationEntity _payanarApplicationPresentationEntity = null;
        public static PayanarApplicationPresentationEntity PayanarApplicationPresentationEntityInstance
        {
            get
            {
                if (_payanarApplicationPresentationEntity == null)
                    _payanarApplicationPresentationEntity = PayanarApplicationPresentationEntityFactory.Factory.Instance(null) as PayanarApplicationPresentationEntity;

                return _payanarApplicationPresentationEntity;
            }
        }

        public System.String Name
        {
            get { return PayanarApplicationDetail.Name; }
            set { PayanarApplicationDetail.Name = value; }
        }

        public System.String Title
        {
            get { return PayanarApplicationDetail.Title; }
            set { PayanarApplicationDetail.Title = value; }
        }

        public System.String Description
        {
            get { return PayanarApplicationDetail.Description; }
            set { PayanarApplicationDetail.Description = value; }
        }

        public PayanarApplication PayanarApplicationDetail
        {
            get { return BusinessObjectDetail as PayanarApplication; }
        }

        private PayanarApplicationPresenter PayanarApplicationPresenterDetail
        {
            get { return PresenterDetail as PayanarApplicationPresenter; }
        }

        private TableInformationPresentationEntity _tableInformationPresentationEntity = null;
        public TableInformationPresentationEntity TableInformationPresentationEntityInstance
        {
            get
            {
                return _tableInformationPresentationEntity == null ? _tableInformationPresentationEntity = TableInformationPresentationEntityFactory.Factory.Instance(null, (base.BusinessObjectDetail as PayanarApplication).TableInformationInstance) as TableInformationPresentationEntity : _tableInformationPresentationEntity;
            }
        }

        private TableInformationPresentationEntityCollection _tableInformationPresentationEntityCollection = null;
        public TableInformationPresentationEntityCollection TableInformationPresentationEntityCollectionInstance
        {
            get
            {
                return _tableInformationPresentationEntityCollection == null ? _tableInformationPresentationEntityCollection = TableInformationPresentationEntityCollectionFactory.Factory.Instance(null, (base.BusinessObjectDetail as PayanarApplication).TableInformationCollectionInstance) as TableInformationPresentationEntityCollection : _tableInformationPresentationEntityCollection;
            }
        }

        #endregion Properties

        #region Methods

        public override void OnViewReady()
        {
            base.OnViewReady();
            TableInformationPresentationEntityCollectionInstance.Load();
        }

        #endregion Methods
    }
}
