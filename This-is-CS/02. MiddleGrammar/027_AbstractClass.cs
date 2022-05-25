﻿using System;
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

namespace DefaultImplementation
{
    interface ILogger
    {
        void WriteLog(string message); 

        void WriteError(string error) // 새로운 메소드 추가
        {
            WriteLog($"Error: {error}");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("System Up");
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("System Up");  // OK
            // clogger.WriteError("System Fail"); // 컴파일 에러
        }
    }

}

