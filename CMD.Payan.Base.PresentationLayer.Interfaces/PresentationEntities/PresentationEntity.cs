using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.BusinessLayer.Interfaces;
using System.Drawing;
using CMD.Payan.Base.Common;
using System.ComponentModel;

namespace CMD.Payan.Base.PresentationLayer.Interfaces
{
    public class PresentationEntity : Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.PresentationEntity
    {
        #region Constructors

        public PresentationEntity() : base() { }

        public PresentationEntity(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectFactory businessObjectFactory)
            : base(presenter, businessObjectFactory)
        {
        }

        public PresentationEntity(IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectFactory businessObjectFactory, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(presenter, businessObjectFactory, parent)
        {
        }

        public PresentationEntity(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public PresentationEntity(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObject businessObject, Payanar.SS.Net.Libraries.Common.IParent parent)
            : this()
        {
        }

        public PresentationEntity(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectFactory businessObjectFactory)
            : base(observer, presenter, businessObjectFactory)
        {
        }

        public PresentationEntity(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectFactory businessObjectFactory, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(observer, presenter, businessObjectFactory, parent)
        {
        }

        public PresentationEntity(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public PresentationEntity(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenter presenter, Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObject businessObject, Payanar.SS.Net.Libraries.Common.IParent parent)
            : base(observer, presenter, businessObject, parent)
        {
        }

        #endregion Constructors
    }
}