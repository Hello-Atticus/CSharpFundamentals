namespace Delegate
{
    //Define delegate
    public delegate int CalcDelegate(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Action action = new Action(calc.Report);
            action.Invoke();//it also can be action();

            Func<int,int,int> funcAdd = new Func<int,int,int>(calc.Add);
            int a = 100;
            int b = 200;

            int result = funcAdd.Invoke(a, b);
            Console.WriteLine(result);

            CalcDelegate calcDelegateSub = new CalcDelegate(calc.Sub);
            int c = calcDelegateSub.Invoke(a,b);
            Console.WriteLine("Delegate:"+c);
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
