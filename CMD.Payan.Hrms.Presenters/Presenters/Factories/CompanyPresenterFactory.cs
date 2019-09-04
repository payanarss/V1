using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class CompanyPresenterFactory : PresenterFactory
    {
        private static CompanyPresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new CompanyPresenter(view);
        }

        protected override IPresenter Create(IView view, IPresentationEntity presentationEntity)
        {
            return new CompanyPresenter(view, presentationEntity);
        }

        public static CompanyPresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new CompanyPresenterFactory();
                }

                return _factory;
            }
        }
    }
}
