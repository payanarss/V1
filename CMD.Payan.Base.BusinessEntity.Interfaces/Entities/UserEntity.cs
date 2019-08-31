using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMD.Payan.Base.Common;
using Payanar.SS.Net.Libraries.Common;

namespace CMD.Payan.Base.BusinessEntity.Interfaces
{
    public class UserEntity : Payanar.SS.Net.Libraries.BusinessEntity.Interfaces.UserEntity
    {
        #region Constructors

        public UserEntity()
            : base()
        {
        }

        public UserEntity(IParent parent)
            : base(parent)
        {
        }

        #endregion Constructors
    }
}