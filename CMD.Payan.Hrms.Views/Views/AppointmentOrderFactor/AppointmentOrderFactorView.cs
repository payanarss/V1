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
    public partial class AppointmentOrderFactorView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, IAppointmentOrderFactorView, IView
    {
        #region Constructors

        public AppointmentOrderFactorView()
            : base(AppointmentOrderFactorPresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "AppointmentOrderFactor";
        }

        public AppointmentOrderFactorView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, AppointmentOrderFactorPresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "AppointmentOrderFactor";
        }

        #endregion Constructors

        #region Properties

        public AppointmentOrderFactorPresentationEntity AppointmentOrderFactorPresentationEntityDetail
        {
            get { return PresentationEntityDetail as AppointmentOrderFactorPresentationEntity; }
        }

        public AppointmentOrderFactorPresenter AppointmentOrderFactorPresenterDetail
        {
            get { return PresenterDetail as AppointmentOrderFactorPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            AppointmentOrderFactorPresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
