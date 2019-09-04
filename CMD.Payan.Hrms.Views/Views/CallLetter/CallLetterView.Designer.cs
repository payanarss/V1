
namespace CMD.Payan.Hrms.Views
{
    public partial class CallLetterView 
    {
/// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.callLetterNumberTextBox1 = new CMD.Payan.Hrms.Views.CallLetterNumberTextBox();
            this.callLetterDateDateTimePicker1 = new CMD.Payan.Hrms.Views.CallLetterDateDateTimePicker();
            this.TaskBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.BodyPanel.SuspendLayout();
            this.ToolBarPanel.SuspendLayout();
            this.closePanel.SuspendLayout();
            this.BasePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskBarPanel
            // 
            this.TaskBarPanel.Size = new System.Drawing.Size(605, 22);
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.callLetterDateDateTimePicker1);
            this.BodyPanel.Controls.Add(this.callLetterNumberTextBox1);
            this.BodyPanel.Location = new System.Drawing.Point(0, 44);
            this.BodyPanel.Size = new System.Drawing.Size(605, 293);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.Size = new System.Drawing.Size(605, 22);
            // 
            // AdditionalMenuButtonsPanel
            // 
            this.AdditionalMenuButtonsPanel.Size = new System.Drawing.Size(427, 18);
            // 
            // closePanel
            // 
            this.closePanel.Location = new System.Drawing.Point(580, 2);
            // 
            // BasePanel
            // 
            this.BasePanel.Size = new System.Drawing.Size(605, 337);
            // 
            // callLetterNumberTextBox1
            // 
            this.callLetterNumberTextBox1.Location = new System.Drawing.Point(55, 23);
            this.callLetterNumberTextBox1.Name = "callLetterNumberTextBox1";
            this.callLetterNumberTextBox1.Size = new System.Drawing.Size(100, 18);
            this.callLetterNumberTextBox1.TabIndex = 0;
            // 
            // callLetterDateDateTimePicker1
            // 
            this.callLetterDateDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.callLetterDateDateTimePicker1.Location = new System.Drawing.Point(362, 21);
            this.callLetterDateDateTimePicker1.Name = "callLetterDateDateTimePicker1";
            this.callLetterDateDateTimePicker1.Size = new System.Drawing.Size(200, 18);
            this.callLetterDateDateTimePicker1.TabIndex = 1;
            // 
            // CallLetterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CallLetterView";
            this.ShowTitle = true;
            this.Size = new System.Drawing.Size(607, 339);
            this.TaskBarPanel.ResumeLayout(false);
            this.TaskBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            this.ToolBarPanel.ResumeLayout(false);
            this.closePanel.ResumeLayout(false);
            this.closePanel.PerformLayout();
            this.BasePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CallLetterDateDateTimePicker callLetterDateDateTimePicker1;
        private CallLetterNumberTextBox callLetterNumberTextBox1;
    }
}
