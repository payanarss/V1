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
    public partial class TableInformationCollectionView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView, ITableInformationCollectionView, IView
    {
        #region Constructors

        public TableInformationCollectionView()
            : base(TableInformationCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "TableInformation";
        }

        public TableInformationCollectionView(IViewContext viewContext)
            : base(viewContext, TableInformationCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public TableInformationPresentationEntityCollection TableInformationPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as TableInformationPresentationEntityCollection; }
        }

        public TableInformationPresenter TableInformationPresenterDetail
        {
            get { return PresenterDetail as TableInformationPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////TableInformationPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
