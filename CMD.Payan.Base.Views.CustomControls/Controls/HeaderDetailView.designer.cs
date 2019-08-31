using CMD.Payan.Base.Views.Controls;
namespace CMD.Payan.Base.Views.CustomControls
{
    partial class HeaderDetailView
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
            this.BodyPanel.SuspendLayout();
            this.ToolBarPanel.SuspendLayout();
            this.closePanel.SuspendLayout();
            this.BasePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Size = new System.Drawing.Size(318, 59);
            // 
            // DetailPanel
            // 
            this.DetailPanel.Size = new System.Drawing.Size(318, 122);
            // 
            // TaskBarPanel
            // 
            this.TaskBarPanel.Size = new System.Drawing.Size(318, 25);
            // 
            // BodyPanel
            // 
            this.BodyPanel.Location = new System.Drawing.Point(0, 49);
            this.BodyPanel.Size = new System.Drawing.Size(318, 181);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 25);
            this.ToolBarPanel.Size = new System.Drawing.Size(318, 24);
            // 
            // AdditionalMenuButtonsPanel
            // 
            this.AdditionalMenuButtonsPanel.Size = new System.Drawing.Size(139, 20);
            // 
            // closePanel
            // 
            this.closePanel.Location = new System.Drawing.Point(136, 2);
            // 
            // BasePanel
            // 
            this.BasePanel.Size = new System.Drawing.Size(318, 230);
            // 
            // HeaderDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "HeaderDetailView";
            this.ShowTitle = true;
            this.Size = new System.Drawing.Size(320, 232);
            this.TaskBarPanel.ResumeLayout(false);
            this.TaskBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.BodyPanel.ResumeLayout(false);
            this.ToolBarPanel.ResumeLayout(false);
            this.closePanel.ResumeLayout(false);
            this.closePanel.PerformLayout();
            this.BasePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}