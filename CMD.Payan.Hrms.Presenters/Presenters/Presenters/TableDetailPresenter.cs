using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class TableDetailPresenter : Presenter
    {
        #region Constructors

        public TableDetailPresenter(IView view)
            : base(view, TableDetailPresentationEntityFactory.Factory)
        {
        }

        public TableDetailPresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public ITableDetailView TableDetailViewDetail
        {
            get { return ViewDetail as ITableDetailView; }
        }

        public TableDetailPresentationEntity TableDetailPresentationEntityDetail
        {
            get { return PresentationEntityDetail as TableDetailPresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
