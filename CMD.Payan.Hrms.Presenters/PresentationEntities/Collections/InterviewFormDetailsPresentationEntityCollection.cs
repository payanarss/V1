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
    public class InterviewFormDetailsPresentationEntityCollection : PresentationEntityCollection<InterviewFormDetailsPresentationEntity>
    {
        public InterviewFormDetailsPresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, InterviewFormDetailsPresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public InterviewFormDetailsPresentationEntityCollection(IPresenter presenter)
            : base(presenter, InterviewFormDetailsPresentationEntityFactory.Factory, InterviewFormDetailsCollectionFactory.Factory)
        {
        }

        public InterviewFormDetailsPresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, InterviewFormDetailsPresentationEntityFactory.Factory, InterviewFormDetailsCollectionFactory.Factory, parent)
        {
        }

        public InterviewFormDetailsPresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, InterviewFormDetailsPresentationEntityFactory.Factory, InterviewFormDetailsCollectionFactory.Factory, parent)
        {
        }
    }
}
