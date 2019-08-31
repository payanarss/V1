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
    public class TableSequanceNumber : BusinessObject, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public TableSequanceNumber()
            : base(TableSequanceNumberEntityFactory.Factory, TableSequanceNumberDatabaseAgentFactory.Factory)
        { }

 	public TableSequanceNumber(IParent parent)
            : base(TableSequanceNumberEntityFactory.Factory, TableSequanceNumberDatabaseAgentFactory.Factory, parent)
        { }

        #endregion Constructors

        #region Properties
	
        public System.String TableName
        {
            get { return TableSequanceNumberEntityDetail.TableName; }
            set { TableSequanceNumberEntityDetail.TableName = value; }
        }

        public System.Int64 SequenceNumber
        {
            get { return TableSequanceNumberEntityDetail.SequenceNumber; }
            set { TableSequanceNumberEntityDetail.SequenceNumber = value; }
        }

        public System.Int64 NextSequenceNumber
        {
            get { return TableSequanceNumberEntityDetail.NextSequenceNumber; }
            set { TableSequanceNumberEntityDetail.NextSequenceNumber = value; }
        }

        public System.DateTime CurrentDate
        {
            get { return TableSequanceNumberEntityDetail.CurrentDate; }
            set { TableSequanceNumberEntityDetail.CurrentDate = value; }
        }

        private TableSequanceNumberEntity TableSequanceNumberEntityDetail
        {
            get { return BusinessEntityObject as TableSequanceNumberEntity; }
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
