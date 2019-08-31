using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMD.Payan.Base.Views.CustomControls;

namespace CMD.Payan.Hrms.Views
{
    public partial class MainDataViews : BaseView
    {
        public MainDataViews()
        {
            InitializeComponent();
        }

        public void AddTableDesignView(Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView dataGridView)
        {
            dataGridView.GetObservable().AddObserver(this);
            this.BodyPanel.Controls.Add(dataGridView);
            this.BodyPanel.Invalidate();
            dataGridView.BringToFront();
        }

        public void ShowView(Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView dataGridView)
        {
            ////dataGridView.Location = new Point(3, 3);
            dataGridView.ShowTaskBar = true;
            dataGridView.ShowSearchPanel = true;
            dataGridView.IsMovableControl = true;
            SetFullScreenSize(this.BodyPanel, dataGridView);
            SetScreenLocation(this.BodyPanel, dataGridView);
            ////dataGridView.Size = new System.Drawing.Size(this.BodyPanel.Size.Width - 3, this.BodyPanel.Size.Height - 3);
            dataGridView.GetObservable().AddObserver(this);
            this.BodyPanel.Controls.Add(dataGridView);
            dataGridView.BringToFront();
            dataGridView.Invalidate();
            dataGridView.LoadDatas();
        }

        public override void UpdateObserver(object value, string message)
        {
            base.UpdateObserver(value, message);

            switch (message)
            {
                case "CLOSE TABLE VIEW":
                    this.BodyPanel.Controls.Remove(value as Control);
                    this.BodyPanel.Invalidate();
                    break;
            }
        }

        private void ViewTablesView_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void BodyPanel_Scroll(object sender, ScrollEventArgs e)
        {
            this.Validate();
        }

        private void SetFullScreenSize(Payanar.SS.Net.Libraries.Views.Controls.Panel bodyPanel, Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView dataGridView)
        {
            int x = 10;
            if (dataGridView.Size.Width > (bodyPanel.Size.Width - x) || dataGridView.Size.Height > (bodyPanel.Size.Height - x))
                dataGridView.Size = new System.Drawing.Size(bodyPanel.Size.Width - x, bodyPanel.Size.Height - x);
        }

        private void SetScreenLocation(Payanar.SS.Net.Libraries.Views.Controls.Panel bodyPanel, Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView dataGridView)
        {
            int x = 0;
            int y = 0;

            x = (bodyPanel.Width - dataGridView.Width) / 2;
            y = (bodyPanel.Height - dataGridView.Height) / 2;
            dataGridView.Location = new Point(x, y);
        }
    }
}