using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMD.Payan.Base.Views.Controls
{
    public partial class SplitContainer : Payanar.SS.Net.Libraries.Views.Controls.SplitContainer
    {
        public SplitContainer()
        {
            InitializeComponent();
            SplitterWidth = 2;
        }

        public SplitContainer(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            SplitterWidth = 2;
        }
    }
}