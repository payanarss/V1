using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class PayanarApplicationPresenterFactory : PresenterFactory
    {
        private static PayanarApplicationPresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new PayanarApplicationPresenter(view);
        }

        protected override IPresenter Create(IView view, IPresentationEntity presentationEntity)
        {
            return new PayanarApplicationPresenter(view, presentationEntity);
        }

        public static PayanarApplicationPresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new PayanarApplicationPresenterFactory();
                }

                return _factory;
            }
        }
    }
}
