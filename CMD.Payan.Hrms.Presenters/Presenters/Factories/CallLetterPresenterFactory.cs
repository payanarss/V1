using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class CallLetterPresenterFactory : PresenterFactory
    {
        private static CallLetterPresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new CallLetterPresenter(view);
        }

        protected override IPresenter Create(IView view, IPresentationEntity presentationEntity)
        {
            return new CallLetterPresenter(view, presentationEntity);
        }

        public static CallLetterPresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new CallLetterPresenterFactory();
                }

                return _factory;
            }
        }
    }
}
