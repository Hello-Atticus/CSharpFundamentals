using System.Reflection;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITank tank = new LightTank();
            //tank.Run();
            //tank.Fire();
            Console.WriteLine("----------------------");
            var t = tank.GetType();
            Console.WriteLine(t);
            object o = Activator.CreateInstance(t);
            MethodInfo fireMI = t.GetMethod("Fire");
            fireMI.Invoke(o, null);



        }

    }
    interface IVehicle
    {
        void Run();
    }
    interface IWeapon
    {
        void Fire();
    }

    interface ITank : IWeapon, IVehicle
    {

    }

    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }


    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }

        public void Run()
        {
            Console.WriteLine("Ka ka ka...");
        }
    }
    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!!");
        }

        public void Run()
        {
            Console.WriteLine("Ka! ka! ka!...");
        }
    }
}
