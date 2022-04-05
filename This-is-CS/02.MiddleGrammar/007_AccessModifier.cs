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
    class WaterHeater
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
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);
                heater.TurnOnWater();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
