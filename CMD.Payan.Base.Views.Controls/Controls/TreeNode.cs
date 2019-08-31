using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMD.Payan.Base.Views.Controls
{
    public class TreeNode : Payanar.SS.Net.Libraries.Views.Controls.TreeNode
    {
        public TreeNode() : base() { }
        public TreeNode(string text) : base(text) { }
        public TreeNode(string name, string text) : base(text) 
        {
            Name = name;
        }
    }
}