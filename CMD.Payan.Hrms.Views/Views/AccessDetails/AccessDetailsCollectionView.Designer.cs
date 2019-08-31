
namespace CMD.Payan.Hrms.Views
{
    public partial class AccessDetailsCollectionView
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
            this.dataGridView1 = new CMD.Payan.Base.Views.Controls.DataGridView();
            this.accessDetailsPresentationEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessDetailsDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDirtyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presenterDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessObjectDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPresentationEntitySelectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uniqueIdentifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewContextDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.BodyPanel.SuspendLayout();
            this.ToolBarPanel.SuspendLayout();
            this.closePanel.SuspendLayout();
            this.BasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessDetailsPresentationEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Size = new System.Drawing.Size(532, 16);
            // 
            // TaskBarPanel
            // 
            this.TaskBarPanel.Size = new System.Drawing.Size(614, 22);
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.dataGridView1);
            this.BodyPanel.Location = new System.Drawing.Point(0, 44);
            this.BodyPanel.Size = new System.Drawing.Size(614, 259);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.Size = new System.Drawing.Size(614, 22);
            // 
            // CommonGridMenuButonsPanel
            // 
            this.CommonGridMenuButonsPanel.Location = new System.Drawing.Point(46, 2);
            // 
            // AdditionalMenuButtonsPanel
            // 
            this.AdditionalMenuButtonsPanel.Location = new System.Drawing.Point(46, 2);
            this.AdditionalMenuButtonsPanel.Size = new System.Drawing.Size(566, 18);
            // 
            // closePanel
            // 
            this.closePanel.Location = new System.Drawing.Point(590, 2);
            // 
            // BasePanel
            // 
            this.BasePanel.Size = new System.Drawing.Size(614, 325);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accDateDataGridViewTextBoxColumn,
            this.accTimeDataGridViewTextBoxColumn,
            this.doorNoDataGridViewTextBoxColumn,
            this.empCodeDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.empnoDataGridViewTextBoxColumn,
            this.flgDataGridViewTextBoxColumn,
            this.rNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.accessDetailsDetailDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn,
            this.recordNumberDataGridViewTextBoxColumn,
            this.serialNoDataGridViewTextBoxColumn,
            this.parentIDDataGridViewTextBoxColumn,
            this.isDirtyDataGridViewCheckBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn,
            this.parentDetailDataGridViewTextBoxColumn,
            this.presenterDetailDataGridViewTextBoxColumn,
            this.businessObjectDetailDataGridViewTextBoxColumn,
            this.isPresentationEntitySelectedDataGridViewCheckBoxColumn,
            this.uniqueIdentifierDataGridViewTextBoxColumn,
            this.viewDetailDataGridViewTextBoxColumn,
            this.viewContextDetailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accessDetailsPresentationEntityBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Verdana", 6.75F);
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(614, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // accessDetailsPresentationEntityBindingSource
            // 
            this.accessDetailsPresentationEntityBindingSource.DataSource = typeof(CMD.Payan.Hrms.Presenters.AccessDetailsPresentationEntity);
            // 
            // accDateDataGridViewTextBoxColumn
            // 
            this.accDateDataGridViewTextBoxColumn.DataPropertyName = "AccDate";
            this.accDateDataGridViewTextBoxColumn.HeaderText = "AccDate";
            this.accDateDataGridViewTextBoxColumn.Name = "accDateDataGridViewTextBoxColumn";
            // 
            // accTimeDataGridViewTextBoxColumn
            // 
            this.accTimeDataGridViewTextBoxColumn.DataPropertyName = "AccTime";
            this.accTimeDataGridViewTextBoxColumn.HeaderText = "AccTime";
            this.accTimeDataGridViewTextBoxColumn.Name = "accTimeDataGridViewTextBoxColumn";
            // 
            // doorNoDataGridViewTextBoxColumn
            // 
            this.doorNoDataGridViewTextBoxColumn.DataPropertyName = "DoorNo";
            this.doorNoDataGridViewTextBoxColumn.HeaderText = "DoorNo";
            this.doorNoDataGridViewTextBoxColumn.Name = "doorNoDataGridViewTextBoxColumn";
            // 
            // empCodeDataGridViewTextBoxColumn
            // 
            this.empCodeDataGridViewTextBoxColumn.DataPropertyName = "EmpCode";
            this.empCodeDataGridViewTextBoxColumn.HeaderText = "EmpCode";
            this.empCodeDataGridViewTextBoxColumn.Name = "empCodeDataGridViewTextBoxColumn";
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "EmpName";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "EmpName";
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            // 
            // empnoDataGridViewTextBoxColumn
            // 
            this.empnoDataGridViewTextBoxColumn.DataPropertyName = "Empno";
            this.empnoDataGridViewTextBoxColumn.HeaderText = "Empno";
            this.empnoDataGridViewTextBoxColumn.Name = "empnoDataGridViewTextBoxColumn";
            // 
            // flgDataGridViewTextBoxColumn
            // 
            this.flgDataGridViewTextBoxColumn.DataPropertyName = "Flg";
            this.flgDataGridViewTextBoxColumn.HeaderText = "Flg";
            this.flgDataGridViewTextBoxColumn.Name = "flgDataGridViewTextBoxColumn";
            // 
            // rNoDataGridViewTextBoxColumn
            // 
            this.rNoDataGridViewTextBoxColumn.DataPropertyName = "RNo";
            this.rNoDataGridViewTextBoxColumn.HeaderText = "RNo";
            this.rNoDataGridViewTextBoxColumn.Name = "rNoDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // accessDetailsDetailDataGridViewTextBoxColumn
            // 
            this.accessDetailsDetailDataGridViewTextBoxColumn.DataPropertyName = "AccessDetailsDetail";
            this.accessDetailsDetailDataGridViewTextBoxColumn.HeaderText = "AccessDetailsDetail";
            this.accessDetailsDetailDataGridViewTextBoxColumn.Name = "accessDetailsDetailDataGridViewTextBoxColumn";
            this.accessDetailsDetailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeStampDataGridViewTextBoxColumn
            // 
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recordNumberDataGridViewTextBoxColumn
            // 
            this.recordNumberDataGridViewTextBoxColumn.DataPropertyName = "RecordNumber";
            this.recordNumberDataGridViewTextBoxColumn.HeaderText = "RecordNumber";
            this.recordNumberDataGridViewTextBoxColumn.Name = "recordNumberDataGridViewTextBoxColumn";
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            // 
            // parentIDDataGridViewTextBoxColumn
            // 
            this.parentIDDataGridViewTextBoxColumn.DataPropertyName = "ParentID";
            this.parentIDDataGridViewTextBoxColumn.HeaderText = "ParentID";
            this.parentIDDataGridViewTextBoxColumn.Name = "parentIDDataGridViewTextBoxColumn";
            this.parentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDirtyDataGridViewCheckBoxColumn
            // 
            this.isDirtyDataGridViewCheckBoxColumn.DataPropertyName = "IsDirty";
            this.isDirtyDataGridViewCheckBoxColumn.HeaderText = "IsDirty";
            this.isDirtyDataGridViewCheckBoxColumn.Name = "isDirtyDataGridViewCheckBoxColumn";
            this.isDirtyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            // 
            // parentDetailDataGridViewTextBoxColumn
            // 
            this.parentDetailDataGridViewTextBoxColumn.DataPropertyName = "ParentDetail";
            this.parentDetailDataGridViewTextBoxColumn.HeaderText = "ParentDetail";
            this.parentDetailDataGridViewTextBoxColumn.Name = "parentDetailDataGridViewTextBoxColumn";
            // 
            // presenterDetailDataGridViewTextBoxColumn
            // 
            this.presenterDetailDataGridViewTextBoxColumn.DataPropertyName = "PresenterDetail";
            this.presenterDetailDataGridViewTextBoxColumn.HeaderText = "PresenterDetail";
            this.presenterDetailDataGridViewTextBoxColumn.Name = "presenterDetailDataGridViewTextBoxColumn";
            // 
            // businessObjectDetailDataGridViewTextBoxColumn
            // 
            this.businessObjectDetailDataGridViewTextBoxColumn.DataPropertyName = "BusinessObjectDetail";
            this.businessObjectDetailDataGridViewTextBoxColumn.HeaderText = "BusinessObjectDetail";
            this.businessObjectDetailDataGridViewTextBoxColumn.Name = "businessObjectDetailDataGridViewTextBoxColumn";
            // 
            // isPresentationEntitySelectedDataGridViewCheckBoxColumn
            // 
            this.isPresentationEntitySelectedDataGridViewCheckBoxColumn.DataPropertyName = "IsPresentationEntitySelected";
            this.isPresentationEntitySelectedDataGridViewCheckBoxColumn.HeaderText = "IsPresentationEntitySelected";
            this.isPresentationEntitySelectedDataGridViewCheckBoxColumn.Name = "isPresentationEntitySelectedDataGridViewCheckBoxColumn";
            this.isPresentationEntitySelectedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // uniqueIdentifierDataGridViewTextBoxColumn
            // 
            this.uniqueIdentifierDataGridViewTextBoxColumn.DataPropertyName = "UniqueIdentifier";
            this.uniqueIdentifierDataGridViewTextBoxColumn.HeaderText = "UniqueIdentifier";
            this.uniqueIdentifierDataGridViewTextBoxColumn.Name = "uniqueIdentifierDataGridViewTextBoxColumn";
            // 
            // viewDetailDataGridViewTextBoxColumn
            // 
            this.viewDetailDataGridViewTextBoxColumn.DataPropertyName = "ViewDetail";
            this.viewDetailDataGridViewTextBoxColumn.HeaderText = "ViewDetail";
            this.viewDetailDataGridViewTextBoxColumn.Name = "viewDetailDataGridViewTextBoxColumn";
            this.viewDetailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewContextDetailDataGridViewTextBoxColumn
            // 
            this.viewContextDetailDataGridViewTextBoxColumn.DataPropertyName = "ViewContextDetail";
            this.viewContextDetailDataGridViewTextBoxColumn.HeaderText = "ViewContextDetail";
            this.viewContextDetailDataGridViewTextBoxColumn.Name = "viewContextDetailDataGridViewTextBoxColumn";
            this.viewContextDetailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AccessDetailsCollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AccessDetailsCollectionView";
            this.ShowTitle = true;
            this.Size = new System.Drawing.Size(616, 327);
            this.TaskBarPanel.ResumeLayout(false);
            this.TaskBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.BodyPanel.ResumeLayout(false);
            this.ToolBarPanel.ResumeLayout(false);
            this.closePanel.ResumeLayout(false);
            this.closePanel.PerformLayout();
            this.BasePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessDetailsPresentationEntityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private Base.Views.Controls.DataGridView dataGridView1;

        #endregion
        private System.Windows.Forms.BindingSource accessDetailsPresentationEntityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn accDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessDetailsDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDirtyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presenterDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessObjectDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPresentationEntitySelectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueIdentifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewContextDetailDataGridViewTextBoxColumn;
    }
}
