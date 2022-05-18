using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 클래스는 여러 클래스를 한꺼번에 상속할 수 없습니다. 이른바 "죽음의 다이아몬드"라는 문제 때문입니다. 죽음의 다이아몬드란, 최초의 클래스 (Ridable)가 두 개의 파생 클래스
// (Car, Plane)로부터 상속받고, 이 두 개의 파생 클래스를 다시 하나의 클래스 (MyVehicle)가 상속하는 것을 말합니다. 여러분이 컴파일러라면 MyVehicle이 어느 Ride() 메소드를
// 물려받도록 하겠습니까? Car 버전의 Ride()? 아니면 Plane 버전의 Ride()? 기준은 무엇인가요? 죽음의 다이아몬드 문제의 핵심은 모호성입니다. 검파일러가 기분이 좋다면 Car의
// Ride()를 물려받도록 할 수도 있습니다. 하지만 어느날 컴파일러 버전이 업그레이드돼서 Plane의 Ride()를 물려받도록 할 수도 있거든요.

// 여기에 또 하나 골칫거리가 있습니다. 바로 업캐스팅 Up-casting 문제입니다. 다중 상속이 허용된다면 다음과 같은 코드가 가능할 겁니다.
// 자, plane은 과연 어떤 결과를 출력할까요? "Run"을 출력하겠습니까, 아니면 "Fly"를 출력하겠습니까? 모를 일입니다. 알 수가 없지요. 코드를 작성하는 프로그래머조차 확실할 수 없습니다.


namespace DerivedInterface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params object[] args);
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog(string format, params object[] args)
        {
            string message = string.Format(format, args);
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The world is not flat.");
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
        }
    }
}

