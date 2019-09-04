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
    public class Company : BusinessObject, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public Company()
            : base(CompanyEntityFactory.Factory, CompanyDatabaseAgentFactory.Factory)
        { }

 	public Company(IParent parent)
            : base(CompanyEntityFactory.Factory, CompanyDatabaseAgentFactory.Factory, parent)
        { }

        #endregion Constructors

        #region Properties
	
        public System.String CompanyAddress1
        {
            get { return CompanyEntityDetail.CompanyAddress1; }
            set { CompanyEntityDetail.CompanyAddress1 = value; }
        }

        public System.String CompanyAddress2
        {
            get { return CompanyEntityDetail.CompanyAddress2; }
            set { CompanyEntityDetail.CompanyAddress2 = value; }
        }

        public System.String CompanyAddress3
        {
            get { return CompanyEntityDetail.CompanyAddress3; }
            set { CompanyEntityDetail.CompanyAddress3 = value; }
        }

        public System.String CompanyAddress4
        {
            get { return CompanyEntityDetail.CompanyAddress4; }
            set { CompanyEntityDetail.CompanyAddress4 = value; }
        }

        public System.String CompanyName
        {
            get { return CompanyEntityDetail.CompanyName; }
            set { CompanyEntityDetail.CompanyName = value; }
        }

        public System.String CompanyName1
        {
            get { return CompanyEntityDetail.CompanyName1; }
            set { CompanyEntityDetail.CompanyName1 = value; }
        }

        public System.String CompanyCode
        {
            get { return CompanyEntityDetail.CompanyCode; }
            set { CompanyEntityDetail.CompanyCode = value; }
        }

        private CompanyEntity CompanyEntityDetail
        {
            get { return BusinessEntityObject as CompanyEntity; }
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
