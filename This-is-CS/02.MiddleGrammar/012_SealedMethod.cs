using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 그동안 '상수'라는 이름을 오래도록 잊고 지냈죠? 변수는 변하는 데이터를 담지만, 상수는 변치 않는 데이터를 담습니다. 상수는 다음과 같이 const 키워드를 이용해서 선언합니다.\
// 상수는 다음과 같이 const 키워드를 이용해서 선언합니다. (기억이 돌아오지요? 자세한 내용은 3장에서 복습할 수 있습니다.)

//const double pi = 3.14159265359;


namespace _002.MiddleGrammar
{
   class Configuration
    {
        private readonly int min; // read
        private readonly int max;

        public Configuration(int v1, int v2)
        {
            min = v1;
            min = v2; // 읽기 전용 필드는 생성자 안에서만 초기화 가능합니다.
        }

        public void ChangeMax(int newMax)
        {
            max = newMax;  //  생성자가 아닌 다른 곳에서 값을 수정하려하면 컴파일 에러가 발생합니다.
        }
    }


}
