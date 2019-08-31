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
    public partial class ViewForm : Payanar.SS.Net.Libraries.Views.CustomControls.ViewForm
    {
        public ViewForm()
            : base()
        {
            InitializeComponent();
        }

        public ViewForm(BaseView view)
            : base(view)
        {
        }
    }
}