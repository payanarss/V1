using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.BusinessLayer;
using CMD.Payan.Base.BusinessLayer.Interfaces;

namespace CMD.Payan.Base.PresentationLayer.Interfaces
{
    public class UserPresentationEntity : Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.UserPresentationEntity
    {
        #region Constructors

        public UserPresentationEntity(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter)
            : base(presenter) { }

        #endregion Constructors
    }
}