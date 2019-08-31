using CMD.Payan.Base.Views.Controls;
namespace CMD.Payan.Base.Views.CustomControls
{
    partial class HeaderDetailWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BasePanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.ToolBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetailPanel
            // 
            this.DetailPanel.Size = new System.Drawing.Size(526, 235);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Size = new System.Drawing.Size(526, 63);
            // 
            // BasePanel
            // 
            this.BasePanel.Size = new System.Drawing.Size(526, 321);
            // 
            // BodyPanel
            // 
            this.BodyPanel.Size = new System.Drawing.Size(526, 298);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.Size = new System.Drawing.Size(526, 23);
            // 
            // HeaderDetailWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(526, 321);
            this.Name = "HeaderDetailWindow";
            this.BasePanel.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.ToolBarPanel.ResumeLayout(false);
            this.ToolBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}