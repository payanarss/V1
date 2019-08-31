using CMD.Payan.Base.Views.Controls;
namespace CMD.Payan.Base.Views.CustomControls
{
    partial class HeaderView
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
            this.TaskBarPanel.Size = new System.Drawing.Size(301, 25);
            // 
            // BodyPanel
            // 
            this.BodyPanel.Location = new System.Drawing.Point(0, 49);
            this.BodyPanel.Size = new System.Drawing.Size(301, 179);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 25);
            this.ToolBarPanel.Size = new System.Drawing.Size(301, 24);
            // 
            // AdditionalMenuButtonsPanel
            // 
            this.AdditionalMenuButtonsPanel.Size = new System.Drawing.Size(122, 20);
            // 
            // closePanel
            // 
            this.closePanel.Location = new System.Drawing.Point(119, 2);
            // 
            // BasePanel
            // 
            this.BasePanel.Size = new System.Drawing.Size(301, 228);
            // 
            // HeaderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "HeaderView";
            this.ShowTitle = true;
            this.Size = new System.Drawing.Size(303, 230);
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