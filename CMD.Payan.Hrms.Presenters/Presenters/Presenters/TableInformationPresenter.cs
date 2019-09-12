using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class TableInformationPresenter : Presenter
    {
        #region Constructors

        public TableInformationPresenter(IView view)
            : base(view, TableInformationPresentationEntityFactory.Factory)
        {
        }

        public TableInformationPresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public ITableInformationView TableInformationViewDetail
        {
            get { return ViewDetail as ITableInformationView; }
        }

        public TableInformationPresentationEntity TableInformationPresentationEntityDetail
        {
            get { return PresentationEntityDetail as TableInformationPresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
