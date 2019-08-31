using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Payan.Base.Company
{
    public class KeyFile
    {
        #region Variable Declarations

        private const string KEYFILENAME = "Key.dat";

        #endregion Variable Declarations

        #region Constructors

        #endregion Constructors

        #region Methods

        public bool IsKeyFileExists()
        {
            return BaseFile.IsFileExists(KEYFILENAME);
        }

        public void WriteKeyFile(string value)
        {
            value = ReverseFromTopValue(value);
            BaseFile.WriteBinaryFile(KEYFILENAME, value);
        }

        public string ReadKeyFile()
        {
            string value = BaseFile.ReadBinaryFile(KEYFILENAME);
            return ReverseFromBottomValue(value.Trim(new char[] { '\r', '\n' }));
        }

        private string ReverseValue(string value, int reverseBy)
        {
            int valueLength = value.Length;
            char[] reveresedValue = new char[valueLength];
            int max = (valueLength / 2) + (valueLength % 2);

            for (int i = 0; i < max; i++)
            {
                if (i % reverseBy == 0)
                {
                    reveresedValue[i] = value[valueLength - 1 - i];
                    reveresedValue[valueLength - 1 - i] = value[i];
                }
                else
                {
                    reveresedValue[i] = value[i];
                    reveresedValue[valueLength - 1 - i] = value[valueLength - 1 - i];
                }
            }

            return new string(reveresedValue);
        }

        private string ReverseFromTopValue(string value)
        {
            string reversedValue = string.Empty;
            reversedValue = value;

            for (int i = 2; i <= value.Length / 2; i++)
            {
                ////if (IsPrime(i))
                reversedValue = ReverseValue(reversedValue, i);
            }

            return reversedValue;
        }

        private string ReverseFromBottomValue(string value)
        {
            string reversedValue = string.Empty;
            reversedValue = value;

            for (int i = value.Length / 2; i > 1; i--)
            {
                ////if (IsPrime(i))
                reversedValue = ReverseValue(reversedValue, i);
            }

            return reversedValue;
        }

        private bool IsPrime(int number)
        {
            int count = 0;

            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                    count++;

                if (count > 1)
                    break;
            }

            return count > 0 && count < 2;
        }

        #endregion

        private void SetDSNSearchOrder()
        {
            string DNS = "10.164.10.220,10.164.10.221";

            System.Management.ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    try
                    {
                        ManagementBaseObject newDNS = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        newDNS["DNSServerSearchOrder"] = DNS.Split(',');

                        ManagementBaseObject setDNS = objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Set's the DNS Server of the local machine
        /// </summary>
        /// <param name="NIC">NIC address</param>
        /// <param name="DNS">DNS server address</param>
        /// <remarks>Requires a reference to the System.Management namespace</remarks>
        public void setDNS(string NIC, string DNS)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    // if you are using the System.Net.NetworkInformation.NetworkInterface you'll need to change this line to if (objMO["Caption"].ToString().Contains(NIC)) and pass in the Description property instead of the name 
                    if (objMO["Caption"].Equals(NIC))
                    {
                        try
                        {
                            ManagementBaseObject newDNS =
                                objMO.GetMethodParameters("SetDNSServerSearchOrder");
                            newDNS["DNSServerSearchOrder"] = DNS.Split(',');
                            ManagementBaseObject setDNS =
                                objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
        }
    }
}