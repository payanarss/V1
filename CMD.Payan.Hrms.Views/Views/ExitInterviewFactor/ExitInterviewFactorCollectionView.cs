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
    public partial class ExitInterviewFactorCollectionView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView, IExitInterviewFactorCollectionView, IView
    {
        #region Constructors

        public ExitInterviewFactorCollectionView()
            : base(ExitInterviewFactorCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "ExitInterviewFactor";
        }

        public ExitInterviewFactorCollectionView(IViewContext viewContext)
            : base(viewContext, ExitInterviewFactorCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public ExitInterviewFactorPresentationEntityCollection ExitInterviewFactorPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as ExitInterviewFactorPresentationEntityCollection; }
        }

        public ExitInterviewFactorPresenter ExitInterviewFactorPresenterDetail
        {
            get { return PresenterDetail as ExitInterviewFactorPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////ExitInterviewFactorPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
