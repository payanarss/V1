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
    public class TableSequanceNumberPresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public TableSequanceNumberPresentationEntity(IPresenter presenter)
            : base(presenter, TableSequanceNumberFactory.Factory)
        {
        }

        public TableSequanceNumberPresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public TableSequanceNumberPresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public TableSequanceNumberPresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, TableSequanceNumberFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties
	
        public System.String TableName
        {
            get { return TableSequanceNumberDetail.TableName; }
            set { TableSequanceNumberDetail.TableName = value; }
        }

        public System.Int64 SequenceNumber
        {
            get { return TableSequanceNumberDetail.SequenceNumber; }
            set { TableSequanceNumberDetail.SequenceNumber = value; }
        }

        public System.Int64 NextSequenceNumber
        {
            get { return TableSequanceNumberDetail.NextSequenceNumber; }
            set { TableSequanceNumberDetail.NextSequenceNumber = value; }
        }

        public System.DateTime CurrentDate
        {
            get { return TableSequanceNumberDetail.CurrentDate; }
            set { TableSequanceNumberDetail.CurrentDate = value; }
        }

        public TableSequanceNumber TableSequanceNumberDetail
        {
            get { return BusinessObjectDetail as TableSequanceNumber; }
        }

        private TableSequanceNumberPresenter TableSequanceNumberPresenterDetail
        {
            get { return PresenterDetail as TableSequanceNumberPresenter; }
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
