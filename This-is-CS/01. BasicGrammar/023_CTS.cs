using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Common Type System이라는 .NET의 형식 체계 표준

// GetType() 메소드와 ToString() 메소드
// 모든 데이터 형식은 object 형식으로부터 상속받는다고 한 사실, 기억하고 있지요? 상속을 받으면 부모가 가진 것을
// 모두 물려받습니다. 우리가 CTS 예제 코드에서 사용한 GetType()과 ToString() 메소드는 사실 System.Int32와 int,
// System.String과 string 형식이 object 형식으로부터 물려받아 같고 있는 것입니다.
// GetType() 메소드는 해당 변수(객체라고 부르는 것이 맞지만, 이 용어는 나중에 사용토록 하겠습니다.)의 실제 형식을 알려주고,
// ToString() 메소드는 변수의 데이터를 문자열로 표시하는 기능을 가지고 있습니다. 우리는 위 코드에서 해당 변수의 데이터
// 형식을 알아내기 위해 System.Int32, int, System.String, string 형식 변수의 GetType() 메소드를 호출했고, 이 형식 정보를
// 문자열로 표시하기 위해 ToString() 메소드를 호출했습니다.

namespace _01.BasicGrammar
{
    class CTS
    {
        static void Main(string[] args)
        {
            System.Int32 a = 123;
            int b = 456;

            Console.WriteLine("a type:{0}, value{1}", a.GetType().ToString(), a);
            Console.WriteLine("b type:{0}, value{1}", b.GetType().ToString(), b);

            System.String c = "abc";
            string d = "def";

            Console.WriteLine("c type:{0}, value:{1}", c.GetType().ToString(), c);
            Console.WriteLine("d type:{0}, value:{1}", d.GetType().ToString(), d);
        }
    }
}
