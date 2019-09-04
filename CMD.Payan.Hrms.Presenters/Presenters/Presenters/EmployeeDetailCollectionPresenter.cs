using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class EmployeeDetailCollectionPresenter : Presenter
    {
        #region Constructors

        public EmployeeDetailCollectionPresenter(IView view)
            : base(view, EmployeeDetailPresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public IEmployeeDetailView EmployeeDetailViewDetail
        {
            get { return ViewDetail as IEmployeeDetailView; }
        }

        public EmployeeDetailPresentationEntityCollection EmployeeDetailPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as EmployeeDetailPresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
