﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 인터페이스를 상속할 수 있는 것은 클래스뿐이 아닙니다. 클래스의 사촌인 구조체는 물론이고, 인터페이스도 인터페이스를 상속할 수 있습니다. 기존의 인터페이스에
// 새로운 기능을 추가한 인터페이스를 만들고 싶을 때 인터페이스를 상속하는 인터페이스를 만들면 됩니다. 그냥 인터페이스를 수정하면 되지 않냐고요? 가능하다면
// 그렇게 해도 문제는 없습니다. 하지만 다음의 경우처럼 인터페이스를 수정할 수 없을 때는 인터페이스를 상속하는 인터페이스를 이용해야 합니다.

// 상속하려는 인터페이스가 소스 코드가 아닌 어셈블리로만 제공되는 경우: .NET SDK에서 제공하는 인터페이스들이 그 예입니다. 어셈블리 안에 있기 때문에 인터페이스를 
// 수정할 수 없습니다. 이 인터페이스에 새로운 기능을 추가한 인터페이스를 만들고 싶으면 상속하는 수밖에 없습니다.

// 상속하려는 인터페이스의 소스 코드를 갖고 있어도 이미 인터페이스를 상속하는 클래스들이 존재하는 경우: 클래스는 반드시 인터페이스의 "모든" 메소드와 프로퍼티를 구현해야
// 합니다. 인터페이스에 사소한 수정이라도 이루어지면 이 인터페이스를 상속하는 기존 클래스들은 소스 코드를 빌드할 때 컴파일 에러가 발생할 겁니다. 이런 상황에서 기존의 소스
// 코드에 영향을 주지 않고 새로운 기능을 추가하기 위해서는 인터페이스를 상속하는 인터페이스를 이용하는 편이 좋습니다.


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

