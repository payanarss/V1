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
    public class TableInformationPresentationEntityCollection : PresentationEntityCollection<TableInformationPresentationEntity>
    {
        public TableInformationPresentationEntityCollection(IPresenter presenter, IBusinessObjectCollection businessObjectCollection)
            : base(presenter, TableInformationPresentationEntityFactory.Factory, businessObjectCollection)
        {
        }

        public TableInformationPresentationEntityCollection(IPresenter presenter)
            : base(presenter, TableInformationPresentationEntityFactory.Factory, TableInformationCollectionFactory.Factory)
        {
        }

        public TableInformationPresentationEntityCollection(IPresenter presenter, IParent parent)
            : base(presenter, TableInformationPresentationEntityFactory.Factory, TableInformationCollectionFactory.Factory, parent)
        {
        }

        public TableInformationPresentationEntityCollection(IObserver observer, IPresenter presenter, IParent parent)
            : base(observer, presenter, TableInformationPresentationEntityFactory.Factory, TableInformationCollectionFactory.Factory, parent)
        {
        }

        public Int64 GetNextSequenceNumber(string tableName)
        {
            return this.FirstOrDefault(eachTable => eachTable.TableName.Equals(tableName)).NextSequenceNumber;
        }
    }
}
