using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _002.MiddleGrammar
{
    class Configuration
    {
        private readonly int min; // readonly 를 이용해서 읽기 전용 필드를 선언합니다.
        private readonly int max;

        public Configuration(int v1, int v2)
        {
            min = v1;            // 읽기 전용 필드는 생성자 안에서만 초기화 가능합니다.
            min = v2;
        }

        public void ChangeMin(int newMax)
        {
            // max = newMax;      // 생성자가 아닌 다른 곳에서 값을 수정하려 하면 컴파일 에러가 발생합니다.
        }
    }
   
    class MainApp
    {
        static void Main(string[] srgs)
        {
            Configuration c = new Configuration(100, 10);
        }
    }
}
