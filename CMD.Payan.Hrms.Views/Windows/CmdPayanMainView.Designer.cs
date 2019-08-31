using CMD.Payan.Base.Common;
namespace CMD.Payan.Hrms.Views
{
    partial class CmdPayanMainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CmdPayanMainView));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainPanel = new CMD.Payan.Base.Views.Controls.Panel();
            this.bodyPanel = new CMD.Payan.Base.Views.Controls.Panel();
            this.clientAreaPanel = new CMD.Payan.Base.Views.Controls.Panel();
            this.mainViewTabed = new CMD.Payan.Hrms.Views.MainViews.MainViewTabed();
            this.toolBarPanel = new CMD.Payan.Base.Views.Controls.Panel();
            this.titleBarPanel = new CMD.Payan.Base.Views.Controls.Panel();
            this.titlePanel = new CMD.Payan.Base.Views.Controls.Panel();
            this.applicationTitleLabel = new CMD.Payan.Base.Views.Controls.Label();
            this.settingsPanel = new CMD.Payan.Base.Views.Controls.Panel();
            this.logedinUserNameLabel = new CMD.Payan.Base.Views.Controls.Label();
            this.minimizeClosePanel = new CMD.Payan.Base.Views.Controls.Panel();
            this.minimizeLinkLabel = new CMD.Payan.Base.Views.Controls.LinkLabel();
            this.closeLinkLabel = new CMD.Payan.Base.Views.Controls.LinkLabel();
            this.iconPanel = new CMD.Payan.Base.Views.Controls.Panel();
            this.applicationPictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.clientAreaPanel.SuspendLayout();
            this.titleBarPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.minimizeClosePanel.SuspendLayout();
            this.iconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(2, 394);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(628, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.bodyPanel);
            this.mainPanel.Controls.Add(this.titleBarPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.DrawBorder = false;
            this.mainPanel.DrawBottomLine = false;
            this.mainPanel.IsMovableControl = false;
            this.mainPanel.Location = new System.Drawing.Point(2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(628, 392);
            this.mainPanel.TabIndex = 8;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.clientAreaPanel);
            this.bodyPanel.Controls.Add(this.toolBarPanel);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.DrawBorder = false;
            this.bodyPanel.DrawBottomLine = false;
            this.bodyPanel.IsMovableControl = false;
            this.bodyPanel.Location = new System.Drawing.Point(0, 28);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(628, 364);
            this.bodyPanel.TabIndex = 2;
            // 
            // clientAreaPanel
            // 
            this.clientAreaPanel.Controls.Add(this.mainViewTabed);
            this.clientAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientAreaPanel.DrawBorder = false;
            this.clientAreaPanel.DrawBottomLine = false;
            this.clientAreaPanel.IsMovableControl = false;
            this.clientAreaPanel.Location = new System.Drawing.Point(0, 55);
            this.clientAreaPanel.Name = "clientAreaPanel";
            this.clientAreaPanel.Size = new System.Drawing.Size(628, 309);
            this.clientAreaPanel.TabIndex = 1;
            // 
            // mainViewTabed
            // 
            this.mainViewTabed.BackColor = System.Drawing.Color.White;
            this.mainViewTabed.BottomExplorerViewFactory = null;
            this.mainViewTabed.CustomTabPageDetail = null;
            this.mainViewTabed.DataLoadedWeightage = 0;
            this.mainViewTabed.DefaultPageTypeDetail = Payanar.SS.Net.Libraries.Views.CustomControls.DefaultPageType.LastPage;
            this.mainViewTabed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainViewTabed.DrawBodyPanelBorder = false;
            this.mainViewTabed.DrawBorder = false;
            this.mainViewTabed.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainViewTabed.IsMovableControl = false;
            this.mainViewTabed.Location = new System.Drawing.Point(0, 0);
            this.mainViewTabed.Margin = new System.Windows.Forms.Padding(2);
            this.mainViewTabed.Name = "mainViewTabed";
            this.mainViewTabed.Padding = new System.Windows.Forms.Padding(1);
            this.mainViewTabed.PageName = null;
            this.mainViewTabed.ParentDetail = null;
            this.mainViewTabed.RightExplorerViewFactory = null;
            this.mainViewTabed.ShowAdditionalMenuButtonsPanel = false;
            this.mainViewTabed.ShowCommonToolBarMenus = false;
            this.mainViewTabed.ShowTaskBar = false;
            this.mainViewTabed.ShowTitle = false;
            this.mainViewTabed.ShowToolBar = false;
            this.mainViewTabed.Size = new System.Drawing.Size(628, 309);
            this.mainViewTabed.TabIndex = 7;
            this.mainViewTabed.Title = "";
            this.mainViewTabed.ViewContextDetail = null;
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarPanel.DrawBorder = false;
            this.toolBarPanel.DrawBottomLine = false;
            this.toolBarPanel.IsMovableControl = false;
            this.toolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolBarPanel.Name = "toolBarPanel";
            this.toolBarPanel.Size = new System.Drawing.Size(628, 55);
            this.toolBarPanel.TabIndex = 0;
            this.toolBarPanel.Visible = false;
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.titleBarPanel.Controls.Add(this.titlePanel);
            this.titleBarPanel.Controls.Add(this.settingsPanel);
            this.titleBarPanel.Controls.Add(this.minimizeClosePanel);
            this.titleBarPanel.Controls.Add(this.iconPanel);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.DrawBorder = false;
            this.titleBarPanel.DrawBottomLine = false;
            this.titleBarPanel.IsMovableControl = false;
            this.titleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(628, 28);
            this.titleBarPanel.TabIndex = 0;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.applicationTitleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePanel.DrawBorder = false;
            this.titlePanel.DrawBottomLine = false;
            this.titlePanel.IsMovableControl = false;
            this.titlePanel.Location = new System.Drawing.Point(23, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(353, 28);
            this.titlePanel.TabIndex = 3;
            // 
            // applicationTitleLabel
            // 
            this.applicationTitleLabel.AutoSize = true;
            this.applicationTitleLabel.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationTitleLabel.ForeColor = System.Drawing.Color.White;
            this.applicationTitleLabel.Location = new System.Drawing.Point(3, 7);
            this.applicationTitleLabel.Name = "applicationTitleLabel";
            this.applicationTitleLabel.Size = new System.Drawing.Size(60, 12);
            this.applicationTitleLabel.TabIndex = 0;
            this.applicationTitleLabel.Text = "CMD Payan";
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.logedinUserNameLabel);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsPanel.DrawBorder = false;
            this.settingsPanel.DrawBottomLine = false;
            this.settingsPanel.IsMovableControl = false;
            this.settingsPanel.Location = new System.Drawing.Point(376, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(219, 28);
            this.settingsPanel.TabIndex = 2;
            // 
            // logedinUserNameLabel
            // 
            this.logedinUserNameLabel.AutoSize = true;
            this.logedinUserNameLabel.ForeColor = System.Drawing.Color.White;
            this.logedinUserNameLabel.Location = new System.Drawing.Point(82, 7);
            this.logedinUserNameLabel.Name = "logedinUserNameLabel";
            this.logedinUserNameLabel.Size = new System.Drawing.Size(129, 12);
            this.logedinUserNameLabel.TabIndex = 0;
            this.logedinUserNameLabel.Text = "Shanmu, Bhuvaneswaran";
            // 
            // minimizeClosePanel
            // 
            this.minimizeClosePanel.Controls.Add(this.minimizeLinkLabel);
            this.minimizeClosePanel.Controls.Add(this.closeLinkLabel);
            this.minimizeClosePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeClosePanel.DrawBorder = false;
            this.minimizeClosePanel.DrawBottomLine = false;
            this.minimizeClosePanel.IsMovableControl = false;
            this.minimizeClosePanel.Location = new System.Drawing.Point(595, 0);
            this.minimizeClosePanel.Name = "minimizeClosePanel";
            this.minimizeClosePanel.Size = new System.Drawing.Size(33, 28);
            this.minimizeClosePanel.TabIndex = 1;
            // 
            // minimizeLinkLabel
            // 
            this.minimizeLinkLabel.AutoSize = true;
            this.minimizeLinkLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeLinkLabel.ForeColor = System.Drawing.Color.White;
            this.minimizeLinkLabel.LinkColor = System.Drawing.Color.White;
            this.minimizeLinkLabel.Location = new System.Drawing.Point(3, 17);
            this.minimizeLinkLabel.Name = "minimizeLinkLabel";
            this.minimizeLinkLabel.Size = new System.Drawing.Size(14, 13);
            this.minimizeLinkLabel.TabIndex = 1;
            this.minimizeLinkLabel.TabStop = true;
            this.minimizeLinkLabel.Text = "_";
            // 
            // closeLinkLabel
            // 
            this.closeLinkLabel.AutoSize = true;
            this.closeLinkLabel.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLinkLabel.ForeColor = System.Drawing.Color.White;
            this.closeLinkLabel.LinkColor = System.Drawing.Color.White;
            this.closeLinkLabel.Location = new System.Drawing.Point(16, 7);
            this.closeLinkLabel.Name = "closeLinkLabel";
            this.closeLinkLabel.Size = new System.Drawing.Size(12, 12);
            this.closeLinkLabel.TabIndex = 0;
            this.closeLinkLabel.TabStop = true;
            this.closeLinkLabel.Text = "X";
            this.closeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.closeLinkLabel_LinkClicked);
            // 
            // iconPanel
            // 
            this.iconPanel.Controls.Add(this.applicationPictureBox);
            this.iconPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPanel.DrawBorder = false;
            this.iconPanel.DrawBottomLine = false;
            this.iconPanel.IsMovableControl = false;
            this.iconPanel.Location = new System.Drawing.Point(0, 0);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(23, 28);
            this.iconPanel.TabIndex = 0;
            // 
            // applicationPictureBox
            // 
            this.applicationPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationPictureBox.Location = new System.Drawing.Point(0, 0);
            this.applicationPictureBox.Name = "applicationPictureBox";
            this.applicationPictureBox.Padding = new System.Windows.Forms.Padding(3);
            this.applicationPictureBox.Size = new System.Drawing.Size(23, 28);
            this.applicationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.applicationPictureBox.TabIndex = 0;
            this.applicationPictureBox.TabStop = false;
            // 
            // AgriBankMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 418);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "AgriBankMainView";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "AgriBank";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.bodyPanel.ResumeLayout(false);
            this.clientAreaPanel.ResumeLayout(false);
            this.titleBarPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.minimizeClosePanel.ResumeLayout(false);
            this.minimizeClosePanel.PerformLayout();
            this.iconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicationPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private CMD.Payan.Base.Views.Controls.Panel mainPanel;
        private CMD.Payan.Base.Views.Controls.Panel titleBarPanel;
        private CMD.Payan.Base.Views.Controls.Panel bodyPanel;
        private CMD.Payan.Base.Views.Controls.Panel toolBarPanel;
        private CMD.Payan.Base.Views.Controls.Panel clientAreaPanel;
        private Views.MainViews.MainViewTabed mainViewTabed;
        private CMD.Payan.Base.Views.Controls.Panel iconPanel;
        private CMD.Payan.Base.Views.Controls.Panel minimizeClosePanel;
        private CMD.Payan.Base.Views.Controls.Panel settingsPanel;
        private CMD.Payan.Base.Views.Controls.Panel titlePanel;
        private CMD.Payan.Base.Views.Controls.LinkLabel closeLinkLabel;
        private CMD.Payan.Base.Views.Controls.LinkLabel minimizeLinkLabel;
        private CMD.Payan.Base.Views.Controls.Label applicationTitleLabel;
        private CMD.Payan.Base.Views.Controls.Label logedinUserNameLabel;
        private System.Windows.Forms.PictureBox applicationPictureBox;
    }
}