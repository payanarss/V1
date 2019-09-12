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
    public partial class AssessmentFactorCollectionView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView, IAssessmentFactorCollectionView, IView
    {
        #region Constructors

        public AssessmentFactorCollectionView()
            : base(AssessmentFactorCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "AssessmentFactor";
        }

        public AssessmentFactorCollectionView(IViewContext viewContext)
            : base(viewContext, AssessmentFactorCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public AssessmentFactorPresentationEntityCollection AssessmentFactorPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as AssessmentFactorPresentationEntityCollection; }
        }

        public AssessmentFactorPresenter AssessmentFactorPresenterDetail
        {
            get { return PresenterDetail as AssessmentFactorPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////AssessmentFactorPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
