using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMD.Payan.Base.Company;

namespace CMD.Payan.Base.Company
{
    public class LockAndKeyFile
    {
        public LockAndKeyFile()
        {
            LockFileDetail = new LockFile();
            KeyFileDetail = new KeyFile();
        }

        public LockFile LockFileDetail { get; set; }

        public KeyFile KeyFileDetail { get; set; }

        public bool CheckLockAndKey()
        {
            bool isLockAndKeyMatches = false;

            if (!LockFileDetail.IsLockFileExists())
            {
                string lockValue = FingerPrint.Generate();
                LockFileDetail.WriteLockFile(lockValue);
                throw new Exception(LicenseResource.DllNotInstalled);
            }
            else if (KeyFileDetail.IsKeyFileExists())
            {
                isLockAndKeyMatches = IsLockAndKeyMatches();

                if (!isLockAndKeyMatches)
                    throw new Exception(LicenseResource.DllNotInstalled);
            }
            else
            {
                throw new Exception(LicenseResource.DllNotInstalled);
            }

            return isLockAndKeyMatches;
        }

        private void WriteLockFile(string value)
        {
            LockFileDetail.WriteLockFile(value);
        }

        public string ReadLockFile()
        {
            return LockFileDetail.ReadLockFile();
        }

        private void WriteKeyFile(string value)
        {
            KeyFileDetail.WriteKeyFile(value);
        }

        public string ReadKeyFile()
        {
            return KeyFileDetail.ReadKeyFile();
        }

        public bool IsLockAndKeyMatches()
        {
            string lockValue = ReadLockFile().Trim(new char[] { '\r', '\n' });
            string keyValue = ReadKeyFile().Trim(new char[] { '\r', '\n' });
            return lockValue.Equals(keyValue);
        }
    }
}