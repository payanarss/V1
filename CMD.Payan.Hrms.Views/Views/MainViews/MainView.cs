using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PayanarCustomControls = Payanar.SS.Net.Libraries.Views.CustomControls;
using PayanarPresentationLayerInterfaces = Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using CMD.Payan.Base.Views.CustomControls;

namespace CMD.Payan.Hrms.Views
{
    public partial class MainView : CMD.Payan.Base.Views.CustomControls.BaseView
    {
        public MainView()
        {
            InitializeComponent();
            this.Title = "Payanar.SS";
            menuExplorerView.AddObserver(this);
        }

        public override void LoadDatas()
        {
            base.LoadDatas();
            menuExplorerView.LoadDatas();
        }

        public override void UpdateObserver(object value, string message)
        {
            switch (message)
            {
                case "OpenView":
                    OpenView(value as Payanar.SS.Net.Libraries.Views.CustomControls.BaseView);
                    break;
                case "Open New Bill":
                case "Open New Bill A/c":
                    break;
            }
        }

        private void OpenView(Payanar.SS.Net.Libraries.Views.CustomControls.BaseView baseView)
        {
            mainDataViews.ShowView(baseView as Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView);
        }
    }
}