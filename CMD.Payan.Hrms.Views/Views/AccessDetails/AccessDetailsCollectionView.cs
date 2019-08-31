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
    public partial class AccessDetailsCollectionView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView, IAccessDetailsCollectionView, IView
    {
        #region Constructors

        public AccessDetailsCollectionView()
            : base(AccessDetailsCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "AccessDetails";
        }

        public AccessDetailsCollectionView(IViewContext viewContext)
            : base(viewContext, AccessDetailsCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public AccessDetailsPresentationEntityCollection AccessDetailsPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as AccessDetailsPresentationEntityCollection; }
        }

        public AccessDetailsPresenter AccessDetailsPresenterDetail
        {
            get { return PresenterDetail as AccessDetailsPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////AccessDetailsPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
