using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.BusinessLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;
using CMD.Payan.Hrms.BusinessLayers;

namespace CMD.Payan.Hrms.Presenters
{
    public class AccessDetailsPresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public AccessDetailsPresentationEntity(IPresenter presenter)
            : base(presenter, AccessDetailsFactory.Factory)
        {
        }

        public AccessDetailsPresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public AccessDetailsPresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public AccessDetailsPresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, AccessDetailsFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties
	
        public System.String AccDate
        {
            get { return AccessDetailsDetail.AccDate; }
            set { AccessDetailsDetail.AccDate = value; }
        }

        public System.Decimal AccTime
        {
            get { return AccessDetailsDetail.AccTime; }
            set { AccessDetailsDetail.AccTime = value; }
        }

        public System.String DoorNo
        {
            get { return AccessDetailsDetail.DoorNo; }
            set { AccessDetailsDetail.DoorNo = value; }
        }

        public System.String EmpCode
        {
            get { return AccessDetailsDetail.EmpCode; }
            set { AccessDetailsDetail.EmpCode = value; }
        }

        public System.String EmpName
        {
            get { return AccessDetailsDetail.EmpName; }
            set { AccessDetailsDetail.EmpName = value; }
        }

        public System.String Empno
        {
            get { return AccessDetailsDetail.Empno; }
            set { AccessDetailsDetail.Empno = value; }
        }

        public System.String Flg
        {
            get { return AccessDetailsDetail.Flg; }
            set { AccessDetailsDetail.Flg = value; }
        }

        public System.Int64 RNo
        {
            get { return AccessDetailsDetail.RNo; }
            set { AccessDetailsDetail.RNo = value; }
        }

        public System.String Status
        {
            get { return AccessDetailsDetail.Status; }
            set { AccessDetailsDetail.Status = value; }
        }

        public AccessDetails AccessDetailsDetail
        {
            get { return BusinessObjectDetail as AccessDetails; }
        }

        private AccessDetailsPresenter AccessDetailsPresenterDetail
        {
            get { return PresenterDetail as AccessDetailsPresenter; }
        }

        #endregion Properties

        #region Methods

        public override void OnViewReady()
        {
            base.OnViewReady();
        }

        #endregion Methods
    }
}
