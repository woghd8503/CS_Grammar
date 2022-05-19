using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 지금까지는 인터페이스에 선언하는 메소드에 구현부가 없었죠? 인터페이스가 선언하는 메소드는 파생될 클래스가 무엇을 구현해야
// 할지를 정의하는 역할만 하면 됐기 때문입니다. 기본 구현 메소드는 이름처럼 구현부를 가지는 메소드인데요. 인터페이스의 다른
// 메소드와는 역할이 약간 다릅니다. 기본 구현 메소드를 자세히 설명하기 전에, 다음 코드를 같이 보시죠.


// interface ILogger
//{
//   void WriteLog(string message);
//}

// class ConsoleLogger : ILogger
//{
//     public void WriteLog(string message)
//     {
//          Console.WriteLine( $"{DateTime.Now.ToLocalTime()}, {message}");
//     }
//}

// ILogger는 평범한 인터페이스이며, ConsoleLogger는 ILogger를 상속하는 평범한 클래스입니다. ILogger에는 WriteLog()라는
// 메소드가 선언되어 있기 때문에 ILogger를 상속하는 ConsoleLogger는 이 메소드를 오버라이딩해야 합니다. 여기까지는 우리가
// 잘 이해하고 있는 내용입니다. 이제 이 코드에 무구한 역사가 더해져 ConsoleLogger도 업그레이드되었을 뿐 아니라, FileLogger와
// 같은 ILogger의 파생 클래스가 수없이 생겼다고 가정해보죠. 이런 코드를 레거시 ( Legacy : 유산 )라고 하는데요. 레거시 코드는
// 업그레이드에 각별한 주의가 필요합니다.


namespace MultiInterfaceInheritance
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }

        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            FlyingCar Car = new FlyingCar();
            Car.Run();
            Car.Fly();

            IRunnable runnable = Car as IRunnable;
            runnable.Run();

            IFlyable flyable = Car as IFlyable;
            flyable.Fly();
        }
    }

}

