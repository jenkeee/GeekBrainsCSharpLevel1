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
        public static void WriteBinary(string fileName, long size)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    for (int i = 0; i < size; i++)
                    {
                        writer.Write(0);
                    }
                }
            }
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
