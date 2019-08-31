using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.BusinessLayer;
using Payanar.SS.Net.Libraries.Common;
using CMD.Payan.Hrms.BusinessEntities;
using CMD.Payan.Hrms.DatabaseLayer;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class InterviewGrade : BusinessObject, IParent
    {
        #region Private Variables

        #endregion Private Variables

        #region Constructors

        public InterviewGrade()
            : base(InterviewGradeEntityFactory.Factory, InterviewGradeDatabaseAgentFactory.Factory)
        { }

 	public InterviewGrade(IParent parent)
            : base(InterviewGradeEntityFactory.Factory, InterviewGradeDatabaseAgentFactory.Factory, parent)
        { }

        #endregion Constructors

        #region Properties
	
        public System.String Code
        {
            get { return InterviewGradeEntityDetail.Code; }
            set { InterviewGradeEntityDetail.Code = value; }
        }

        public System.String Description
        {
            get { return InterviewGradeEntityDetail.Description; }
            set { InterviewGradeEntityDetail.Description = value; }
        }

        private InterviewGradeEntity InterviewGradeEntityDetail
        {
            get { return BusinessEntityObject as InterviewGradeEntity; }
        }

        #endregion Properties

        #region Methods

        #region Public

        public override int Load()
        {
            int result = 0;

            result += base.Load();

            return result;
        }

        #endregion Public

        #region Protected

        protected override bool ValidateBeforeSave()
        {
            bool isValid = base.ValidateBeforeSave();

            return isValid;
        }

        protected override bool ValidateBeforeDelete()
        {
            bool isValid = base.ValidateBeforeDelete();

            return isValid;
        }

        #endregion Protected

	#endregion Methods
    }
}
