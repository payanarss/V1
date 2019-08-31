using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMD.Payan.Base.Common;
using CMD.Payan.Base.PresentationLayer.Interfaces;

namespace CMD.Payan.Base.Views.CustomControls
{
    public class TreeNode : Payanar.SS.Net.Libraries.Views.CustomControls.TreeNode
    {
        public TreeNode(ICommonObject commonObject, string name, string text)
            : base(commonObject, name, text)
        {
        }
    }
}