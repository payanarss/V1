using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CC.Business.DatabaseAgent.Interface;
using System.Data;
using CC.Business.Entity;


namespace CC.Business.DatabaseAgent
{
    public abstract class EntityDatabaseAgentFactory : IEntityDatabaseAgentFactory
    {
        #region IDatabaseAgentFactory Members

        public abstract IEntityDatabaseAgent Create(IBusinessEntity businessEntity);

        #endregion
    }
}