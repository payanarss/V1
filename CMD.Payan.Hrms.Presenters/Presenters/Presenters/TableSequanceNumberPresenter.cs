using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class TableSequanceNumberPresenter : Presenter
    {
        #region Constructors

        public TableSequanceNumberPresenter(IView view)
            : base(view, TableSequanceNumberPresentationEntityFactory.Factory)
        {
        }

        public TableSequanceNumberPresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public ITableSequanceNumberView TableSequanceNumberViewDetail
        {
            get { return ViewDetail as ITableSequanceNumberView; }
        }

        public TableSequanceNumberPresentationEntity TableSequanceNumberPresentationEntityDetail
        {
            get { return PresentationEntityDetail as TableSequanceNumberPresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
