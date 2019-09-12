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
    public class TableInformation : BusinessObject, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public TableInformation()
            : base(TableInformationEntityFactory.Factory, TableInformationDatabaseAgentFactory.Factory)
        { }

 	public TableInformation(IParent parent)
            : base(TableInformationEntityFactory.Factory, TableInformationDatabaseAgentFactory.Factory, parent)
        { }

        #endregion Constructors

        #region Properties
	
        public System.String TableName
        {
            get { return TableInformationEntityDetail.TableName; }
            set { TableInformationEntityDetail.TableName = value; }
        }

        public System.Int64 SequenceNumber
        {
            get { return TableInformationEntityDetail.SequenceNumber; }
            set { TableInformationEntityDetail.SequenceNumber = value; }
        }

        public System.Int64 NextSequenceNumber
        {
            get { return SequenceNumber + 1; }
            set { TableInformationEntityDetail.NextSequenceNumber = value; }
        }

        public System.DateTime CurrentDate
        {
            get { return TableInformationEntityDetail.CurrentDate; }
            set { TableInformationEntityDetail.CurrentDate = value; }
        }

        public System.Int64 OpeningSequenceNumber
        {
            get { return TableInformationEntityDetail.OpeningSequenceNumber; }
            set { TableInformationEntityDetail.OpeningSequenceNumber = value; }
        }

        private TableInformationEntity TableInformationEntityDetail
        {
            get { return BusinessEntityObject as TableInformationEntity; }
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
