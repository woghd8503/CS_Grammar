using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 지금까지는 인터페이스에 선언하는 메소드에 구현부가 없었죠?


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

