using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class TableInformationCollectionPresenter : Presenter
    {
        #region Constructors

        public TableInformationCollectionPresenter(IView view)
            : base(view, TableInformationPresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public ITableInformationView TableInformationViewDetail
        {
            get { return ViewDetail as ITableInformationView; }
        }

        public TableInformationPresentationEntityCollection TableInformationPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as TableInformationPresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
