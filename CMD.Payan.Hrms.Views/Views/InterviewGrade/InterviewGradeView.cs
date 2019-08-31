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
    public partial class InterviewGradeView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, IInterviewGradeView, IView
    {
        #region Constructors

        public InterviewGradeView()
            : base(InterviewGradePresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "InterviewGrade";
        }

        public InterviewGradeView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, InterviewGradePresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "InterviewGrade";
        }

        #endregion Constructors

        #region Properties

        public InterviewGradePresentationEntity InterviewGradePresentationEntityDetail
        {
            get { return PresentationEntityDetail as InterviewGradePresentationEntity; }
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
            InterviewGradePresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
