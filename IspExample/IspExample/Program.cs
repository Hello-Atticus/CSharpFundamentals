namespace IspExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver(new LightTank());
            driver.Drive();
        }
    }

    interface IVehicle
    {
        void Run();
    }

    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running");
        }
    }

    class Truck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running");
        }
    }

    class Driver
    {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle)
        {
            this._vehicle = vehicle;
        }
        public void Drive()
        {
            this._vehicle.Run();
        }
    }

    interface IWeapon
    {
        void Fire();
    }
    /* 这个接口有两个功能，如果使用这个接口创建对象，driver不能开tank，除非把内部的IVehicle字段换成ITank
     * interface ITank
    {
        void Fire();
        void Run();
    }
    */
    //接口隔离原则
    interface ITank : IVehicle, IWeapon
    {

    }

    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!");
        }

        public void Run()
        {
            Console.WriteLine("Ka ka ka...");
        }
    }
}
