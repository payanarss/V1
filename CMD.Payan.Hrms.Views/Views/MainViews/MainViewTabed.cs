using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMD.Payan.Base.Views.CustomControls;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;

namespace CMD.Payan.Hrms.Views.MainViews
{
    public partial class MainViewTabed : CustomTabControl
    {
        public MainViewTabed()
        {
            InitializeComponent();
        }

        protected override void AddPages()
        {
            base.AddPages();

            ////IView modelsView = ModelsViewFactory.Factory.Instance();
            ////(modelsView as Payanar.SS.Net.Libraries.Views.CustomControls.BaseView).AddObserver(this);

            IView mainView = MainViewFactory.Factory.Instance();
            (mainView as BaseView).AddObserver(this);

            ////AddNewPage(modelsView);
            AddNewPage(mainView);
        }
    }
}