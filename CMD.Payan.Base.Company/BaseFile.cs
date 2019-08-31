using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Payan.Base.Company
{
    public class BaseFile
    {
        public static bool IsFileExists(string fileName)
        {
            return File.Exists(fileName);
        }

        public static void WriteTextFile(string fileName, string value)
        {
            TextWriter writer = new StreamWriter(fileName);
            writer.WriteLine(value);
            writer.Close();
        }

        public static void WriteBinaryFile(string fileName, string value)
        {
            BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Append));
            writer.Write(value);
            writer.Close();
        }

        public static string ReadTextFile(string fileName)
        {
            string value = string.Empty;

            if (IsFileExists(fileName))
            {
                TextReader reader = new StreamReader(fileName);
                value = reader.ReadToEnd();
                reader.Close();
            }

            return value;
        }

        public static string ReadBinaryFile(string fileName)
        {
            string value = string.Empty;

            if (IsFileExists(fileName))
            {
                BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open));
                value = reader.ReadString();
                reader.Close();
            }

            return value;
        }
    }
}