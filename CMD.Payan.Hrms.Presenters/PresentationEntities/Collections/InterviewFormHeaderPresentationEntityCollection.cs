using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.Common;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using CMD.Payan.Hrms.BusinessLayers;

namespace CMD.Payan.Hrms.Presenters
{
    public class InterviewFormHeaderPresentationEntityCollection : PresentationEntityCollection<InterviewFormHeaderPresentationEntity>
    {
        public InterviewFormHeaderPresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, InterviewFormHeaderPresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public InterviewFormHeaderPresentationEntityCollection(IPresenter presenter)
            : base(presenter, InterviewFormHeaderPresentationEntityFactory.Factory, InterviewFormHeaderCollectionFactory.Factory)
        {
        }

        public InterviewFormHeaderPresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, InterviewFormHeaderPresentationEntityFactory.Factory, InterviewFormHeaderCollectionFactory.Factory, parent)
        {
        }

        public InterviewFormHeaderPresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, InterviewFormHeaderPresentationEntityFactory.Factory, InterviewFormHeaderCollectionFactory.Factory, parent)
        {
        }
    }
}
