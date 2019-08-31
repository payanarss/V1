using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class TableSequanceNumberPresenterFactory : PresenterFactory
    {
        private static TableSequanceNumberPresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new TableSequanceNumberPresenter(view);
        }

        protected override IPresenter Create(IView view, IPresentationEntity presentationEntity)
        {
            return new TableSequanceNumberPresenter(view, presentationEntity);
        }

        public static TableSequanceNumberPresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new TableSequanceNumberPresenterFactory();
                }

                return _factory;
            }
        }
    }
}
