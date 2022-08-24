using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System;

//namespace CodingStudy
//{
//    class CodingStudy
//    {
//        static void Main()
//        {
//            string[] input = Console.ReadLine().Split();
//            int A = int.Parse(input[0]);
//            int B = int.Parse(input[1]);
//            int C = int.Parse(input[2]);

//            Console.WriteLine((A + B) % C);
//            Console.WriteLine((A % C) + (B % C) % C);
//            Console.WriteLine((A * B) % C);
//            Console.WriteLine((A % C) * (B % C) % C);
//        }
//    }

//}


using System;

namespace CodingStudy
{
    class CodingStudy
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if (num >= 90)
                Console.WriteLine("A");
            else if (num >= 80)
                Console.WriteLine("B");
            else if (num >= 70)
                Console.WriteLine("C");
            else if (num >= 60)
                Console.WriteLine("D");
            else if (num < 60)
                Console.WriteLine("F");
        }
    }

}
