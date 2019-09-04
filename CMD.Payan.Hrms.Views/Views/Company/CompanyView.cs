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
    public partial class CompanyView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, ICompanyView, IView
    {
        #region Constructors

        public CompanyView()
            : base(CompanyPresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "Company";
        }

        public CompanyView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, CompanyPresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "Company";
        }

        #endregion Constructors

        #region Properties

        public CompanyPresentationEntity CompanyPresentationEntityDetail
        {
            get { return PresentationEntityDetail as CompanyPresentationEntity; }
        }

        public CompanyPresenter CompanyPresenterDetail
        {
            get { return PresenterDetail as CompanyPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            CompanyPresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
