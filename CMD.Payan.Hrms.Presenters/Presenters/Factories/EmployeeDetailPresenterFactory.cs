using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class EmployeeDetailPresenterFactory : PresenterFactory
    {
        private static EmployeeDetailPresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new EmployeeDetailPresenter(view);
        }

        protected override IPresenter Create(IView view, IPresentationEntity presentationEntity)
        {
            return new EmployeeDetailPresenter(view, presentationEntity);
        }

        public static EmployeeDetailPresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new EmployeeDetailPresenterFactory();
                }

                return _factory;
            }
        }
    }
}
