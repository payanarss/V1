using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Views
{
    public class InterviewFormDetailsViewFactory : ViewFactory
    {
        private static IViewFactory _factory;

        public static IViewFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFormDetailsViewFactory();
                }

                return _factory;
            }
        }

        protected override IView Create()
        {
            return new InterviewFormDetailsView();
        }

        ////protected override IView Create(IViewContext viewContext)
        ////{
            ////return new InterviewFormDetailsView(viewContext);
        ////}
    }
}
