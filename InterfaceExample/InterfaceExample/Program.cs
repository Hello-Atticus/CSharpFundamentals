namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Power power = new Power();
            Fan fan = new Fan(power);
            Console.WriteLine(fan.Work()); 
        }
    }

    public interface IPower
    {
        int GetPower();
    }

    public class Power : IPower
    {
        public int GetPower()
        {
            return 110;
        }
    }

    public class Fan
    {
        private IPower _power;
        public Fan(IPower power)
        {
            this._power = power;
        }

        public string Work()
        {
            if (this._power.GetPower() <= 0)
            {
                return "Won't work";
            }
            else if (this._power.GetPower() < 100)
            {
                return "Slow...";
            }
            else if (this._power.GetPower() < 200)
            {
                return "Works well";

            }
            else
            {
                return "Warning!!!";
            }
        }
    }
}
