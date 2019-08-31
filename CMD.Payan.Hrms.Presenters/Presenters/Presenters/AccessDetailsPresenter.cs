using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class AccessDetailsPresenter : Presenter
    {
        #region Constructors

        public AccessDetailsPresenter(IView view)
            : base(view, AccessDetailsPresentationEntityFactory.Factory)
        {
        }

        public AccessDetailsPresenter(IView view, IPresentationEntity presentationEntity)
            : base(view, presentationEntity)
        {
        }

        #endregion Constructors

        #region Properties

        public IAccessDetailsView AccessDetailsViewDetail
        {
            get { return ViewDetail as IAccessDetailsView; }
        }

        public AccessDetailsPresentationEntity AccessDetailsPresentationEntityDetail
        {
            get { return PresentationEntityDetail as AccessDetailsPresentationEntity; }
        }

        #endregion Properties

        #region Methods


        #endregion Methods
    }
}
