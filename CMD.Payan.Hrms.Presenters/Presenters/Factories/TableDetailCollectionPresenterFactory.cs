using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Presenters
{
    public class TableDetailCollectionPresenterFactory : PresenterFactory
    {
        private static IPresenterFactory _factory;

        protected override IPresenter Create(IView view)
        {
            return new TableDetailCollectionPresenter(view);
        }

        public static IPresenterFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new TableDetailCollectionPresenterFactory();
                }

                return _factory;
            }
        }
    }
}
