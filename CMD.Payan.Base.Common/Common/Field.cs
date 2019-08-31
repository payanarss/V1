using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CMD.Payan.Base.Common
{
    public class Field<T> : Payanar.SS.Net.Libraries.Common.Field<T>
    {
        public Field(Payanar.SS.Net.Libraries.Common.IDirty dirtObject) : base(dirtObject) { }
    }
}