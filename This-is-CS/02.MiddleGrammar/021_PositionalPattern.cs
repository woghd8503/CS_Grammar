using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 튜플이 분해가 가능한 이유는 분해자 Deconstructor를 구현하고 있기 때문인데요. 분해자를 구현하고 있는 객체를 분해한 결과를
// switch문이나

namespace Tuple
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 명명되지 않은 튜플
            var a = ( "슈펴맨", 9999 );
            Console.WriteLine($"{a.Item1}, {a.Item2}");

            // 명명된 튜플
            var b = (Name: "박상현", Age: 17);
            Console.WriteLine($"{b.Name}, {b.Age}");

            // 분해
            var (name, age) = b; // (var name, var age) = b;
            Console.WriteLine($"{name}, {age}");

            // 분해2
            var (name2, age2) = ( "박문수", 34);
            Console.WriteLine($"{name2}, {age2}");

            // 명명된 튜플 = 명명되지 않은 튜플
            b = a;
            Console.WriteLine($"{b.Name}, {b.Age}");
        }
    }
}
