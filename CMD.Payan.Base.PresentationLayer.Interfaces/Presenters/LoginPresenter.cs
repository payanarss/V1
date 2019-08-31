using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Base.PresentationLayer.Interfaces
{
    public class LoginPresenter : Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.LoginPresenter
    {
        public LoginPresenter(IView view)
            : base(view)
        {
        }
    }
}