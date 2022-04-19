using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 그동안 '상수'라는 이름을 오래도록 잊고 지냈죠?

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
