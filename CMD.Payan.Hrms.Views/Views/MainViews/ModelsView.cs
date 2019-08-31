using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMD.Payan.Hrms.Views
{
    public partial class ModelsView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView ////: Payanar.Net.Views.Views.MainView
    {
        public ModelsView()
        {
            InitializeComponent();
            this.Title = "Models";
        }

        public override void LoadDatas()
        {
            base.LoadDatas();
            ////mainView.LoadDatas();
        }
    }
}