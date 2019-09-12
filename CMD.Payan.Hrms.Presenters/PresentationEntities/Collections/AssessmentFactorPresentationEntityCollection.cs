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
    public class AssessmentFactorPresentationEntityCollection : PresentationEntityCollection<AssessmentFactorPresentationEntity>
    {
        public AssessmentFactorPresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, AssessmentFactorPresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public AssessmentFactorPresentationEntityCollection(IPresenter presenter)
            : base(presenter, AssessmentFactorPresentationEntityFactory.Factory, AssessmentFactorCollectionFactory.Factory)
        {
        }

        public AssessmentFactorPresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, AssessmentFactorPresentationEntityFactory.Factory, AssessmentFactorCollectionFactory.Factory, parent)
        {
        }

        public AssessmentFactorPresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, AssessmentFactorPresentationEntityFactory.Factory, AssessmentFactorCollectionFactory.Factory, parent)
        {
        }
    }
}
