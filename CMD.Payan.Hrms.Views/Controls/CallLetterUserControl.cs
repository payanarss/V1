using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Payanar.SS.Net.Libraries.PresentationLayer.Interfaces;
using Payanar.SS.Net.Libraries.Common;
using CMD.Payan.Hrms.BusinessLayers;

namespace CMD.Payan.Hrms.Views
{

    public class CallLetterDateDateTimePicker : CMD.Payan.Base.Views.Controls.DateTimePicker
    {
        public CallLetterDateDateTimePicker() { }

        public CallLetterDateDateTimePicker(IPresentationEntity presentationEntity)
        {
            PresentationEntityInstance = presentationEntity;
        }

        private IPresentationEntity PresentationEntityInstance { get; set; }

        public void ApplyBindings()
        {
            this.DataBindings.Add("Text", PresentationEntityInstance, "BankHeading");
        }
    }

    public class CallLetterNumberTextBox : CMD.Payan.Base.Views.Controls.TextBox
    {
    }

    public class CandidateAddressTextBox : CMD.Payan.Base.Views.Controls.TextBox
    {
    }

    public class CandidateNameTextBox : CMD.Payan.Base.Views.Controls.TextBox
    {
    }

    public class CompanyCodeTextBox : CMD.Payan.Base.Views.Controls.TextBox
    {
    }

    public class ContactNumberTextBox : CMD.Payan.Base.Views.Controls.TextBox
    {
    }

    public class InterviewDateTextBox : CMD.Payan.Base.Views.Controls.TextBox
    {
    }

    public class InterviewTimeTextBox : CMD.Payan.Base.Views.Controls.TextBox
    {
    }

    public class PositionTextBox : CMD.Payan.Base.Views.Controls.TextBox
    {
    }

    public class RegardsTextBox : CMD.Payan.Base.Views.Controls.TextBox
    {
    }
}
