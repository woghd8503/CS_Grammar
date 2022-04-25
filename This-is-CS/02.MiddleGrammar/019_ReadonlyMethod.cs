using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadonlyMethod
{
    struct ACSetting
    {
        public double currentInCelsius; // 현재 온도 
        public double target;           // 회망 온도

        public readonly double GetFahrenheit()
        {
            target = currentInCelsius * 1.8 + 32;
            return target; // target 반환
        }
    }
        public readonly byte B;

        public RGBColor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            RGBColor Red = new RGBColor(255, 0, 0);
            Red.G = 100; // 컴파일 에러
        }
    }
}
