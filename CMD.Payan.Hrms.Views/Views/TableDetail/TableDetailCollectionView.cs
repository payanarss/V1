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
    public partial class TableDetailCollectionView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView, ITableDetailCollectionView, IView
    {
        #region Constructors

        public TableDetailCollectionView()
            : base(TableDetailCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "TableDetail";
        }

        public TableDetailCollectionView(IViewContext viewContext)
            : base(viewContext, TableDetailCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public TableDetailPresentationEntityCollection TableDetailPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as TableDetailPresentationEntityCollection; }
        }

        public TableDetailPresenter TableDetailPresenterDetail
        {
            get { return PresenterDetail as TableDetailPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////TableDetailPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
