using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.BusinessLayer.Interfaces;
using CMD.Payan.Base.BusinessEntity.Interfaces;
using CMD.Payan.Base.DatabaseLayer.Interfaces;

namespace CMD.Payan.Base.BusinessLayer
{
    public class User : Payanar.SS.Net.Libraries.BusinessLayer.User
    {
        #region Constructors

        public User()
            : base()
        { }

        public User(Payanar.SS.Net.Libraries.Common.IParent parrent)
            : base(parrent)
        { }

        #endregion Constructors
    }
}