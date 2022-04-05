using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 객체지향 프로그래밍의 3대 특성 은닉성 Encapsulation
// 객체지향 프로그래밍에는 여러 가지 특성이 있습니다. 그중에서도 3대 특성으로 꼽히는 것들이 있는데 이 셋중의 하나가 바로 은닉성이며
// 나머지 2개는 상속성 inheritance과 다형성 polymorphism입니다. 

// 접근 한정자                       설명
// public              클래스의 내부/외부 모든 곳에서 접근할 수 있습니다.
// protected           클래스의 외부에서는 접근할 수 없지만, 파생 클래스에서는 접근이 가능합니다.
// private             클래스의 내부에서만 접근할 수 있습니다. 파생 클래스에서도 접근이 불가능합니다.
// internal            같은 어셈블리에 있는 코드에서만 public으로 접근할 수 있습니다. 다른 어셈블리에 있는 코드에서는 private과 같은 수준의 접근성을 가집니다.
// protected internal  같은 어셈블리에 있는 코드에서만 protected로 접근할 수 있습니다. 다른 어셈블리에 있는 코드에서는 private과 같은 수준의 접근성을 가집니다.
// private protected   같은 어셈블리에 있는 코드에서만 protected로 접근할 수 있습니다. 다른 어셈블리에 있는 코드에서는 private과 같은 수준의 접근성을 가집니다.

namespace _002.MiddleGrammar
{
    class WeaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temperature)
        {
            if (temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }

            this.temperature = temperature;
        }

        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }

        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }

        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MyClass({b})");
        }

        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass({b}), {c}");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            Console.WriteLine();

            MyClass c = new MyClass(10, 20);
            c.PrintFields();
        }
    }
}
