using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMD.Payan.Base.Common;
using CMD.Payan.Base.PresentationLayer.Interfaces;

namespace CMD.Payan.Base.Views.CustomControls
{
    public partial class SearchWindow : Payanar.SS.Net.Libraries.Views.CustomControls.SearchWindow, CMD.Payan.Base.Common.IObserver
    {
        public SearchWindow():base()
        {
        }

        public SearchWindow(CMD.Payan.Base.Views.CustomControls.DataGridView dataGridView)
            : base(dataGridView)
        {
            InitializeComponent();
        }
    }
}