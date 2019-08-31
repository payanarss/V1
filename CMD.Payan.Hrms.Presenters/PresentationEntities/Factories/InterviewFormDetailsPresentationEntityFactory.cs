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
    public class InterviewFormDetailsPresentationEntityFactory : PresentationEntityFactory
    {
        private static IPresentationEntityFactory _factory;

        protected override IPresentationEntity Create(IPresenter presenter)
        {
            return new InterviewFormDetailsPresentationEntity(presenter);
        }

        protected override IPresentationEntity Create(IPresenter presenter, IBusinessObject businessObject)
        {
            return new InterviewFormDetailsPresentationEntity(presenter, businessObject);
        }

        protected override IPresentationEntity Create(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
        {
            return new InterviewFormDetailsPresentationEntity(observer, presenter, businessObject);
        }

        protected override IPresentationEntity Create(IObserver observer, IPresenter presenter)
        {
            return new InterviewFormDetailsPresentationEntity(observer, presenter);
        }

        public static IPresentationEntityFactory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new InterviewFormDetailsPresentationEntityFactory();
                }

                return _factory;
            }
        }
    }
}
