using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Collections;

namespace CMD.Payan.Base.Common
{
    public class BaseCollection<T> : Payanar.SS.Net.Libraries.Common.BaseCollection<T>
    {
    }

    public class PropertyComparer<T> : Payanar.SS.Net.Libraries.Common.PropertyComparer<T>
    {
        public PropertyComparer(string sortPropert, ListSortDirection listSortDirection) : base(sortPropert, listSortDirection) { }
    }
}