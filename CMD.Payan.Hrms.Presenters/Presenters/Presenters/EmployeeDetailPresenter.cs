using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class EmployeeDetailPresenter : Presenter
    {
        #region Constructors

        public EmployeeDetailPresenter(IView view)
            : base(view, EmployeeDetailPresentationEntityFactory.Factory)
        {
        }

        public EmployeeDetailPresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public IEmployeeDetailView EmployeeDetailViewDetail
        {
            get { return ViewDetail as IEmployeeDetailView; }
        }

        public EmployeeDetailPresentationEntity EmployeeDetailPresentationEntityDetail
        {
            get { return PresentationEntityDetail as EmployeeDetailPresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
