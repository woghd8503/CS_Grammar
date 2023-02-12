using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    class _039_BinaryFile
    {
        static void Main(string[] args)
        {
            using (BinaryWriter bw =
                new BinaryWriter(
                    new FileStream("a.bat", FileMode.Create)))
            {
                bw.Write(int.MaxValue);
                bw.Write("Good morning!");
                bw.Write(uint.MaxValue);
                bw.Write("안녕하세요!");
                bw.Write(double.MaxValue);
            }

            using BinaryReader br =
                new BinaryReader(
                    new FileStream("a.bat", FileMode.Open));

            Console.WriteLine($"File size : {br.BaseStream.Length} bytes");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadDouble()}");
        }
    }
}
