﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 추상 클래스는 "구현"을 가질 수 있습니다. 하지만 클래스와 달리 인스턴스를 가질 수는 없습니다.

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

