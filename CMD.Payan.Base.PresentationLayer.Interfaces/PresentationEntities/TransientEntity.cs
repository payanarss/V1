using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.BusinessLayer.Interfaces;
using System.Drawing;
using CMD.Payan.Base.Common;

namespace CMD.Payan.Base.PresentationLayer.Interfaces
{
    public class TransientEntity : Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.TransientEntity
    {
        #region Constructors

        public TransientEntity(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectFactory businessObjectFactory) :
            base(presenter, businessObjectFactory)
        {
        }

        public TransientEntity(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectFactory businessObjectFactory, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(presenter, businessObjectFactory, parent)
        {
        }

        public TransientEntity(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public TransientEntity(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, IBusinessObject businessObject, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(presenter, businessObject, parent)
        {
        }

        public TransientEntity(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectFactory businessObjectFactory)
            : base(observer, presenter, businessObjectFactory)
        {
        }

        public TransientEntity(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectFactory businessObjectFactory, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(observer, presenter, businessObjectFactory, parent)
        {
        }

        public TransientEntity(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public TransientEntity(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObject businessObject, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(observer, presenter, businessObject, parent)
        {
        }

        #endregion Constructors
    }
}