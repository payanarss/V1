using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class CompanyCollectionPresenter : Presenter
    {
        #region Constructors

        public CompanyCollectionPresenter(IView view)
            : base(view, CompanyPresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public ICompanyView CompanyViewDetail
        {
            get { return ViewDetail as ICompanyView; }
        }

        public CompanyPresentationEntityCollection CompanyPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as CompanyPresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
