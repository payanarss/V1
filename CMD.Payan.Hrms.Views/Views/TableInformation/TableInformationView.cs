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
    public partial class TableInformationView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, ITableInformationView, IView
    {
        #region Constructors

        public TableInformationView()
            : base(TableInformationPresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "TableInformation";
        }

        public TableInformationView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, TableInformationPresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "TableInformation";
        }

        #endregion Constructors

        #region Properties

        public TableInformationPresentationEntity TableInformationPresentationEntityDetail
        {
            get { return PresentationEntityDetail as TableInformationPresentationEntity; }
        }

        public TableInformationPresenter TableInformationPresenterDetail
        {
            get { return PresenterDetail as TableInformationPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            TableInformationPresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
