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
    public partial class InterviewFormHeaderView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, IInterviewFormHeaderView, IView
    {
        #region Constructors

        public InterviewFormHeaderView()
            : base(InterviewFormHeaderPresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "InterviewFormHeader";
        }

        public InterviewFormHeaderView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, InterviewFormHeaderPresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "InterviewFormHeader";
        }

        #endregion Constructors

        #region Properties

        public InterviewFormHeaderPresentationEntity InterviewFormHeaderPresentationEntityDetail
        {
            get { return PresentationEntityDetail as InterviewFormHeaderPresentationEntity; }
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
            InterviewFormHeaderPresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
