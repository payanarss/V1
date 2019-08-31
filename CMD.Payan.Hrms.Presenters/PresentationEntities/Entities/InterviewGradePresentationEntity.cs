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
    public class InterviewGradePresentationEntity : PresentationEntity, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public InterviewGradePresentationEntity(IPresenter presenter)
            : base(presenter, InterviewGradeFactory.Factory)
        {
        }

        public InterviewGradePresentationEntity(IPresenter presenter, IBusinessObject businessObject)
            : base(presenter, businessObject)
        {
        }

        public InterviewGradePresentationEntity(IObserver observer, IPresenter presenter, IBusinessObject businessObject)
            : base(observer, presenter, businessObject)
        {
        }

        public InterviewGradePresentationEntity(IObserver observer, IPresenter presenter)
            : base(observer, presenter, InterviewGradeFactory.Factory)
        {
        }

        #endregion Constructors

        #region Properties
	
        public System.String Code
        {
            get { return InterviewGradeDetail.Code; }
            set { InterviewGradeDetail.Code = value; }
        }

        public System.String Description
        {
            get { return InterviewGradeDetail.Description; }
            set { InterviewGradeDetail.Description = value; }
        }

        public InterviewGrade InterviewGradeDetail
        {
            get { return BusinessObjectDetail as InterviewGrade; }
        }

        private InterviewGradePresenter InterviewGradePresenterDetail
        {
            get { return PresenterDetail as InterviewGradePresenter; }
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
