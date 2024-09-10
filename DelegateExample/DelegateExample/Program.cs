namespace DelegateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WrapFactory wrapFactory = new WrapFactory();
            ProductFactory productFactory = new ProductFactory();

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

            Logger logger = new Logger();
            Action<Product> log = new Action<Product>(logger.Log);
            Box box1 = wrapFactory.WrapProduct(func1,log);
            Console.WriteLine(box1.Product.Name);

            Box box2 = wrapFactory.WrapProduct(func2,log);
            Console.WriteLine(box2.Product.Name);
            
        }
    }

    class Logger
    {
        public void Log(Product product)
        {
            Console.WriteLine("Product name is {0}, and it's produced at {1}. It's Price is {2}", product.Name, DateTime.UtcNow, product.Price);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory
    {
        public Box WrapProduct(Func<Product> getProduct, Action<Product> logCallback)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            if (product.Price > 50)
            {
                logCallback(product);
            }
            box.Product = product;
            return box;
        }
    }

    class ProductFactory
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 10;
            return product;
        }

        public Product MakeToyCar()
        {
            Product product= new Product();
            product.Name = "Toy Car";
            product.Price=100;
            return product ;
        }
    }
}
