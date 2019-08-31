
namespace CMD.Payan.Hrms.Views
{
    public partial class CallLetterCollectionView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.callLetterDataGridView = new CMD.Payan.Base.Views.Controls.DataGridView();
            this.callNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callLetterPresentationEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaskBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.BodyPanel.SuspendLayout();
            this.ToolBarPanel.SuspendLayout();
            this.closePanel.SuspendLayout();
            this.BasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.callLetterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callLetterPresentationEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Size = new System.Drawing.Size(526, 16);
            // 
            // TaskBarPanel
            // 
            this.TaskBarPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TaskBarPanel.Size = new System.Drawing.Size(608, 22);
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.callLetterDataGridView);
            this.BodyPanel.Location = new System.Drawing.Point(0, 44);
            this.BodyPanel.Padding = new System.Windows.Forms.Padding(2);
            this.BodyPanel.Size = new System.Drawing.Size(608, 253);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.Size = new System.Drawing.Size(608, 22);
            // 
            // CommonGridMenuButonsPanel
            // 
            this.CommonGridMenuButonsPanel.Location = new System.Drawing.Point(46, 2);
            // 
            // AdditionalMenuButtonsPanel
            // 
            this.AdditionalMenuButtonsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.AdditionalMenuButtonsPanel.Location = new System.Drawing.Point(46, 2);
            this.AdditionalMenuButtonsPanel.Size = new System.Drawing.Size(560, 18);
            // 
            // closePanel
            // 
            this.closePanel.Location = new System.Drawing.Point(584, 2);
            // 
            // titleLabel
            // 
            this.titleLabel.Size = new System.Drawing.Size(63, 12);
            this.titleLabel.Text = "Call Letters";
            // 
            // BasePanel
            // 
            this.BasePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BasePanel.Location = new System.Drawing.Point(2, 2);
            this.BasePanel.Size = new System.Drawing.Size(610, 321);
            // 
            // callLetterDataGridView
            // 
            this.callLetterDataGridView.AllowUserToAddRows = false;
            this.callLetterDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.callLetterDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.callLetterDataGridView.AutoGenerateColumns = false;
            this.callLetterDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.callLetterDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.callLetterDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.callLetterDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.callLetterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.callLetterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.callNoDataGridViewTextBoxColumn,
            this.callDateDataGridViewTextBoxColumn,
            this.candToDataGridViewTextBoxColumn,
            this.candAddDataGridViewTextBoxColumn,
            this.posDataGridViewTextBoxColumn,
            this.intDateDataGridViewTextBoxColumn,
            this.intTimeDataGridViewTextBoxColumn,
            this.compCodeDataGridViewTextBoxColumn,
            this.contNoDataGridViewTextBoxColumn,
            this.regardsDataGridViewTextBoxColumn});
            this.callLetterDataGridView.DataSource = this.callLetterPresentationEntityBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.callLetterDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.callLetterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.callLetterDataGridView.EnableHeadersVisualStyles = false;
            this.callLetterDataGridView.Font = new System.Drawing.Font("Verdana", 6.75F);
            this.callLetterDataGridView.GridColor = System.Drawing.Color.White;
            this.callLetterDataGridView.Location = new System.Drawing.Point(2, 2);
            this.callLetterDataGridView.MultiSelect = false;
            this.callLetterDataGridView.Name = "callLetterDataGridView";
            this.callLetterDataGridView.RowHeadersVisible = false;
            this.callLetterDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.callLetterDataGridView.Size = new System.Drawing.Size(604, 249);
            this.callLetterDataGridView.TabIndex = 0;
            // 
            // callNoDataGridViewTextBoxColumn
            // 
            this.callNoDataGridViewTextBoxColumn.DataPropertyName = "CallNo";
            this.callNoDataGridViewTextBoxColumn.HeaderText = "CallNo";
            this.callNoDataGridViewTextBoxColumn.Name = "callNoDataGridViewTextBoxColumn";
            // 
            // callDateDataGridViewTextBoxColumn
            // 
            this.callDateDataGridViewTextBoxColumn.DataPropertyName = "CallDate";
            this.callDateDataGridViewTextBoxColumn.HeaderText = "CallDate";
            this.callDateDataGridViewTextBoxColumn.Name = "callDateDataGridViewTextBoxColumn";
            // 
            // candToDataGridViewTextBoxColumn
            // 
            this.candToDataGridViewTextBoxColumn.DataPropertyName = "CandTo";
            this.candToDataGridViewTextBoxColumn.HeaderText = "CandTo";
            this.candToDataGridViewTextBoxColumn.Name = "candToDataGridViewTextBoxColumn";
            // 
            // candAddDataGridViewTextBoxColumn
            // 
            this.candAddDataGridViewTextBoxColumn.DataPropertyName = "CandAdd";
            this.candAddDataGridViewTextBoxColumn.HeaderText = "CandAdd";
            this.candAddDataGridViewTextBoxColumn.Name = "candAddDataGridViewTextBoxColumn";
            // 
            // posDataGridViewTextBoxColumn
            // 
            this.posDataGridViewTextBoxColumn.DataPropertyName = "Pos";
            this.posDataGridViewTextBoxColumn.HeaderText = "Pos";
            this.posDataGridViewTextBoxColumn.Name = "posDataGridViewTextBoxColumn";
            // 
            // intDateDataGridViewTextBoxColumn
            // 
            this.intDateDataGridViewTextBoxColumn.DataPropertyName = "IntDate";
            this.intDateDataGridViewTextBoxColumn.HeaderText = "IntDate";
            this.intDateDataGridViewTextBoxColumn.Name = "intDateDataGridViewTextBoxColumn";
            // 
            // intTimeDataGridViewTextBoxColumn
            // 
            this.intTimeDataGridViewTextBoxColumn.DataPropertyName = "IntTime";
            this.intTimeDataGridViewTextBoxColumn.HeaderText = "IntTime";
            this.intTimeDataGridViewTextBoxColumn.Name = "intTimeDataGridViewTextBoxColumn";
            // 
            // compCodeDataGridViewTextBoxColumn
            // 
            this.compCodeDataGridViewTextBoxColumn.DataPropertyName = "CompCode";
            this.compCodeDataGridViewTextBoxColumn.HeaderText = "CompCode";
            this.compCodeDataGridViewTextBoxColumn.Name = "compCodeDataGridViewTextBoxColumn";
            // 
            // contNoDataGridViewTextBoxColumn
            // 
            this.contNoDataGridViewTextBoxColumn.DataPropertyName = "ContNo";
            this.contNoDataGridViewTextBoxColumn.HeaderText = "ContNo";
            this.contNoDataGridViewTextBoxColumn.Name = "contNoDataGridViewTextBoxColumn";
            // 
            // regardsDataGridViewTextBoxColumn
            // 
            this.regardsDataGridViewTextBoxColumn.DataPropertyName = "Regards";
            this.regardsDataGridViewTextBoxColumn.HeaderText = "Regards";
            this.regardsDataGridViewTextBoxColumn.Name = "regardsDataGridViewTextBoxColumn";
            // 
            // callLetterPresentationEntityBindingSource
            // 
            this.callLetterPresentationEntityBindingSource.DataSource = typeof(CMD.Payan.Hrms.Presenters.CallLetterPresentationEntity);
            // 
            // CallLetterCollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name = "CallLetterCollectionView";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowAdditionalMenuButtonsPanel = true;
            this.ShowCommonToolBarMenus = true;
            this.ShowGridMenus = true;
            this.ShowSearchPanel = true;
            this.ShowTaskBar = true;
            this.ShowTitle = true;
            this.ShowToolBar = true;
            this.Size = new System.Drawing.Size(614, 325);
            this.TaskBarPanel.ResumeLayout(false);
            this.TaskBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.BodyPanel.ResumeLayout(false);
            this.ToolBarPanel.ResumeLayout(false);
            this.closePanel.ResumeLayout(false);
            this.closePanel.PerformLayout();
            this.BasePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.callLetterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callLetterPresentationEntityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private Base.Views.Controls.DataGridView callLetterDataGridView;

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn callNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regardsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource callLetterPresentationEntityBindingSource;
    }
}
