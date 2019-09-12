using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class ExitInterviewFactorPresenterFactory : PresenterFactory
    {
        private static ExitInterviewFactorPresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new ExitInterviewFactorPresenter(view);
        }

        protected override IPresenter Create(IView view, IPresentationEntity presentationEntity)
        {
            return new ExitInterviewFactorPresenter(view, presentationEntity);
        }

        public static ExitInterviewFactorPresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new ExitInterviewFactorPresenterFactory();
                }

                return _factory;
            }
        }
    }
}
