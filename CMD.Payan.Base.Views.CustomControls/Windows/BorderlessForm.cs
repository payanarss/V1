using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMD.Payan.Base.Views.CustomControls
{
    public partial class BorderlessForm : Payanar.SS.Net.Libraries.Views.CustomControls.BorderlessForm
    {
        public BorderlessForm()
            : base()
        {
            InitializeComponent();
        }

        public BorderlessForm(BaseView baseView)
            : base(baseView)
        {
            InitializeComponent();
        }
    }
}