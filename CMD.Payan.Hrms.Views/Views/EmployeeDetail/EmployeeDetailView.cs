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
    public partial class EmployeeDetailView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, IEmployeeDetailView, IView
    {
        #region Constructors

        public EmployeeDetailView()
            : base(EmployeeDetailPresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "EmployeeDetail";
        }

        public EmployeeDetailView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, EmployeeDetailPresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "EmployeeDetail";
        }

        #endregion Constructors

        #region Properties

        public EmployeeDetailPresentationEntity EmployeeDetailPresentationEntityDetail
        {
            get { return PresentationEntityDetail as EmployeeDetailPresentationEntity; }
        }

        public EmployeeDetailPresenter EmployeeDetailPresenterDetail
        {
            get { return PresenterDetail as EmployeeDetailPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            EmployeeDetailPresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
