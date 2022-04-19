using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 중첩클래스를 사용하는 이유

// 1. 클래스 외부에 공개하고 싶지 않은 형식을 만들고자 할 때
// 2. 현재클래스의 일부분처럼 표현할 수 있는 클래스를 만들고자 할 때


namespace _002.MiddleGrammar
{
   class Configuration
    {
        private readonly int min; // readonly를 이용해서 읽기 전용 필드를 선언합니다.
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

    class MainApp
    {
        static void Main(string[] args)
        {
            Configuration c = new Configuration(100, 10);
        }
    }
}
