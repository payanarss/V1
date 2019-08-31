using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMD.Payan.Base.PresentationLayer.Interfaces;
using CMD.Payan.Base.Common;

namespace CMD.Payan.Base.Views.CustomControls
{
    public partial class LoginForm : Payanar.SS.Net.Libraries.Views.CustomControls.LoginForm
    {
        #region Constructors

        public LoginForm()
            : base()
        {
            InitializeComponent();
        }

        public LoginForm(string title)
            : base(title)
        {
            InitializeComponent();
        }

        #endregion Constructors
    }
}