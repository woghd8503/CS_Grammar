using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace _01.BasicGrammar
{
    class Test3
    {
        static float Square(float inputNum)
        {
            float result = inputNum * inputNum;
            return result;
        }

        //static void Main(string[] args)
        //{
        //    Console.Write("수를 입력하세요: ");

        //    string input = Console.ReadLine();
        //    float inputNum = float.Parse(input);

        //    Console.WriteLine("결과 : " + Square(inputNum));
        //}
    }

    class Test3_1
    {
        //public static void Main()
        //{
        //    double mean = 0;
        //    mean = Mean(1, 2, 3, 4, 5, mean);

        //    Console.WriteLine("평균 : {0}", mean);
        //}
        public static double Mean(double a, double b, double c, double d, double e, double mean)
        {
            return mean = (a + b + c + d + e) / 5;
        }
    }

    class Test3_2
    {
        public static void Main()
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB); // 오버로드가 필요한 메소드입니다.

            Console.WriteLine("{0} + {1} = {2}", x, y, resultB);
        }

        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }

        // 이 아래에 double 형 매개변수를 받을 수 있도록
        // 오버로딩된 Plus() 메소드를 작성하세요.

        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }
    }
}