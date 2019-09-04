using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class TableDetailPresenterFactory : PresenterFactory
    {
        private static TableDetailPresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new TableDetailPresenter(view);
        }

        protected override IPresenter Create(IView view, IPresentationEntity presentationEntity)
        {
            return new TableDetailPresenter(view, presentationEntity);
        }

        public static TableDetailPresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new TableDetailPresenterFactory();
                }

                return _factory;
            }
        }
    }
}
