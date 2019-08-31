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
    public partial class InterviewGradeCollectionView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView, IInterviewGradeCollectionView, IView
    {
        #region Constructors

        public InterviewGradeCollectionView()
            : base(InterviewGradeCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "InterviewGrade";
        }

        public InterviewGradeCollectionView(IViewContext viewContext)
            : base(viewContext, InterviewGradeCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public InterviewGradePresentationEntityCollection InterviewGradePresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as InterviewGradePresentationEntityCollection; }
        }

        public InterviewGradePresenter InterviewGradePresenterDetail
        {
            get { return PresenterDetail as InterviewGradePresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////InterviewGradePresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
