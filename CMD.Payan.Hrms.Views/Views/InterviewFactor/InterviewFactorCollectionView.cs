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
    public partial class InterviewFactorCollectionView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView, IInterviewFactorCollectionView, IView
    {
        #region Constructors

        public InterviewFactorCollectionView()
            : base(InterviewFactorCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "InterviewFactor";
        }

        public InterviewFactorCollectionView(IViewContext viewContext)
            : base(viewContext, InterviewFactorCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public InterviewFactorPresentationEntityCollection InterviewFactorPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as InterviewFactorPresentationEntityCollection; }
        }

        public InterviewFactorPresenter InterviewFactorPresenterDetail
        {
            get { return PresenterDetail as InterviewFactorPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////InterviewFactorPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
