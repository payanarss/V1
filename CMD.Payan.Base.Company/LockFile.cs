using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Payan.Base.Company
{
    public class LockFile
    {
        #region Variable Declarations

        private const string LOCKFILENAME = "Lock.dat";

        #endregion Variable Declarations

        #region Constructors

        #endregion Constructors

        #region Methods

        public bool IsLockFileExists()
        {
            return BaseFile.IsFileExists(LOCKFILENAME);
        }

        public void WriteLockFile(string value)
        {
            BaseFile.WriteBinaryFile(LOCKFILENAME, value.Trim(new char[] { '\r', '\n' }));
        }

        public string ReadLockFile()
        {
            return BaseFile.ReadBinaryFile(LOCKFILENAME);
        }

        #endregion
    }
}