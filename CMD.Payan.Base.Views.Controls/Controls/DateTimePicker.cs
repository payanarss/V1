using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMD.Payan.Base.Views.Controls
{
    public class DateTimePicker : Payanar.SS.Net.Libraries.Views.Controls.DateTimePicker
    {
        public DateTimePicker()
        {
            Format = DateTimePickerFormat.Short;
        }
    }
}