using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Net.Payanar.Base.PresentationLayer.Interfaces;

namespace Net.Payanar.CMD.ERP.Plannings.Views
{
    public class UserRegistrationViewFactory : ViewFactory
    {
        private static IViewFactory _factory;

        public static IViewFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new UserRegistrationViewFactory();
                }

                return _factory;
            }
        }

        protected override IView Create()
        {
            return new UserRegistrationView();
        }

        ////protected override IView Create(IViewContext viewContext)
        ////{
            ////return new UserRegistrationView(viewContext);
        ////}
    }
}