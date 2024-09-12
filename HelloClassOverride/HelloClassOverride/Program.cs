using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloClassOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //这里都使用Vehicle这个类去定义变量，但最终的run方法要根据具体对象去决定，这就是多态
            Vehicle v1 = new Car();
            v1.Run();
            Vehicle v2 = new Bus();
            v2.Run();
        }
    }

    class Vehicle
    {
        public virtual void Run()
        {
            Console.WriteLine("I'm running!");
        }
    }
    class Car : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is running");

        }
    }

    class Bus : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Bus is running");
        }
    }
}