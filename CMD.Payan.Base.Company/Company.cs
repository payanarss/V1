using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Base.Company
{
    public class Company : Payanar.SS.Net.Libraries.Company.Company
    {
        private static Company _company = null;
        private static object _lockObject = new object();

        private Company()
            : base()
        {
            Name = "CMD.Payan";
        }

        public static Company CompanyDetail
        {
            get
            {
                lock (_lockObject)
                {
                    if (_company == null)
                    {
                        _company = new Company();
                    }
                }

                return _company;
            }
        }

        public bool CheckLockAndKey()
        {
            LockAndKeyFile lockAndKeyFile = new LockAndKeyFile();
            return lockAndKeyFile.CheckLockAndKey();
        }
    }
}