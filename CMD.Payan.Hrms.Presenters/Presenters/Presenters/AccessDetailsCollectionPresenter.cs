using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class AccessDetailsCollectionPresenter : Presenter
    {
        #region Constructors

        public AccessDetailsCollectionPresenter(IView view)
            : base(view, AccessDetailsPresentationEntityCollectionFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties

        public IAccessDetailsView AccessDetailsViewDetail
        {
            get { return ViewDetail as IAccessDetailsView; }
        }

        public AccessDetailsPresentationEntityCollection AccessDetailsPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as AccessDetailsPresentationEntityCollection; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
