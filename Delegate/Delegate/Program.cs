namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Action action = new Action(calc.Report);
            action.Invoke();//it also can be action();
        }
    }

    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have a calculator.");
        }
        public int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }

        public int Sub(int x, int y)
        {
            int result = x - y;
            return result;
        }


    }
}
