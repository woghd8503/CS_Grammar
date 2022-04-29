using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 튜플 Tuple도 여러 필드를 담을 수 있는 구조체입니다. 하지만 앞서 살펴봤던 구조체와는 달리 튜플은
// 형식 이름이 없습니다. 그래서 튜플은 응용 프로그램 전체에서 사용할 형식을 선언할 대가 아닌, 즉
// 석에서 사용할 복합 데이터 형식을 선언할 때 적합합니다. 튜플은 구조체이므로 값 형식입니다. 값
// 형식은 생성된 지역을 벗어나면 스택에서 소멸되기 때문에 프로그램에 장기적인 부담을 주지 않는 
// 다는 장점이 있죠.

namespace Tuple
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 명명되지 않은 튜플
            var a = { "슈펴맨", 9999 };
            Console.WriteLine($"{a.Item1}, {a.Item2}");

            // 명명된 튜플
            var b = (Name: "박상현", Age: 17);
            Console.WriteLine($"{b.Name}, {b.Age}");

            // 분해
            var (name, age) = b; // (var name, var age) = b;
            Console.WriteLine($"{name}, {age}");

            // 분해2
            var (name, age) 
        }
    }
}
