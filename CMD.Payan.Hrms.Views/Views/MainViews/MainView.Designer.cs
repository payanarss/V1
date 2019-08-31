namespace CMD.Payan.Hrms.Views
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.mainSplitContainer = new CMD.Payan.Base.Views.Controls.SplitContainer(this.components);
            this.menuExplorerView = new CMD.Payan.Hrms.Views.MenuExplorerView();
            this.mainDataViews = new CMD.Payan.Hrms.Views.MainDataViews();
            this.TaskBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.BodyPanel.SuspendLayout();
            this.ToolBarPanel.SuspendLayout();
            this.closePanel.SuspendLayout();
            this.BasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskBarPanel
            // 
            this.TaskBarPanel.Size = new System.Drawing.Size(954, 22);
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.mainSplitContainer);
            this.BodyPanel.Location = new System.Drawing.Point(0, 44);
            this.BodyPanel.Size = new System.Drawing.Size(954, 318);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.Size = new System.Drawing.Size(954, 22);
            // 
            // AdditionalMenuButtonsPanel
            // 
            this.AdditionalMenuButtonsPanel.Size = new System.Drawing.Size(778, 18);
            // 
            // closePanel
            // 
            this.closePanel.Location = new System.Drawing.Point(929, 2);
            // 
            // BasePanel
            // 
            this.BasePanel.Size = new System.Drawing.Size(954, 362);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.menuExplorerView);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.mainDataViews);
            this.mainSplitContainer.Size = new System.Drawing.Size(954, 318);
            this.mainSplitContainer.SplitterDistance = 165;
            this.mainSplitContainer.SplitterWidth = 2;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // menuExplorerView
            // 
            this.menuExplorerView.BackColor = System.Drawing.Color.White;
            this.menuExplorerView.BottomExplorerViewFactory = null;
            this.menuExplorerView.CustomTabPageDetail = null;
            this.menuExplorerView.DataLoadedWeightage = 0;
            this.menuExplorerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuExplorerView.DrawBodyPanelBorder = true;
            this.menuExplorerView.DrawBorder = false;
            this.menuExplorerView.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuExplorerView.IsMovableControl = false;
            this.menuExplorerView.Location = new System.Drawing.Point(0, 0);
            this.menuExplorerView.Margin = new System.Windows.Forms.Padding(2);
            this.menuExplorerView.Name = "menuExplorerView";
            this.menuExplorerView.Padding = new System.Windows.Forms.Padding(1);
            this.menuExplorerView.PageName = null;
            this.menuExplorerView.ParentDetail = null;
            this.menuExplorerView.RightExplorerViewFactory = null;
            this.menuExplorerView.ShowAdditionalMenuButtonsPanel = false;
            this.menuExplorerView.ShowCommonToolBarMenus = false;
            this.menuExplorerView.ShowTaskBar = true;
            this.menuExplorerView.ShowTitle = true;
            this.menuExplorerView.ShowToolBar = false;
            this.menuExplorerView.Size = new System.Drawing.Size(165, 318);
            this.menuExplorerView.TabIndex = 0;
            this.menuExplorerView.Title = "";
            this.menuExplorerView.ViewContextDetail = null;
            // 
            // mainDataViews
            // 
            this.mainDataViews.BackColor = System.Drawing.Color.White;
            this.mainDataViews.BottomExplorerViewFactory = null;
            this.mainDataViews.CustomTabPageDetail = null;
            this.mainDataViews.DataLoadedWeightage = 0;
            this.mainDataViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDataViews.DrawBodyPanelBorder = true;
            this.mainDataViews.DrawBorder = false;
            this.mainDataViews.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDataViews.IsMovableControl = false;
            this.mainDataViews.Location = new System.Drawing.Point(0, 0);
            this.mainDataViews.Margin = new System.Windows.Forms.Padding(2);
            this.mainDataViews.Name = "mainDataViews";
            this.mainDataViews.Padding = new System.Windows.Forms.Padding(1);
            this.mainDataViews.PageName = null;
            this.mainDataViews.ParentDetail = null;
            this.mainDataViews.RightExplorerViewFactory = null;
            this.mainDataViews.ShowAdditionalMenuButtonsPanel = false;
            this.mainDataViews.ShowCommonToolBarMenus = false;
            this.mainDataViews.ShowTaskBar = true;
            this.mainDataViews.ShowTitle = true;
            this.mainDataViews.ShowToolBar = false;
            this.mainDataViews.Size = new System.Drawing.Size(787, 318);
            this.mainDataViews.TabIndex = 0;
            this.mainDataViews.Title = "";
            this.mainDataViews.ViewContextDetail = null;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MainView";
            this.ShowTitle = true;
            this.Size = new System.Drawing.Size(956, 364);
            this.TaskBarPanel.ResumeLayout(false);
            this.TaskBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.BodyPanel.ResumeLayout(false);
            this.ToolBarPanel.ResumeLayout(false);
            this.closePanel.ResumeLayout(false);
            this.closePanel.PerformLayout();
            this.BasePanel.ResumeLayout(false);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CMD.Payan.Base.Views.Controls.SplitContainer mainSplitContainer;
        private MenuExplorerView menuExplorerView;
        private MainDataViews mainDataViews;
    }
}