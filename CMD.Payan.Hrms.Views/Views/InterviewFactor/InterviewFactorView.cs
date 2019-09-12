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
    public partial class InterviewFactorView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, IInterviewFactorView, IView
    {
        #region Constructors

        public InterviewFactorView()
            : base(InterviewFactorPresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "InterviewFactor";
        }

        public InterviewFactorView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, InterviewFactorPresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "InterviewFactor";
        }

        #endregion Constructors

        #region Properties

        public InterviewFactorPresentationEntity InterviewFactorPresentationEntityDetail
        {
            get { return PresentationEntityDetail as InterviewFactorPresentationEntity; }
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
            InterviewFactorPresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
