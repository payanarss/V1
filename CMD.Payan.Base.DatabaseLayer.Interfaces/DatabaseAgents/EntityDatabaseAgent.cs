using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bhu.Payanar.Apps.Net.DatabaseLayer.Interfaces.Interface;
using CC.Business.Layer;
using CC.Business.Entity;


namespace Bhu.Payanar.Apps.Net.DatabaseLayer.Interfaces
{
    public class EntityDatabaseAgent : DatabaseAgent, IEntityDatabaseAgent
    {
        private IBusinessEntity _businessEntityObject = null;
        private ICommand _insertCommand = null;
        private ICommand _updateCommand = null;
        private ICommand _deleteCommand = null;

        public EntityDatabaseAgent(IBusinessEntity businessEntityObject)
        {
            BusinessEntityObject = businessEntityObject;
        }

        #region IDatabaseAgent Members

        public int Insert()
        {
            return ExecuteCommand(InsertCommand);
        }

        public int Update()
        {
            return ExecuteCommand(UpdateCommand);
        }

        public int Delete()
        {
            return ExecuteCommand(DeleteCommand);
        }

        #endregion

        #region Protected Members

        protected IBusinessEntity BusinessEntityObject
        {
            get { return _businessEntityObject; }
            set { _businessEntityObject = value; }
        }

        protected ICommand InsertCommand
        {
            get { return _insertCommand; }
            set { _insertCommand = value; }
        }

        protected ICommand UpdateCommand
        {
            get { return _updateCommand; }
            set { _updateCommand = value; }
        }

        protected ICommand DeleteCommand
        {
            get { return _deleteCommand; }
            set { _deleteCommand = value; }
        }

        #endregion Private Members
    }
}