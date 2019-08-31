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
    public partial class InterviewFormHeaderCollectionView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView, IInterviewFormHeaderCollectionView, IView
    {
        #region Constructors

        public InterviewFormHeaderCollectionView()
            : base(InterviewFormHeaderCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "InterviewFormHeader";
        }

        public InterviewFormHeaderCollectionView(IViewContext viewContext)
            : base(viewContext, InterviewFormHeaderCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public InterviewFormHeaderPresentationEntityCollection InterviewFormHeaderPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as InterviewFormHeaderPresentationEntityCollection; }
        }

        public InterviewFormHeaderPresenter InterviewFormHeaderPresenterDetail
        {
            get { return PresenterDetail as InterviewFormHeaderPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////InterviewFormHeaderPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
