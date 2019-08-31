using CMD.Payan.Base.Views.Controls;
namespace CMD.Payan.Base.Views.CustomControls
{
    partial class BaseView
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
            this.TaskBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.ToolBarPanel.SuspendLayout();
            this.closePanel.SuspendLayout();
            this.BasePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskBarPanel
            // 
            this.TaskBarPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TaskBarPanel.Size = new System.Drawing.Size(650, 22);
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.White;
            this.BodyPanel.Location = new System.Drawing.Point(0, 44);
            this.BodyPanel.Padding = new System.Windows.Forms.Padding(2);
            this.BodyPanel.Size = new System.Drawing.Size(650, 337);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.Size = new System.Drawing.Size(650, 22);
            // 
            // AdditionalMenuButtonsPanel
            // 
            this.AdditionalMenuButtonsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.AdditionalMenuButtonsPanel.Size = new System.Drawing.Size(472, 18);
            // 
            // closePanel
            // 
            this.closePanel.Location = new System.Drawing.Point(625, 2);
            // 
            // BasePanel
            // 
            this.BasePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BasePanel.Location = new System.Drawing.Point(2, 2);
            this.BasePanel.Size = new System.Drawing.Size(652, 383);
            // 
            // BaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name = "BaseView";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowTitle = true;
            this.Size = new System.Drawing.Size(656, 387);
            this.TaskBarPanel.ResumeLayout(false);
            this.TaskBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ToolBarPanel.ResumeLayout(false);
            this.closePanel.ResumeLayout(false);
            this.closePanel.PerformLayout();
            this.BasePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}