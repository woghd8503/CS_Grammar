using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 객체지향 프로그래밍에서 다향성 Polymorphism은 객체가 여러 형태를 가질 수 있음을 의미합니다. 객체가 범블비처럼 변신이라도 한다는 이야기는 아니지만,
// 나름의 방법을 통해 다형성을 실현합니다. 다형성은 원래 하위 형식 다형성 subytype Polymorphism의 준말입니다. 다시 말해, 자신으로부터 상속받아 만들어진
// 파생 클래스를 통해 다형성을 실현한다는 겁니다. 예를 들어 토니 스타크가 Initialise()라는 메소드를 갖고 있는 ArmorSuite 클래스를 만들었다고 해봅시다.
// class ArmorSuite
// {
//      public virtual void Initialise()
//      {
//          Console.WriteLine("Armored");
//      }
// }
// 토니는 이 ArmorSuite를 업그레이드하기로 했습니다. 이때 장갑 수트는 수중 전투용, 비행용 등의 배리에이션이 나올 수 있으므로 ArmorSuite 자체를
// 뜯어고치기보다 (클래스는 실체가 아닌 설계도 역할을 합니다. ArmorSuite 클래스도 마찬가지고요) 다음과 같이 ArmorSuite를 상속하는 파생 클래스를 만들기로
// 했습니다.

// class IronMan : ArmorSuite
//{
//      //...
//}

//class WarMachine : ArmorSuite
//{
//     //...
//}

// private으로 선언한 메소드는 오버라이딩할 수 없습니다.
// private으로 선언된 멤버는 어차피 파생 클래스에서 보이지도 않습니다. 같은 이름, 같은 형식, 같은 매개변수를 이용하여 선언했다 하더라도 
// 컴파일러는 기반 클래스의 메소드를 재정의한다고 생각하지 않고 전혀 없었던 메소드를 선언한다고 간주할 겁니다. 


namespace _002.MiddleGrammar
{
    class ArmorSuite
    {
        public virtual void Initialise()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialise()
        {
            base.Initialise();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine
}
