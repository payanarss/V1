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
    public partial class CompanyCollectionView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView, ICompanyCollectionView, IView
    {
        #region Constructors

        public CompanyCollectionView()
            : base(CompanyCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "Company";
        }

        public CompanyCollectionView(IViewContext viewContext)
            : base(viewContext, CompanyCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public CompanyPresentationEntityCollection CompanyPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as CompanyPresentationEntityCollection; }
        }

        public CompanyPresenter CompanyPresenterDetail
        {
            get { return PresenterDetail as CompanyPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////CompanyPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
