using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002.MiddleGrammar
{
    class _047_3DArray
    {
        static void Main()
        {
            int[,,] array = new int[4, 3, 2]
            {
                { { 1, 2}, {3, 4}, {5, 6} },
                { { 1, 4}, {2, 5}, {3, 6} },
                { { 6, 5}, {4, 3}, {2, 1} },
                { { 6, 3}, {5, 2}, {2, 1} },
            };

            for (int i = 0; i < array.GetLength(1); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{ ");
                    for(int j = 0; j < array.GetLength(1); j++)
                    {

                    }
                }
            }
        }
    }
}
