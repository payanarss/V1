using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.Views.CustomControls;
using Payanar.SS.Net.Libraries.Common;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using CMD.Payan.Hrms.Presenters;

namespace CMD.Payan.Hrms.Views
{
    public partial class EmployeeDetailCollectionView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView, IEmployeeDetailCollectionView, IView
    {
        #region Constructors

        public EmployeeDetailCollectionView()
            : base(EmployeeDetailCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "EmployeeDetail";
        }

        public EmployeeDetailCollectionView(IViewContext viewContext)
            : base(viewContext, EmployeeDetailCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public EmployeeDetailPresentationEntityCollection EmployeeDetailPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as EmployeeDetailPresentationEntityCollection; }
        }

        public EmployeeDetailPresenter EmployeeDetailPresenterDetail
        {
            get { return PresenterDetail as EmployeeDetailPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////EmployeeDetailPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
