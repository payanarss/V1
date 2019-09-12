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
    public class InterviewFactorPresentationEntityCollection : PresentationEntityCollection<InterviewFactorPresentationEntity>
    {
        public InterviewFactorPresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, InterviewFactorPresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public InterviewFactorPresentationEntityCollection(IPresenter presenter)
            : base(presenter, InterviewFactorPresentationEntityFactory.Factory, InterviewFactorCollectionFactory.Factory)
        {
        }

        public InterviewFactorPresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, InterviewFactorPresentationEntityFactory.Factory, InterviewFactorCollectionFactory.Factory, parent)
        {
        }

        public InterviewFactorPresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, InterviewFactorPresentationEntityFactory.Factory, InterviewFactorCollectionFactory.Factory, parent)
        {
        }
    }
}
