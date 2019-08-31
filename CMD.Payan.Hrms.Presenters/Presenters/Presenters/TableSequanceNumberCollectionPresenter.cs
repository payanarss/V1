using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class TableSequanceNumberCollectionPresenter : Presenter
    {
        #region Constructors

        public TableSequanceNumberCollectionPresenter(IView view)
            : base(view, TableSequanceNumberPresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public ITableSequanceNumberView TableSequanceNumberViewDetail
        {
            get { return ViewDetail as ITableSequanceNumberView; }
        }

        public TableSequanceNumberPresentationEntityCollection TableSequanceNumberPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as TableSequanceNumberPresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
