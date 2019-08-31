using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Base.Views.Controls
{
    public class Binding : Payanar.SS.Net.Libraries.Views.Controls.Binding
    {
        public Binding(string propertyName, object dataSource, string dataMember)
            : base(propertyName, dataSource, dataMember)
        {
        }
    }
}