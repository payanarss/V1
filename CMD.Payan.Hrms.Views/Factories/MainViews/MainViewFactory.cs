using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayanarCommon = Payanar.SS.Net.Libraries.Common;
using PayanarPresentationLayerInterfaces = Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using BasePresentationLayerInterfaces = CMD.Payan.Base.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Views
{
    public class MainViewFactory : BasePresentationLayerInterfaces.ViewFactory
    {
        private static PayanarPresentationLayerInterfaces.IViewFactory _factory;

        public static PayanarPresentationLayerInterfaces.IViewFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new MainViewFactory();
                }

                return _factory;
            }
        }

        protected override PayanarPresentationLayerInterfaces.IView Create()
        {
            return new MainView();
        }

        protected override PayanarPresentationLayerInterfaces.IView Create(PayanarPresentationLayerInterfaces.IViewContext viewContext)
        {
            return new MainView();
        }
    }
}