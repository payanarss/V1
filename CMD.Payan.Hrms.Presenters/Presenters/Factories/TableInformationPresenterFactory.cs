using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class TableInformationPresenterFactory : PresenterFactory
    {
        private static TableInformationPresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new TableInformationPresenter(view);
        }

        protected override IPresenter Create(IView view, IPresentationEntity presentationEntity)
        {
            return new TableInformationPresenter(view, presentationEntity);
        }

        public static TableInformationPresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new TableInformationPresenterFactory();
                }

                return _factory;
            }
        }
    }
}
