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
    public class ExitInterviewFactorPresentationEntityCollection : PresentationEntityCollection<ExitInterviewFactorPresentationEntity>
    {
        public ExitInterviewFactorPresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, ExitInterviewFactorPresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public ExitInterviewFactorPresentationEntityCollection(IPresenter presenter)
            : base(presenter, ExitInterviewFactorPresentationEntityFactory.Factory, ExitInterviewFactorCollectionFactory.Factory)
        {
        }

        public ExitInterviewFactorPresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, ExitInterviewFactorPresentationEntityFactory.Factory, ExitInterviewFactorCollectionFactory.Factory, parent)
        {
        }

        public ExitInterviewFactorPresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, ExitInterviewFactorPresentationEntityFactory.Factory, ExitInterviewFactorCollectionFactory.Factory, parent)
        {
        }
    }
}
