using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class AssessmentFactorPresenterFactory : PresenterFactory
    {
        private static AssessmentFactorPresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new AssessmentFactorPresenter(view);
        }

        protected override IPresenter Create(IView view, IPresentationEntity presentationEntity)
        {
            return new AssessmentFactorPresenter(view, presentationEntity);
        }

        public static AssessmentFactorPresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new AssessmentFactorPresenterFactory();
                }

                return _factory;
            }
        }
    }
}
