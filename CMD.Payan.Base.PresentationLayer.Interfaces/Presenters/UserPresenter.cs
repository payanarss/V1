using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Base.PresentationLayer.Interfaces
{
    public class UserPresenter : Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.UserPresenter
    {
        public UserPresenter(IView view)
            : base(view)
        {
        }
    }
}