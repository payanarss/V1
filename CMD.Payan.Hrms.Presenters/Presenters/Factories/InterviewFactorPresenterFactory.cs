using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class InterviewFactorPresenterFactory : PresenterFactory
    {
        private static InterviewFactorPresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new InterviewFactorPresenter(view);
        }

        protected override IPresenter Create(IView view, IPresentationEntity presentationEntity)
        {
            return new InterviewFactorPresenter(view, presentationEntity);
        }

        public static InterviewFactorPresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFactorPresenterFactory();
                }

                return _factory;
            }
        }
    }
}
