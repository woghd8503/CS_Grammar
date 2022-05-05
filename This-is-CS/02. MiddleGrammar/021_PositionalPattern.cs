using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 튜플이 분해가 가능한 이유는 분해자 Deconstructor를 구현하고 있기 때문인데요. 분해자를 구현하고 있는 객체를 분해한 결과를
// switch문이나 switch 식의 분기 조건에 활용할 수 있습니다. 이것을 어려운 말로 위치 패턴 매칭 Positional Pattern Matching이라고 합니다.
// 식별자나 데이터 형식이 아닌 분해된 요소의 위치에 따라 값이 일치하는지를 판단하는 것이죠. 

namespace PositionalPattern
{
    class MainApp
    {
        private static double GetDiscountRate(object client)
        {
            return client switch
            {
                ("학생", int n) when n < 18 => 0.2, // 학생 & 18세 미만
                ("학생", _) => 0.1, // 학생 & 18세 이상
                ("일반", int n) when n < 18 => 0.1, // 일반 & 18세 미만
                ("일반", _) => 0.05, // 일반 & 18세 이상
                _ => 0,
            };
        }

        static void Main(string[] args)
        {
            var alice = (job: "학생", age: 17);
            var bob = (job: "학생", age: 23);
            var charlie = (job: "일반", age: 15);
            var dave = (job: "일반", age: 21);

            Console.WriteLine($"alice : {GetDiscountRate(alice)}");
            Console.WriteLine($"bob : {GetDiscountRate(bob)}");
            Console.WriteLine($"charlie : {GetDiscountRate(charlie)}");
            Console.WriteLine($"dave : {GetDiscountRate(dave)}");
        }
    }
}

