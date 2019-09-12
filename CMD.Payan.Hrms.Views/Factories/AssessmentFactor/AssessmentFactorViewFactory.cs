using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Views
{
    public class AssessmentFactorViewFactory : ViewFactory
    {
        private static IViewFactory _factory;

        public static IViewFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new AssessmentFactorViewFactory();
                }

                return _factory;
            }
        }

        protected override IView Create()
        {
            return new AssessmentFactorView();
        }

        ////protected override IView Create(IViewContext viewContext)
        ////{
            ////return new AssessmentFactorView(viewContext);
        ////}
    }
}
