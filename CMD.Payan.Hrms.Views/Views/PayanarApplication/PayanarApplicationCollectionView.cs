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
    public partial class PayanarApplicationCollectionView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView, IPayanarApplicationCollectionView, IView
    {
        #region Constructors

        public PayanarApplicationCollectionView()
            : base(PayanarApplicationCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "PayanarApplication";
        }

        public PayanarApplicationCollectionView(IViewContext viewContext)
            : base(viewContext, PayanarApplicationCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public PayanarApplicationPresentationEntityCollection PayanarApplicationPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as PayanarApplicationPresentationEntityCollection; }
        }

        public PayanarApplicationPresenter PayanarApplicationPresenterDetail
        {
            get { return PresenterDetail as PayanarApplicationPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////PayanarApplicationPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
