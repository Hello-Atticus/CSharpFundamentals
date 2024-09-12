using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloClassAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Car();
            v1.Run();

            Vehicle v2 = new Truck();
            v2.Run();
        }
    }

    abstract class Vehicle
    {
        public void Stop()
        {
            Console.WriteLine("Stopped.");
        }

        public void Fill()
        {
            Console.WriteLine("Fill petrol..");
        }

        public abstract void Run();
    }

    class Car:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }
    class Truck : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running...");
        }
    }
    class RaceCar : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("RaceCar is running...");
        }
    }
}
