using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CMD.Payan.Base.Company;

namespace CMD.Payan.Base.Company
{
    public class FingerPrint
    {
        private static string fingerPrint = string.Empty;

        public static string Generate()
        {
            string value = string.Empty;

            if (string.IsNullOrEmpty(fingerPrint))
            {
                value = "Payanar.Software.Solutions, 281, Center Road, Classic Paradise Layout, Begur, Bangalore - 560068";
                fingerPrint = GetHash(value);
                fingerPrint += GetHash(fingerPrint);

                value = O();
                fingerPrint += GetHash(value);
                fingerPrint += GetHash(fingerPrint);
            }

            return fingerPrint;
        }

        private static string GetHash(string s)
        {
            MD5 sec = new MD5CryptoServiceProvider();
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] bt = enc.GetBytes(s);
            return GetHexString(sec.ComputeHash(bt));
        }

        private static string GetHexString(byte[] bt)
        {
            string s = string.Empty;
            int x = Convert.ToInt32(LicenseResource.NEMO);
            int y = Convert.ToInt32(LicenseResource.NSTMO);
            char alpha = Convert.ToChar(LicenseResource.Alphab);

            for (int i = 0; i < bt.Length; i++)
            {
                byte b = bt[i];
                int n, n1, n2;
                n = (int)b;
                n1 = n & y;
                n2 = (n >> 6) & y;
                if (n2 > x)
                    s += ((char)(n2 - x + (int)alpha)).ToString();
                else
                    s += n2.ToString();
                if (n1 > 10)
                    s += ((char)(n1 - x + (int)alpha)).ToString();
                else
                    s += n1.ToString();
            }

            return s;
        }

        private static string identifier
        (string wmiClass, string wmiProperty, string wmiMustBeTrue)
        {
            string result = "";
            System.Management.ManagementClass mc =
        new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                if (mo[wmiMustBeTrue].ToString() == "True")
                {
                    //Only get the first one
                    if (result == "")
                    {
                        try
                        {
                            result = mo[wmiProperty].ToString();
                            break;
                        }
                        catch
                        {
                        }
                    }
                }
            }

            return result;
        }

        private static string identifier(string wmiClass, string wmiProperty)
        {
            object moObj = null;
            string result = "";
            System.Management.ManagementClass mc =
        new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();

            foreach (System.Management.ManagementObject mo in moc)
            {
                //Only get the first one
                if (result == "")
                {
                    try
                    {
                        moObj = mo[wmiProperty];

                        if (moObj != null)
                        {
                            result = moObj.ToString();
                            result = string.Format("{0}_{1}\t", wmiProperty, result);
                            break;
                        }
                    }
                    catch
                    {
                    }
                }
            }

            return result;
        }

        private static string O()
        {
            string retVal = identifier(LicenseResource.WP, LicenseResource.Identifier);

            if (string.IsNullOrEmpty(retVal))
            {
                retVal = identifier(LicenseResource.WP, LicenseResource.PID);

                if (string.IsNullOrEmpty(retVal))
                {
                    retVal = identifier(LicenseResource.WP, LicenseResource.Name);

                    if (string.IsNullOrEmpty(retVal))
                    {
                        retVal = identifier(LicenseResource.WP, LicenseResource.FACT);
                    }

                    retVal += identifier(LicenseResource.WP, LicenseResource.MCS);
                }
            }

            return retVal + T();
        }

        private static string T()
        {
            return identifier(LicenseResource.BOS, LicenseResource.FACT)
            + identifier(LicenseResource.BOS, LicenseResource.BV)
            + identifier(LicenseResource.BOS, LicenseResource.IC)
            + identifier(LicenseResource.BOS, LicenseResource.SN)
            + identifier(LicenseResource.BOS, LicenseResource.RD)
            + identifier(LicenseResource.BOS, LicenseResource.VER) + H();
        }

        private static string H()
        {
            return identifier(LicenseResource.WBB, LicenseResource.MOD)
            + identifier(LicenseResource.WBB, LicenseResource.FACT)
            + identifier(LicenseResource.WBB, LicenseResource.Name)
            + identifier(LicenseResource.WBB, LicenseResource.SN) + R();
        }

        private static string R()
        {
            return identifier(LicenseResource.WNAC,
                LicenseResource.MACA, LicenseResource.IPE);
        }
    }
}