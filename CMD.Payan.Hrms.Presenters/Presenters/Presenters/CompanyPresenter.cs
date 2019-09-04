using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class CompanyPresenter : Presenter
    {
        #region Constructors

        public CompanyPresenter(IView view)
            : base(view, CompanyPresentationEntityFactory.Factory)
        {
        }

        public CompanyPresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public ICompanyView CompanyViewDetail
        {
            get { return ViewDetail as ICompanyView; }
        }

        public CompanyPresentationEntity CompanyPresentationEntityDetail
        {
            get { return PresentationEntityDetail as CompanyPresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
