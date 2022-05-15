using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 인터페이스를 상속할 수 있는 것은 클래스뿐이 아닙니다. 클래스의 사촌인 구조체는 물론이고, 인터페이스도 인터페이스를 상속할 수 있습니다. 기존의 인터페이스에
// 새로운 기능을 추가한 인터페이스를 만들고 싶을 때 인터페이스를 상속하는 인터페이스를 만들면 됩니다. 그냥 인터페이스를 수정하면 되지 않냐고요? 가능하다면
// 그렇게 해도 문제는 없습니다. 하지만 다음의 경우처럼 인터페이스를 수정할 수 없을 때는 인터페이스를 상속하는 인터페이스를 이용해야 합니다.


namespace Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);

        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine("{1} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILooger logger)
        {
            this.logger = logger;
        }

        public void Start()
        {
            while(true)
            {
                Console.Write("온도를 입력해주세요.:");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;

                logger.WriteLog("현재 온도 : " + temperature);
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));

                monitor.Start();
            }
        }
    }
}

