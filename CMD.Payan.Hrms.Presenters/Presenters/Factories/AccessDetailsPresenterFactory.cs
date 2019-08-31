using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class AccessDetailsPresenterFactory : PresenterFactory
    {
        private static AccessDetailsPresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new AccessDetailsPresenter(view);
        }

        protected override IPresenter Create(IView view, IPresentationEntity presentationEntity)
        {
            return new AccessDetailsPresenter(view, presentationEntity);
        }

        public static AccessDetailsPresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new AccessDetailsPresenterFactory();
                }

                return _factory;
            }
        }
    }
}
