using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class AppointmentOrderFactorPresenterFactory : PresenterFactory
    {
        private static AppointmentOrderFactorPresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new AppointmentOrderFactorPresenter(view);
        }

        protected override IPresenter Create(IView view, IPresentationEntity presentationEntity)
        {
            return new AppointmentOrderFactorPresenter(view, presentationEntity);
        }

        public static AppointmentOrderFactorPresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new AppointmentOrderFactorPresenterFactory();
                }

                return _factory;
            }
        }
    }
}
