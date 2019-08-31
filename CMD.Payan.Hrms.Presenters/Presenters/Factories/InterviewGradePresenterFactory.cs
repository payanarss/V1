using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class InterviewGradePresenterFactory : PresenterFactory
    {
        private static InterviewGradePresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new InterviewGradePresenter(view);
        }

        protected override IPresenter Create(IView view, IPresentationEntity presentationEntity)
        {
            return new InterviewGradePresenter(view, presentationEntity);
        }

        public static InterviewGradePresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewGradePresenterFactory();
                }

                return _factory;
            }
        }
    }
}
