using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002._MiddleGrammar
{
    internal class _057_CopyingArray
    {
        static void CopyingArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }

        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyingArray<int>(source, target);

            foreach (int element in target)
                Console.WriteLine(element);

            string[] source2 = { "하나", "둘", "셋", "다섯" };
            string[] target2 = new string[source2.Length];

            CopyingArray<string>(source2, target2);

            foreach (string element in target2)
                Console.WriteLine(element);
        }
    }
}
