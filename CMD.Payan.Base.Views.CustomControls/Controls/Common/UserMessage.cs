using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMD.Payan.Base.Common;

namespace CMD.Payan.Base.Views.CustomControls
{
    public class UserMessage
    {
        public static CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult ShowMessage(string message, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon)
        {
            return DialogResultConverter.Convert(System.Windows.Forms.MessageBox.Show(message, MyApplication.ProjectInfoDetail.DialogTitle, messageBoxButtons, messageBoxIcon));
        }

        public static System.Windows.Forms.DialogResult ShowWindowsMessage(string message, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon)
        {
            return System.Windows.Forms.MessageBox.Show(message, MyApplication.ProjectInfoDetail.DialogTitle, messageBoxButtons, messageBoxIcon);
        }

        public static CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult ShowOkCancelMessage(string message)
        {
            return ShowMessage(message, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        public static System.Windows.Forms.DialogResult ShowYesNoCancelMessage(string message)
        {
            return ShowWindowsMessage(message, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        public static System.Windows.Forms.DialogResult ShowYesNoMessage(string message)
        {
            return ShowWindowsMessage(message, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        public static CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult ShowSuccessMessage(string message)
        {
            return ShowMessage(message, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult ShowWarningMessage(string message)
        {
            return ShowMessage(message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static CMD.Payan.Base.PresentationLayer.Interfaces.DialogResult ShowErrorMessage(string message)
        {
            return ShowMessage(message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}