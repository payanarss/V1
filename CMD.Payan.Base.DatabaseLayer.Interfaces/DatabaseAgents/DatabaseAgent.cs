using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CMD.Payan.Base.BusinessLayer.Interfaces;
using CMD.Payan.Base.Common;
using CMD.Payan.Base.BusinessEntity.Interfaces;

namespace CMD.Payan.Base.DatabaseLayer.Interfaces
{
    public class DatabaseAgent : Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.DatabaseAgent
    {
        #region Constructors

        public DatabaseAgent()
            : base()
        {
        }

        public DatabaseAgent(Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObject businessObject)
            : base(businessObject)
        {
        }

        public DatabaseAgent(Payanar.SS.Net.Libraries.BusinessLayer.Interfaces.IBusinessObjectCollection businessObjectCollection)
            : base(businessObjectCollection)
        {
        }

        #endregion Constructors

        #region Methods

        protected override Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.IDatabaseFactory GetDatabaseFactoryDetail()
        {
            Payanar.SS.Net.Libraries.DatabaseLayer.Interfaces.IDatabaseFactory databaseFactory = null;

            string databaseFactoryName = System.Configuration.ConfigurationSettings.AppSettings["DatabaseFactory"];

            switch (databaseFactoryName)
            {
                case "SQLConnectionString":
                    databaseFactory = Payanar.SS.Net.Libraries.DatabaseLayer.MSSqlDatabaseFactory.Factory;
                    break;
                case "SQLCeConnectionString":
                    databaseFactory = Payanar.SS.Net.Libraries.DatabaseLayer.MSSqlCeDatabaseFactory.Factory;
                    break;
                case "MSAccessConnectionString":
                    databaseFactory = Payanar.SS.Net.Libraries.DatabaseLayer.MSAccessDatabaseFactory.Factory;
                    break;
                default:
                    throw new Exception("The specified Database factory is not correct.");
            }

            return databaseFactory;
        }

        #endregion
    }
}