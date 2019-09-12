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
    public partial class AssessmentFactorView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, IAssessmentFactorView, IView
    {
        #region Constructors

        public AssessmentFactorView()
            : base(AssessmentFactorPresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "AssessmentFactor";
        }

        public AssessmentFactorView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, AssessmentFactorPresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "AssessmentFactor";
        }

        #endregion Constructors

        #region Properties

        public AssessmentFactorPresentationEntity AssessmentFactorPresentationEntityDetail
        {
            get { return PresentationEntityDetail as AssessmentFactorPresentationEntity; }
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
            AssessmentFactorPresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
