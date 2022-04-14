using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 토니는 장갑 수트 ArmorSuite를 개발할 때 차후에 업그레이드가 있을 것을 고려해서 Initialise() 메소드를 virtual로 선언했습니다. 
// 오버라이딩을 통해 재정의할 수 있도록 말입니다. 어떤 메소드가 향후 오버라이딩이 될지 안 될지를 판단하는 것은 깊이 생각할수록, 
// 또 많이 경험할수록 좋은 답을 얻기는 하지만 공식은 없습니다. 

namespace _002.MiddleGrammar
{
    class ArmorSuite
    {
        public virtual void Initialise()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialise()
        {
            base.Initialise();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialise()
        {
            base.Initialise();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating ArmorSuite...");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialise();

            Console.WriteLine("\nCreatig IronMan...");
            ArmorSuite ironman = new IronMan();
            ironman.Initialise();

            Console.WriteLine("\nCreating WarMachine...");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialise();
        }
    }
}
