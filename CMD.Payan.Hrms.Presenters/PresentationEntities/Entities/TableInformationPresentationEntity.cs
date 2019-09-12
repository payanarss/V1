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
    public class TableInformationPresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public TableInformationPresentationEntity(IPresenter presenter)
            : base(presenter, TableInformationFactory.Factory)
        {
        }

        public TableInformationPresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public TableInformationPresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public TableInformationPresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, TableInformationFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public System.String TableName
        {
            get { return TableInformationDetail.TableName; }
            set { TableInformationDetail.TableName = value; }
        }

        public System.Int64 SequenceNumber
        {
            get { return TableInformationDetail.SequenceNumber; }
            set { TableInformationDetail.SequenceNumber = value; }
        }

        public System.Int64 NextSequenceNumber
        {
            get { return SequenceNumber + 1; }
            set { TableInformationDetail.NextSequenceNumber = value; }
        }

        public System.DateTime CurrentDate
        {
            get { return TableInformationDetail.CurrentDate; }
            set { TableInformationDetail.CurrentDate = value; }
        }

        public System.Int64 OpeningSequenceNumber
        {
            get { return TableInformationDetail.OpeningSequenceNumber; }
            set { TableInformationDetail.OpeningSequenceNumber = value; }
        }

        public TableInformation TableInformationDetail
        {
            get { return BusinessObjectDetail as TableInformation; }
        }

        private TableInformationPresenter TableInformationPresenterDetail
        {
            get { return PresenterDetail as TableInformationPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void OnViewReady()
        {
            base.OnViewReady();
        }

        #endregion Methods
    }
}
