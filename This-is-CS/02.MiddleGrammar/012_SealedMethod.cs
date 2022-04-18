using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스를 (상속이 안 되도록) 봉인하는 것처럼 메소드도 (오버라이딩되지 않도록) sealed 키워드를 이용해서 봉인할 수 있습니다. 그렇다고 모든 메소드를 봉인할 수 있는
// 것은 아니고, virtual로 선언된 가상 메소드를 오버라이딩한 버전의 메소드만 가능합니다. 예를 들어 다음과 같이 Base 클래스와 Derived 클래스가 있다고 하면, Derived의
// SealMe()만 봉인할 수 있습니다.
namespace _002.MiddleGrammar
{
    class Base
    {
        public void MyMethod()
        {
            Console.WriteLine("Base.MyMethod()");
        }
    }

    class Derived : Base
    {
        public new void MyMethod()
        {
            Console.WriteLine("Derived.MyMethod()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.MyMethod();

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();

            Base baseOrDerived = new Derived();
            baseOrDerived.MyMethod();
        }
    }
}
