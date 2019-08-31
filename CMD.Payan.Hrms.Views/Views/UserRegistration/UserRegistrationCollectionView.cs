using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Net.Payanar.Base.Views.CustomControls;
using Net.Payanar.Base.Common;
using Net.Payanar.Base.PresentationLayer.Interfaces;
using Net.Payanar.CMD.ERP.Plannings.Presenters;

namespace Net.Payanar.CMD.ERP.Plannings.Views
{
    public partial class UserRegistrationCollectionView : Net.Payanar.Base.Views.CustomControls.DataGridView, IUserRegistrationCollectionView, IView
    {
        #region Constructors

        public UserRegistrationCollectionView()
            : base(UserRegistrationCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "UserRegistration";
        }

        public UserRegistrationCollectionView(IViewContext viewContext)
            : base(viewContext, UserRegistrationCollectionPresenterFactory.Factory)
        {
            InitializeComponent();
            DataGridViewDetail = null;
            BindingSourceDetail = null;
            Title = "MaterialType";
        }

        #endregion Constructors

        #region Properties

        public UserRegistrationPresentationEntityCollection UserRegistrationPresentationEntityCollectionDetail
        {
            get { return PresentationEntityCollectionDetail as UserRegistrationPresentationEntityCollection; }
        }

        public UserRegistrationPresenter UserRegistrationPresenterDetail
        {
            get { return PresenterDetail as UserRegistrationPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void UpdateObserver(object value)
        {
            base.UpdateObserver(value);
        }

        public override void LoadDatas()
        {
            ////UserRegistrationPresentationEntityCollectionDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}