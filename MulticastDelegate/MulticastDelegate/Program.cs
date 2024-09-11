using System.Threading;
namespace MulticastDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID=1,PenColor=ConsoleColor.Green};
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Yellow };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Blue };

            Action act1 = new Action(stu1.DoHomework);
            Action act2 = new Action(stu2.DoHomework);
            Action act3 = new Action(stu3.DoHomework);

            //多播委托
            act1 += act2;
            act1 += act3;
            act1.Invoke();

            //委托隐式异步调用，这是旧版本的方法，新版本使用async和await进行异步调用
            //act1.BeginInvoke(null, null);
            //act2.BeginInvoke(null, null);
            //act3.BeginInvoke(null, null);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main thread {0}", i);
                Thread.Sleep(1000);
            }

        }
    }

    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomework()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student {0} doing homework {1} hours.", this.ID, i);
                Thread.Sleep(1000);
            }

        }

    }
}
