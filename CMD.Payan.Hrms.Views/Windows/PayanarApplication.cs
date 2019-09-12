using CMD.Payan.Hrms.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.Views
{
    public class PayanarApplication
    {
        public static void OnStart()
        {
            PayanarApplicationPresentationEntityInstance.OnViewReady();
        }

        public static void OnStop()
        {
        }

        private static PayanarApplicationPresentationEntity PayanarApplicationPresentationEntityInstance
        {
            get
            {
                return PayanarApplicationPresentationEntity.PayanarApplicationPresentationEntityInstance;
            }
        }
    }
}
