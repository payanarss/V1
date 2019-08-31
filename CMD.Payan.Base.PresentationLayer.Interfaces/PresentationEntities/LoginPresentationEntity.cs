using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.BusinessLayer;

namespace CMD.Payan.Base.PresentationLayer.Interfaces
{
    public class LoginPresentationEntity : Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.LoginPresentationEntity
    {
        public LoginPresentationEntity(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter)
            : base(presenter)
        {
        }
    }
}