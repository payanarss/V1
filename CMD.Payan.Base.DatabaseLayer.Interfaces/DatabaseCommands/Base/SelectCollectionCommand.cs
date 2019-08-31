using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using Bhu.Payanar.Apps.Net.BusinessEntity.Interfaces;
using Bhu.Payanar.Apps.Net.Common;
using Bhu.Payanar.Apps.Net.BusinessLayer.Interfaces;

namespace Bhu.Payanar.Apps.Net.DatabaseLayer.Interfaces
{
    public abstract class SelectCollectionCommand : SelectCommand
    {
        public SelectCollectionCommand(IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
        }

        public SelectCollectionCommand(IBusinessObjectCollection businessObjectCollection, long uniqueIdentifier)
            : base(businessObjectCollection, uniqueIdentifier)
        {
        }

        protected override IBusinessObject GetBusinessObjectDetail()
        {
            return BusinessObjectCollection.AddNew();
        }
    }
}