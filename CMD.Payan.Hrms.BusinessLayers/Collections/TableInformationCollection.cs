using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.Common;
using CMD.Payan.Hrms.BusinessEntities;
using CMD.Payan.Hrms.DatabaseLayer;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class TableInformationCollection : BusinessObjectCollection<TableInformation>
    {
        #region Constructors

        public TableInformationCollection()
            : base(TableInformationFactory.Factory, TableInformationDatabaseAgentFactory.Factory)
        { }

        public TableInformationCollection(IParent parent)
            : base(TableInformationFactory.Factory, TableInformationDatabaseAgentFactory.Factory, parent)
        {
        }

        #endregion Constructors

        #region Methods

        public override void WhereParameters()
        {
            base.WhereParameters();
        }

        #endregion
    }
}
