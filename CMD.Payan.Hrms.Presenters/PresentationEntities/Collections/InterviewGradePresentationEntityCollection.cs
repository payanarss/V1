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
    public class InterviewGradePresentationEntityCollection : PresentationEntityCollection<InterviewGradePresentationEntity>
    {
        public InterviewGradePresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, InterviewGradePresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public InterviewGradePresentationEntityCollection(IPresenter presenter)
            : base(presenter, InterviewGradePresentationEntityFactory.Factory, InterviewGradeCollectionFactory.Factory)
        {
        }

        public InterviewGradePresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, InterviewGradePresentationEntityFactory.Factory, InterviewGradeCollectionFactory.Factory, parent)
        {
        }

        public InterviewGradePresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, InterviewGradePresentationEntityFactory.Factory, InterviewGradeCollectionFactory.Factory, parent)
        {
        }
    }
}
