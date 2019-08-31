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
    public partial class UserRegistrationView : Net.Payanar.Base.Views.CustomControls.BaseView, IUserRegistrationView, IView
    {
        #region Constructors

        public UserRegistrationView()
            : base(UserRegistrationPresenterFactory.Factory)
        {
            InitializeComponent();
            Title = "UserRegistration";
        }

        public UserRegistrationView(IObserver observer, IPresentationEntity presentationEntity)
            : base(observer, UserRegistrationPresenterFactory.Factory, presentationEntity)
        {
            InitializeComponent();
            Title = "UserRegistration";
        }

        #endregion Constructors

        #region Properties

        public UserRegistrationPresentationEntity UserRegistrationPresentationEntityDetail
        {
            get { return PresentationEntityDetail as UserRegistrationPresentationEntity; }
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
            UserRegistrationPresentationEntityDetail.Load();
            base.LoadDatas();
        }

        #endregion Methods
    }
}