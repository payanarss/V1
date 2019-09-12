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
    public partial class PayanarApplicationView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, IPayanarApplicationView, IView
    {
        #region Constructors

        public PayanarApplicationView()
            : base(PayanarApplicationPresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "PayanarApplication";
        }

        public PayanarApplicationView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, PayanarApplicationPresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "PayanarApplication";
        }

        #endregion Constructors

        #region Properties

        public PayanarApplicationPresentationEntity PayanarApplicationPresentationEntityDetail
        {
            get { return PresentationEntityDetail as PayanarApplicationPresentationEntity; }
        }

        public PayanarApplicationPresenter PayanarApplicationPresenterDetail
        {
            get { return PresenterDetail as PayanarApplicationPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            PayanarApplicationPresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
