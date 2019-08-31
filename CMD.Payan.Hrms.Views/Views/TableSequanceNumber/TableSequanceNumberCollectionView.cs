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
    public partial class TableSequanceNumberCollectionView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView, ITableSequanceNumberCollectionView, IView
    {
        #region Constructors

        public TableSequanceNumberCollectionView()
            : base(TableSequanceNumberCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "TableSequanceNumber";
        }

        public TableSequanceNumberCollectionView(IViewContext viewContext)
            : base(viewContext, TableSequanceNumberCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public TableSequanceNumberPresentationEntityCollection TableSequanceNumberPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as TableSequanceNumberPresentationEntityCollection; }
        }

        public TableSequanceNumberPresenter TableSequanceNumberPresenterDetail
        {
            get { return PresenterDetail as TableSequanceNumberPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////TableSequanceNumberPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
