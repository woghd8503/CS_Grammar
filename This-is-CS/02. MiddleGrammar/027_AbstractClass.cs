using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 추상 클래스는 "구현"을 가질 수 있습니다. 하지만 클래스와 달리 인스턴스를 가질 수는 없습니다. 한마디로, 추상 클래스는 구현을 갖되 인스턴스는
// 만들지 못합니다. 추상 클래스가 어떤 효용을 갖는지는 나중에 이야기하고, 먼저 추상 클래스를 선언하는 문법부터 살펴보겠습니다. 추상 클래스는 다음과 같이
// abstract 한정자와 class 키워드를 이용해서 선언합니다.

// 추상 클래스가 인터페이스와 클래스의 중간에 있다고 이야기했지만, 사실 추상 클래스는 클래스에 더 가깝습니다. 추상 클래스의 접근성이 그 예입니다. 클래스와
// 똑같거든요. 인터페이스에서는 모든 메소드가 public으로 선언되는 반면, 클래스는 한정자를 명시하지 않으면 모든 메소드가 private으로 선언됩니다.

// 한편, 추상 클래스에는 인스턴스를 만들 수 없다는 점 외에도 클래스와 다른 점이 또 하나 있습니다. 그것은 바로 추상 메소드 Abstract Method를 가질 수 있다는
// 사실입니다. 추상 메소드는 추상 클래스가 한편으로 인터페이스의 역할도 할 수 있게 해주는 장치입니다. 구현을 갖지는 못하지만 파생 클래스에서 반드시 구현하도록
// 강제하거든요. 다시 말해, 추상 클래스를 상속하는 클래스들이 반드시 이 메소드를 갖고 있을 거라는 "약속"인 것입니다. 그럼 이 추상 메소드의 기본 접근성은 어떻게
// 될까요? 인터페이스에서 처럼 public 일까요? 아니면 클래스에서처럼 private일까요? 답은 "둘 다" 입니다. 



namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }

        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMehtodA()");
        }

        public abstract void AbstractMethodA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine($"Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }

}

// 지금까지는 추상 클래스가 무엇인지에 대해 이야기 했습니다. 그럼 이제는 추상 클래스가 무슨 쓸모가 있는지 생각해봅시다. 추상 클래스는 일반 클래스가 가질 수 있는
// 구현과 더불어 추상 메소드를 가지고 있습니다 (물론, 추상 메소드가 없는 추상 클래스도 문법적으로 하자가 있는 것은 아니지만, 실질적으로는 별 의미가 없는 코드라고 할
// 수 있습니다). 추상 메소드는 추상 클래스를 사용하는 프로그래머가 그 기능을 정의하도록 강제하는 장치입니다.

// 우리는 똑같은 일을 보통의 클래스를 통해서도 할 수 있습니다. 그냥 메소드를 선언한 다음, 클래스에 대한 메뉴얼을 작성해서 코드와 함께 배포합니다.

