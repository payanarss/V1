using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class InterviewFormDetailsPresenterFactory : PresenterFactory
    {
        private static InterviewFormDetailsPresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new InterviewFormDetailsPresenter(view);
        }

        protected override IPresenter Create(IView view, IPresentationEntity presentationEntity)
        {
            return new InterviewFormDetailsPresenter(view, presentationEntity);
        }

        public static InterviewFormDetailsPresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFormDetailsPresenterFactory();
                }

                return _factory;
            }
        }
    }
}
