using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002.MiddleGrammar
{
    internal class _049_UsingList
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.RemoveAt(2);

            foreach(object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.Add("abc");
            list.Add("def");

            for(int i = 0;)


        }
    }
}
