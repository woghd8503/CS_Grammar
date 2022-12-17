using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003._AdvanceGrammar
{
    class MyClass
    {
        [Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요.")]
        public void OldMethod()
        {
            Console.WriteLine("I'm old");
        }
    }
}
