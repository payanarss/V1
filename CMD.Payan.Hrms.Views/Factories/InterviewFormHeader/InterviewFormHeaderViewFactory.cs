using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Views
{
    public class InterviewFormHeaderViewFactory : ViewFactory
    {
        private static IViewFactory _factory;

        public static IViewFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFormHeaderViewFactory();
                }

                return _factory;
            }
        }

        protected override IView Create()
        {
            return new InterviewFormHeaderView();
        }

        ////protected override IView Create(IViewContext viewContext)
        ////{
            ////return new InterviewFormHeaderView(viewContext);
        ////}
    }
}
