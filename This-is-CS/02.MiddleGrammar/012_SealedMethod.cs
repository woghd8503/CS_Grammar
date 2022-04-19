using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 그동안 '상수'라는 이름을 오래도록 잊고 지냈죠? 변수는 변하는 데이터를 담지만, 상수는 변치 않는 데이터를 담습니다. 상수는 다음과 같이 const 키워드를 이용해서 선언합니다.\
// 상수는 다음과 같이 const 키워드를 이용해서 

namespace _002.MiddleGrammar
{
    class Base
    {
        public virtual void SealMe()
        {
        }
    }

    class Derived : Base
    {
        public sealed override void SealMe()
        {
        }
    }

    class WantToOverride : Derived
    {
        /*public override void SealMe() // 에러 발생
        {
        }*/
    }

    class MainApp
    {
        static void Main(string[] args)
        {

        }
    }
}
