namespace DefineEventExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;
            customer.Action();
            customer.PayTheBill();
        }
    }

    public class OrderEventArgs : EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);
    public class Customer
    {
        private OrderEventHandler orderEventHandler;

        public event OrderEventHandler Order
        {
            add { orderEventHandler += value; }
            remove { orderEventHandler -= value; }
        }
        public double Bill { get; set; }
        public void PayTheBill()
        {
            Console.WriteLine("Customer: I will pay ${0}", this.Bill);
        }
        public void WalkIn()
        {
            Console.WriteLine("Walk in..");
        }
        public void Think()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Thinking...");
                Thread.Sleep(1000);
            }
            if (orderEventHandler != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "Chicken";
                e.Size = "large";

                this.orderEventHandler.Invoke(this, e);
            }
        }
        public void Action()
        {
            this.WalkIn();
            this.Think();
        }


    }
    public class Waiter
    {
        internal void Action(Customer customer, OrderEventArgs e)
        {
            Console.WriteLine("Waiter: I will serve you the dish-{0}", e.DishName);
            double price = 10;
            switch (e.Size)
            {
                case "small":
                    price *= 0.5;
                    break;
                case "large":
                    price *= 1.5;
                    break;
                default:
                    break;
            }
            customer.Bill += price;
        }
    }
}
