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

    class SwitchExp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("점수를 입력하세요");
            int score = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("재수강인가요? (y/n)");
            string line = Console.ReadLine();
            bool repeated = line == "y" ? true : false;

            string grade = (int)(Math.Truncate(score / 10.0) * 10) switch
            {
                90 when repeated == true => "B+",
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"
            };

            Console.WriteLine($"학점 : {grade}");
        }
    }
}
        }
    }
}

// TryParse() vs Parse()
// C#에서 제공하는 기본 숫자 형식은 문자열을 숫자로 변환하는 Parse() 메소드를 제공합니다. 수자 형식은 Parse()뿐만 아니라
// TryParse() 메소드도 제공합니다. 이름에서 볼 수 있는 것처럼 두 메소드는 같은 기능을 합니다. 이둘의 차이는 변환이
// 실패하는 경우를 어떻게 다루는가에 있습니다. Parse() 메소드는 변환이 실패하면 예외 exception라는 것을 던집니다. 예외가 던져지면
// 프로그램은 현재 코드의 실행을 멈추고 흐름을 다른 곳으로 이동하게 됩니다. 반면, TryParse() 메소드는 변환의 성공 여부를
// 반환하기 때문에 현재의 코드 흐름을 유지할 수 있습니다. TryParse()가 변환한 데이터는 두 번째 매개변수에 저장됩니다.
// Switch2 예제 코드의 12행, 14행을 보면 이 매개변수는 특이하게 out이라는 키워드로 수식 되어 있습니다.
// 지금은 out 키워드가 출력 전용 매개변수임을 나타내는 용도로 쓰인다는 정도만 알아두면 충분합니다.

// 이 두 메소드 중 어떤 것이 더 나은지 이야기하려는 것은 아닙니다. 기능은 동일하지만 동작하는 방식이 다를뿐이니까요.
// 여러분이 경험을 쌓아나가면 어떤 상황에서 Parse() 메소드가 필요한지 또는 TryParse()메소드가 필요한지 판단할 수 있을 겁니다.
