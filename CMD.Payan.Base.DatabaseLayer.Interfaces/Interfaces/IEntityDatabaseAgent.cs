using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bhu.Payanar.Apps.Net.DatabaseLayer.Interfaces.Interface
{
    public interface IEntityDatabaseAgent : IDatabaseAgent
    {
        int Insert();
        int Update();
        int Delete();
    }
}