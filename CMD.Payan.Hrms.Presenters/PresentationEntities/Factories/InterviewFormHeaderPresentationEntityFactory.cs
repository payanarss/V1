using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;
using CMD.Payan.Hrms.BusinessLayers;

namespace CMD.Payan.Hrms.Presenters
{
    public class InterviewFormHeaderPresentationEntityFactory : PresentationEntityFactory
    {
        private static IPresentationEntityFactory _factory;

        protected override IPresentationEntity Create(IPresenter presenter)
        {
            return new InterviewFormHeaderPresentationEntity(presenter);
        }

        protected override IPresentationEntity Create(IPresenter presenter, IBusinessObject businessObject)
        {
            return new InterviewFormHeaderPresentationEntity(presenter, businessObject);
        }

        protected override IPresentationEntity Create(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
        {
            return new InterviewFormHeaderPresentationEntity(observer, presenter, businessObject);
        }

        protected override IPresentationEntity Create(IObserver observer, IPresenter presenter)
        {
            return new InterviewFormHeaderPresentationEntity(observer, presenter);
        }

        public static IPresentationEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFormHeaderPresentationEntityFactory();
                }

                return _factory;
            }
        }
    }
}
