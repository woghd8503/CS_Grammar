using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 클래스는 여러 클래스를 한꺼번에 상속할 수 없습니다. 이른바 "죽음의 다이아몬드"라는 문제 때문입니다. 죽음의 다이아몬드란, 최초의 클래스 (Ridable)가 두 개의 파생 클래스
// (Car, Plane)로부터 상속받고, 이 두 개의 파생 클래스를 다시 하나의 클래스 (MyVehicle)가 상속하는 것을 말합니다. 여러분이 컴파일러라면 MyVehicle이 어느 Ride() 메소드를
// 물려받도록 하겠습니까? Car 버전의 Ride()? 아니면 Plane 버전의 Ride()?


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

