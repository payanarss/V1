using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Base.PresentationLayer.Interfaces
{
    public class ViewContext : Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.ViewContext
    {
        public ViewContext() : base() { }

        public ViewContext(string pageName, string title)
            : base(pageName, title)
        {
        }

        public ViewContext(string pageName, string title, string message)
            : base(pageName, title, message)
        {
        }

        public ViewContext(string pageName, string title, string message, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(pageName, title, message, presentationEntity)
        {
        }

        public ViewContext(string pageName, string title, string message, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntityCollection presentationEntityCollection)
            : base(pageName, title, message, presentationEntityCollection)
        {
        }

        public ViewContext(string pageName, string title, string message, object value)
            : base(pageName, title, message, value)
        {
        }
    }
}