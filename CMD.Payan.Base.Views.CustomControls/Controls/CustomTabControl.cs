using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMD.Payan.Base.PresentationLayer.Interfaces;
using CMD.Payan.Base.Common;
using Payanar.SS.Net.Libraries.Views.CustomControls;

namespace CMD.Payan.Base.Views.CustomControls
{
    public partial class CustomTabControl : Payanar.SS.Net.Libraries.Views.CustomControls.CustomTabControl, CMD.Payan.Base.Common.IObserver
    {
        #region Constructors

        public CustomTabControl()
            : base()
        {
            InitializeComponent();
            DefaultPageTypeDetail = DefaultPageType.LastPage;
        }

        public CustomTabControl(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IViewContext viewContext)
            : base(viewContext)
        {
            InitializeComponent();
            DefaultPageTypeDetail = DefaultPageType.LastPage;
        }

        #endregion Constructors
    }
}