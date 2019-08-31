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
    public partial class TableSequanceNumberView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, ITableSequanceNumberView, IView
    {
        #region Constructors

        public TableSequanceNumberView()
            : base(TableSequanceNumberPresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "TableSequanceNumber";
        }

        public TableSequanceNumberView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, TableSequanceNumberPresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "TableSequanceNumber";
        }

        #endregion Constructors

        #region Properties

        public TableSequanceNumberPresentationEntity TableSequanceNumberPresentationEntityDetail
        {
            get { return PresentationEntityDetail as TableSequanceNumberPresentationEntity; }
        }

        public TableSequanceNumberPresenter TableSequanceNumberPresenterDetail
        {
            get { return PresenterDetail as TableSequanceNumberPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            TableSequanceNumberPresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
