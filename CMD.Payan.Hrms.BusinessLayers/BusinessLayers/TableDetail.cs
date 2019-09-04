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
    public class TableDetail : BusinessObject, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public TableDetail()
            : base(TableDetailEntityFactory.Factory, TableDetailDatabaseAgentFactory.Factory)
        { }

 	public TableDetail(IParent parent)
            : base(TableDetailEntityFactory.Factory, TableDetailDatabaseAgentFactory.Factory, parent)
        { }

        #endregion Constructors

        #region Properties
	
        public System.String TableName
        {
            get { return TableDetailEntityDetail.TableName; }
            set { TableDetailEntityDetail.TableName = value; }
        }

        public System.Int64 SequenceNumber
        {
            get { return TableDetailEntityDetail.SequenceNumber; }
            set { TableDetailEntityDetail.SequenceNumber = value; }
        }

        public System.Int64 NextSequenceNumber
        {
            get { return TableDetailEntityDetail.NextSequenceNumber; }
            set { TableDetailEntityDetail.NextSequenceNumber = value; }
        }

        public System.DateTime CurrentDate
        {
            get { return TableDetailEntityDetail.CurrentDate; }
            set { TableDetailEntityDetail.CurrentDate = value; }
        }

        private TableDetailEntity TableDetailEntityDetail
        {
            get { return BusinessEntityObject as TableDetailEntity; }
        }

        #endregion Properties

        #region Methods

        #region Public

        public override int Load()
        {
            int result = 0;

            result += base.Load();

            return result;
        }

        #endregion Public

        #region Protected

        protected override bool ValidateBeforeSave()
        {
            bool isValid = base.ValidateBeforeSave();

            return isValid;
        }

        protected override bool ValidateBeforeDelete()
        {
            bool isValid = base.ValidateBeforeDelete();

            return isValid;
        }

        #endregion Protected

	#endregion Methods
    }
}
