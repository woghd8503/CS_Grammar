using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FS = System.IO.FileStream;

namespace _0003._AdvanceGrammar
{
    class _038_UsingDeclaration
    {
        static void Main(string[] args)
        {
            long someValue = 0x123456789ABCDEF0;
            Console.WriteLine("{0,-1} : 0X{1:X16}", "Original Data", someValue);

            using (Stream outStream = new FS("a.dat", FileMode.Create))
            {
                byte[] wBytes = BitConverter.GetBytes(someValue);

                Console.Write("{0,-13} : ", "Byte array");

                foreach(byte b in wBytes)
                    Console.Write("{0:X2} ", b);
                Console.WriteLine();

                outStream.Write(wBytes, 0, wBytes.Length);
            }

            using Stream inStream = new FS("a.bat", FileMode.Open);
            byte[] rBytes = new byte[8];

            int i = 0;
            while (inStream.Position < inStream.Length)
                rBytes[i++] = (byte)inStream.ReadByte();

            long readValue = BitConverter.ToInt64(rBytes, 0);

            Console.WriteLine("{0,-13} : 0x{1:16} ", "Read Data", readValue);
        }
    }
}
