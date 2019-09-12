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
    public partial class AppointmentOrderFactorCollectionView : Payanar.SS.Net.Libraries.Views.CustomControls.DataGridView, IAppointmentOrderFactorCollectionView, IView
    {
        #region Constructors

        public AppointmentOrderFactorCollectionView()
            : base(AppointmentOrderFactorCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "AppointmentOrderFactor";
        }

        public AppointmentOrderFactorCollectionView(IViewContext viewContext)
            : base(viewContext, AppointmentOrderFactorCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public AppointmentOrderFactorPresentationEntityCollection AppointmentOrderFactorPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as AppointmentOrderFactorPresentationEntityCollection; }
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
            ////AppointmentOrderFactorPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
