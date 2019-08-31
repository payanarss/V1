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
    public partial class CallLetterView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, ICallLetterView, IView
    {
        #region Constructors

        public CallLetterView()
            : base(CallLetterPresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "CallLetter";
        }

        public CallLetterView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, CallLetterPresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "CallLetter";
        }

        #endregion Constructors

        #region Properties

        public CallLetterPresentationEntity CallLetterPresentationEntityDetail
        {
            get { return PresentationEntityDetail as CallLetterPresentationEntity; }
        }

        public CallLetterPresenter CallLetterPresenterDetail
        {
            get { return PresenterDetail as CallLetterPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            CallLetterPresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
