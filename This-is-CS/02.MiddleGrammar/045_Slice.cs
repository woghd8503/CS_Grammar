using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002.MiddleGrammar
{
    class _045_Slice
    {

        static void Main(string[] args)
        {
            static void PrintArray(System.Array array)
            {
                foreach (var e in array)
                    Console.Write(e);
                Console.WriteLine();
            }

            static void Main(string[] args)
            {
                char[] array = new char['Z' - 'A' + 1];
                for(int i = 0; i < array.Length; i++)
                    array[i] = (char)('A' + i);

                PrintArray(array[..]);       // 0번째부터 마지막까지
                PrintArray(array[5..]);      // 5번째부터 끝까지

                Range range_5_10 = 5..10;


            }
        }
    }
}
