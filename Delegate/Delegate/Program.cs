namespace Delegate
{
    public delegate double Calc(double x, double y);

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            //calculator.Report();
            Action action = new Action(calculator.Report);
            action.Invoke();

            Func<int, int, int> funcAdd = new Func<int, int, int>(calculator.Add);
            Func<int, int, int> funcSub = new Func<int, int, int>(calculator.Sub);

            int a = 100;
            int b = 200;
            int addResult = 0;
            addResult = funcAdd.Invoke(a, b);
            Console.WriteLine(addResult);

            int subResult = 0;
            subResult = funcSub.Invoke(a, b);
            Console.WriteLine(subResult);

            CalculatorDelegate calculatorDelegate = new CalculatorDelegate();
            Calc calcAdd = new Calc(calculatorDelegate.Add);
            double x = 15;
            double y = 50;
            double z = calcAdd.Invoke(x, y);
            Console.WriteLine(z);
        }
    }

    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 methods!");
        }

        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public int Sub(int a, int b)
        {
            int result = a - b;
            return result;

        }
    }

    class CalculatorDelegate
    {
        public double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }
        public double Sub(double a, double b)
        {
            double result = a - b;
            return result;
        }
    }
}