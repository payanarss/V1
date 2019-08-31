using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PayanarCommon = Payanar.SS.Net.Libraries.Common;
using PayanarPresentationLayerInterfaces = Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using PayanarCustomControls = Payanar.SS.Net.Libraries.Views.CustomControls;
using CMD.Payan.Base.Common;
using CMD.Payan.Base.PresentationLayer.Interfaces;

namespace CMD.Payan.Base.Views.CustomControls
{
    public partial class TreeViewControl : Payanar.SS.Net.Libraries.Views.CustomControls.TreeViewControl
    {
        public TreeViewControl()
            : base()
        {
            InitializeComponent();
        }

        public TreeViewControl(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(presenterFactory)
        {
            InitializeComponent();
        }

        public TreeViewControl(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory)
            : base(observer, presenterFactory)
        {
            InitializeComponent();
        }

        public TreeViewControl(Payanar.SS.Net.Libraries.Common.IObserver observer, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresenterFactory presenterFactory, Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IPresentationEntity presentationEntity)
            : base(observer, presenterFactory, presentationEntity)
        {
            InitializeComponent();
        }

        public TreeViewControl(Payanar.SS.Net.Libraries.PresentationLayer.Interfaces.IViewContext viewContext)
            : base(viewContext)
        {
        }

        protected Payanar.SS.Net.Libraries.Views.CustomControls.TreeNode AddNode(string name, string text)
        {
            return base.AddNode(null, name, text);
        }

        protected Payanar.SS.Net.Libraries.Views.CustomControls.TreeNode AddNode(PayanarCustomControls.TreeNode rootTreeNode, string name, string text)
        {
            return base.AddNode(rootTreeNode, null, name, text);
        }

        protected Payanar.SS.Net.Libraries.Views.CustomControls.TreeNode AddNode(PayanarCustomControls.TreeNode rootTreeNode, string name, string text, PayanarPresentationLayerInterfaces.IViewFactory viewFactory)
        {
            return base.AddNode(rootTreeNode, null, name, text, viewFactory);
        }

        protected Payanar.SS.Net.Libraries.Views.CustomControls.TreeNode AddNode(PayanarCustomControls.TreeNode rootTreeNode, string name, string text, PayanarPresentationLayerInterfaces.IViewFactory viewFactory, PayanarPresentationLayerInterfaces.IViewContext viewContext)
        {
            return base.AddNode(rootTreeNode, null, name, text, viewFactory, viewContext);
        }
    }
}