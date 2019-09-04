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
    public class TableDetailPresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public TableDetailPresentationEntity(IPresenter presenter)
            : base(presenter, TableDetailFactory.Factory)
        {
        }

        public TableDetailPresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public TableDetailPresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public TableDetailPresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, TableDetailFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties
	
        public System.String TableName
        {
            get { return TableDetailDetail.TableName; }
            set { TableDetailDetail.TableName = value; }
        }

        public System.Int64 SequenceNumber
        {
            get { return TableDetailDetail.SequenceNumber; }
            set { TableDetailDetail.SequenceNumber = value; }
        }

        public System.Int64 NextSequenceNumber
        {
            get { return TableDetailDetail.NextSequenceNumber; }
            set { TableDetailDetail.NextSequenceNumber = value; }
        }

        public System.DateTime CurrentDate
        {
            get { return TableDetailDetail.CurrentDate; }
            set { TableDetailDetail.CurrentDate = value; }
        }

        public TableDetail TableDetailDetail
        {
            get { return BusinessObjectDetail as TableDetail; }
        }

        private TableDetailPresenter TableDetailPresenterDetail
        {
            get { return PresenterDetail as TableDetailPresenter; }
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
