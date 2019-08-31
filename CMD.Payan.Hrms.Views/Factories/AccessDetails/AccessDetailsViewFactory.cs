using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Views
{
    public class AccessDetailsViewFactory : ViewFactory
    {
        private static IViewFactory _factory;

        public static IViewFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new AccessDetailsViewFactory();
                }

                return _factory;
            }
        }

        protected override IView Create()
        {
            return new AccessDetailsView();
        }

        ////protected override IView Create(IViewContext viewContext)
        ////{
            ////return new AccessDetailsView(viewContext);
        ////}
    }
}
