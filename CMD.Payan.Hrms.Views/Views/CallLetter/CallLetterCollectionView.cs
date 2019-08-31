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
    public partial class CallLetterCollectionView : CMD.Payan.Base.Views.CustomControls.DataGridView, ICallLetterCollectionView, IView
    {
        #region Constructors

        public CallLetterCollectionView()
            : base(CallLetterCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = callLetterDataGridView;
            BindingSourceDetail = callLetterPresentationEntityBindingSource;
            Title = "CallLetter";
        }

        public CallLetterCollectionView(IViewContext viewContext)
            : base(viewContext, CallLetterCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = callLetterDataGridView;
            BindingSourceDetail = callLetterPresentationEntityBindingSource;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public CallLetterPresentationEntityCollection CallLetterPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as CallLetterPresentationEntityCollection; }
        }

        public CallLetterPresenter CallLetterPresenterDetail
        {
            get { return PresenterDetail as CallLetterPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////CallLetterPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
