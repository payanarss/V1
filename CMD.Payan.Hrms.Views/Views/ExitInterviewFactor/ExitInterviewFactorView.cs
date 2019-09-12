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
    public partial class ExitInterviewFactorView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, IExitInterviewFactorView, IView
    {
        #region Constructors

        public ExitInterviewFactorView()
            : base(ExitInterviewFactorPresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "ExitInterviewFactor";
        }

        public ExitInterviewFactorView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, ExitInterviewFactorPresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "ExitInterviewFactor";
        }

        #endregion Constructors

        #region Properties

        public ExitInterviewFactorPresentationEntity ExitInterviewFactorPresentationEntityDetail
        {
            get { return PresentationEntityDetail as ExitInterviewFactorPresentationEntity; }
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
            ExitInterviewFactorPresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
