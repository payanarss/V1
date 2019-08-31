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
    public partial class InterviewFormDetailsView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, IInterviewFormDetailsView, IView
    {
        #region Constructors

        public InterviewFormDetailsView()
            : base(InterviewFormDetailsPresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "InterviewFormDetails";
        }

        public InterviewFormDetailsView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, InterviewFormDetailsPresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "InterviewFormDetails";
        }

        #endregion Constructors

        #region Properties

        public InterviewFormDetailsPresentationEntity InterviewFormDetailsPresentationEntityDetail
        {
            get { return PresentationEntityDetail as InterviewFormDetailsPresentationEntity; }
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
            InterviewFormDetailsPresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
