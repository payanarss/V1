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
    public partial class InterviewFormDetailsCollectionView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView, IInterviewFormDetailsCollectionView, IView
    {
        #region Constructors

        public InterviewFormDetailsCollectionView()
            : base(InterviewFormDetailsCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "InterviewFormDetails";
        }

        public InterviewFormDetailsCollectionView(IViewContext viewContext)
            : base(viewContext, InterviewFormDetailsCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public InterviewFormDetailsPresentationEntityCollection InterviewFormDetailsPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as InterviewFormDetailsPresentationEntityCollection; }
        }

        public InterviewFormDetailsPresenter InterviewFormDetailsPresenterDetail
        {
            get { return PresenterDetail as InterviewFormDetailsPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////InterviewFormDetailsPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
