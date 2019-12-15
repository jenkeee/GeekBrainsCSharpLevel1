using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4ReadFile
{
    internal static class ReadWrite
    {
        public static byte[] ReadFileStream(string fileName)
        {
            byte[] arr;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                arr = new byte[fs.Length];
                for (int i = 0; i < fs.Length; i++)
                {
                    arr[i] = (byte) fs.ReadByte();
                }
            }
            return arr;
        }
        public static void WriteFileStream(string fileName, long size)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                for (int i = 0; i < size; i++)
                {
                    fs.WriteByte(0);
                }
            }
        }
        public static int[] ReadBinary(string fileName)
        {
            int[] arr;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    arr = new int[fs.Length];
                    for (int i = 0; i < fs.Length; i++)
                    {
                        arr[i] = reader.Read();
                    }
                }
            }
            return arr;
        }
        public static void WriteBinary(string fileName, long size)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    for (int i = 0; i < size; i++)
                    {
                        writer.Write((byte)0);
                    }
                }
            }
        }
        public static string ReadStreamReader(string fileName)
        {
            StringBuilder sb;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    sb = new StringBuilder();
                    for (int i = 0; i < fs.Length; i++)
                    {
                        sb.Append($"{(char) reader.Read()} ");
                    }
                }
            }
            return sb.ToString();
        }
        public static void WriteStreamWriter(string fileName, long size)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    for (int i = 0; i < size; i++)
                    {
                        writer.Write(0);
                    }
                }
            }
        }
        public static byte[] ReadBufferedSteam(string fileName)
        {
            byte[] arr;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                int countPart = 4;
                int bufSize = (int)fs.Length / countPart;
                arr = new byte[fs.Length];
                BufferedStream reader = new BufferedStream(fs);
                for (int i = 0; i < countPart; i++)
                {
                    reader.Read(arr, i * bufSize, bufSize);
                }
            }
            return arr;
        }
        public static void WriteBufferedStream(string fileName, long size)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                int countPart = 4;
                int bufSize = (int) (size / countPart);
                byte[] buffer = new byte[size];
                using (BufferedStream bs = new BufferedStream(fs, bufSize))
                {
                    for (int i = 0; i < countPart; i++)
                    {
                        bs.Write(buffer, 0, bufSize);
                    }
                }
            }
        }
    }
}
