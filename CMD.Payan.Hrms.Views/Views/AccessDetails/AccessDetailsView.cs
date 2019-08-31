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
    public partial class AccessDetailsView : Payanar.SS.Net.Libraries.Views.CustomControls.BaseView, IAccessDetailsView, IView
    {
        #region Constructors

        public AccessDetailsView()
            : base(AccessDetailsPresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "AccessDetails";
        }

        public AccessDetailsView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, AccessDetailsPresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "AccessDetails";
        }

        #endregion Constructors

        #region Properties

        public AccessDetailsPresentationEntity AccessDetailsPresentationEntityDetail
        {
            get { return PresentationEntityDetail as AccessDetailsPresentationEntity; }
        }

        public AccessDetailsPresenter AccessDetailsPresenterDetail
        {
            get { return PresenterDetail as AccessDetailsPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            AccessDetailsPresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}
