using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    internal class _040_TextFile
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw =
                new StreamWriter(
                    new FileStream("a.txt", FileMode.Create)))
            {
                sw.WriteLine(int.MaxValue);
                sw.WriteLine("Good morning!");
            }
        }
    }
}
