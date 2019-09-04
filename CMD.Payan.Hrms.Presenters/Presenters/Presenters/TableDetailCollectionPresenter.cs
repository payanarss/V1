using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class TableDetailCollectionPresenter : Presenter
    {
        #region Constructors

        public TableDetailCollectionPresenter(IView view)
            : base(view, TableDetailPresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public ITableDetailView TableDetailViewDetail
        {
            get { return ViewDetail as ITableDetailView; }
        }

        public TableDetailPresentationEntityCollection TableDetailPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as TableDetailPresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
