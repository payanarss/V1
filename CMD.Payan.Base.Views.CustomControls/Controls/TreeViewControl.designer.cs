namespace CMD.Payan.Base.Views.CustomControls
{
    partial class TreeViewControl
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
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.treeView.Size = new System.Drawing.Size(323, 424);
            // 
            // TaskBarPanel
            // 
            this.TaskBarPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TaskBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaskBarPanel.Size = new System.Drawing.Size(327, 25);
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BodyPanel.Location = new System.Drawing.Point(0, 49);
            this.BodyPanel.Size = new System.Drawing.Size(327, 428);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ToolBarPanel.Size = new System.Drawing.Size(327, 24);
            // 
            // AdditionalMenuButtonsPanel
            // 
            this.AdditionalMenuButtonsPanel.Size = new System.Drawing.Size(148, 20);
            // 
            // closePanel
            // 
            this.closePanel.Location = new System.Drawing.Point(301, 2);
            this.closePanel.Size = new System.Drawing.Size(22, 19);
            // 
            // BasePanel
            // 
            this.BasePanel.Size = new System.Drawing.Size(327, 477);
            // 
            // TreeViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "TreeViewControl";
            this.ShowTitle = true;
            this.Size = new System.Drawing.Size(329, 479);
            this.Controls.SetChildIndex(this.BasePanel, 0);
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