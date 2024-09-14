namespace IspExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //只有用IKiller定义的变量才能访问kill方法
            IKiller killer = new WarmKiller();
            killer.Kill();
            var wk = (IGentleman)killer;
            wk.Love();
        }
    }

    interface IKiller
    {
        void Kill();
    }
    interface IGentleman
    {
        void Love();
    }

    class WarmKiller : IGentleman, IKiller
    {
        public void Love()
        {
            Console.WriteLine("I love you!");
        }

        void IKiller.Kill()
        {
            Console.WriteLine("I will kill the enamy");
        }
    }
}
