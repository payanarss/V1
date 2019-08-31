namespace CMD.Payan.Hrms.Views
{
    partial class MenuExplorerView
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
            this.treeView.BackColor = System.Drawing.Color.White;
            // 
            // TaskBarPanel
            // 
            this.TaskBarPanel.BackColor = System.Drawing.Color.White;
            this.TaskBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.White;
            this.BodyPanel.Location = new System.Drawing.Point(0, 45);
            this.BodyPanel.Size = new System.Drawing.Size(327, 395);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.White;
            // 
            // AdditionalMenuButtonsPanel
            // 
            this.AdditionalMenuButtonsPanel.BackColor = System.Drawing.Color.White;
            this.AdditionalMenuButtonsPanel.Location = new System.Drawing.Point(176, 2);
            this.AdditionalMenuButtonsPanel.Size = new System.Drawing.Size(150, 18);
            // 
            // closePanel
            // 
            this.closePanel.Location = new System.Drawing.Point(303, 2);
            this.closePanel.Size = new System.Drawing.Size(22, 19);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Size = new System.Drawing.Size(43, 13);
            this.titleLabel.Text = "MENU";
            // 
            // MenuExplorerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MenuExplorerView";
            this.ShowTaskBar = true;
            this.ShowTitle = true;
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